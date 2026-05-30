using System.Net.Http.Headers;

namespace FightingFlowDotNet.Auth;

public class AuthHandler : DelegatingHandler
{
    private readonly Supabase.Client _client;
    
    public AuthHandler(Supabase.Client client)
    {
        _client = client;
    }

    protected override async Task<HttpResponseMessage> SendAsync(
        HttpRequestMessage request,
        CancellationToken cancellationToken
        )
    {
        var session = _client.Auth.CurrentSession;

        if (session != null && !string.IsNullOrEmpty(session.AccessToken))
        {
            request.Headers.Authorization = new AuthenticationHeaderValue(
                "Bearer", session.AccessToken);
        }

        return await base.SendAsync(request, cancellationToken);
    }
}