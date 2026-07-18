using FirebaseAdmin.Auth;

namespace FightingFlowDotNet.Clients;

public class FirebaseAuthVerifier(FirebaseAuth firebaseAuth)
{
    public async Task<FirebaseToken?> TryVerifyAsync(string idToken)
    {
        try
        {
            return await firebaseAuth.VerifyIdTokenAsync(idToken, checkRevoked: true);
        }
        catch(FirebaseAuthException)
        {
            return null;
        }
    }
}