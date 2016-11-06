using The.Apps.Game.Core.Data.Models.Users;
using The.Apps.Game.Core.Services.Results;

namespace The.Apps.Game.Core.Services.Users
{
    public interface IUserService
    {
        OperationResult<User> LogIn(string name, string password);
        OperationResult<User> Get(string name);
        OperationResult<User> Get(int id);
        OperationResult<User> Register(User model);
        OperationResult<User> GetCurrent();
        OperationResult<User> Edit(User model);
        OperationResult<User> EditDetails(User model);
        OperationResult<User> ChangePassword(string oldPassword, string newPassword);
    }
}
