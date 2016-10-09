using The.Apps.Game.Core.Data.Models.Users;
using The.Apps.Game.Core.Services.Results;

namespace The.Apps.Game.Core.Services.Users
{
    public interface IUserService
    {
        OperationResult<User> LogIn(string name, string password);
        OperationResult<User> Get(string name);
        OperationResult<User> Get(int id);
        OperationResult<User> Register(string name, string password, string displayName, string email);
        OperationResult<User> GetCurrent();
    }
}
