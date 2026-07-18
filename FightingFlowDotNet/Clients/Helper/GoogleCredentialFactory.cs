using System.Text.Json;
using Google.Apis.Auth.OAuth2;

namespace FightingFlowDotNet.Clients.Helper;

public static class GoogleCredentialFactory
{
    public static GoogleCredential Create(IConfiguration configuration, IHostEnvironment env)
    {
        return env.IsDevelopment()
            ? GoogleCredential.FromJson(
                JsonSerializer.Serialize(
                    configuration
                        .GetSection("GoogleCloud:ServiceAccountJson")
                        .Get<Dictionary<string, string>>()))
            : GoogleCredential.FromJson(configuration["GoogleCloud:ServiceAccountKey"]);
    }
}