using Firebase.Auth;

namespace FightingFlowDotNet.Clients;

public class UserData
{
    public  UserCredential? UserCredential { get; private set; }

    public void UpdateCredential(UserCredential? userCredential)
    {
        UserCredential = userCredential;
    }
    
    public async Task ChangePassword(string newPassword)
    {
        if (UserCredential is not null)
        {
            await UserCredential.User.ChangePasswordAsync(newPassword);
        }
    }

    public async Task DeleteUser()
    {
        if (UserCredential is not null)
        {
            await UserCredential.User.DeleteAsync();
        }
    }
}