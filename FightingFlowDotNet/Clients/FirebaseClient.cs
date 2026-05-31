using Firebase.Auth;
using Firebase.Auth.Providers;
using Firebase.Auth.Repository;

namespace FightingFlowDotNet.Clients;

public class FirebaseClientFactory(IConfiguration configuration)
{
    public FirebaseAuthClient GetAuthClient()
    {
        var config = new FirebaseAuthConfig
        {
            ApiKey = configuration["Firebase:ApiKey"],
            AuthDomain = configuration["Firebase:AuthDomain"],
            Providers =
            [
                new GoogleProvider().AddScopes("email"),
                new EmailProvider()
            ],
            UserRepository = new FileUserRepository("FightingFlowUsers.DB")
        };
        return new FirebaseAuthClient(config);
    }
    
}