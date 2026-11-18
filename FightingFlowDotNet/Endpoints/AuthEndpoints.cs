using System.Security.Claims;
using FightingFlowDotNet.Clients.Firebase;
using FightingFlowDotNet.Models;
using FirebaseAdmin.Auth;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;

namespace FightingFlowDotNet.Endpoints;

public static class AuthEndpoints
{
    public static IEndpointRouteBuilder MapAuthEndpoints(this IEndpointRouteBuilder auth)
    {
        var app = auth.MapGroup("auth");

        auth.MapPost("/signin", SignIn).RequireRateLimiting("auth");
        auth.MapPost("/signout", SignOut).RequireRateLimiting("auth");
        auth.MapPost("/signup", SignUp).RequireRateLimiting("signup");

        return auth;
    }

    private static async Task<IResult> SignIn(
        HttpContext http, 
        FirebaseAuthVerifier verifier)
    {
        using var reader = new StreamReader(http.Request.Body);
        var idToken = await reader.ReadToEndAsync();

        var token = await verifier.TryVerifyAsync(idToken);
        if (token is null) return Results.Unauthorized();

        var claims = new List<Claim>
        {
            new(ClaimTypes.NameIdentifier, token.Uid),
            new(
                ClaimTypes.Email, 
                token.Claims.GetValueOrDefault("email")?.ToString() ?? "")
        };
        var identity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
        await http.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(identity));

        return Results.Ok();
    }
    
    private static async Task<IResult> SignOut(HttpContext http)
    {
        await http.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
        return Results.Ok();
    }

    private static async Task<IResult> SignUp(
        AuthoriseUser user, 
        FirebaseAuth fbAuth, 
        FirestoreGetter fGetter)
    {
        var userRecord = await fbAuth.CreateUserAsync(new UserRecordArgs
        {
            Email = user.CustomUserInfo.Email,
            Password = user.Password
        });

        await fGetter.PostUser(user.CustomUserInfo);

        var customToken = await fbAuth.CreateCustomTokenAsync(userRecord.Uid);
        return Results.Ok(new { customToken});
    }
}