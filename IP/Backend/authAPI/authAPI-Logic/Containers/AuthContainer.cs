using System;
using System.Threading.Tasks;
using authAPI_DTO;
using authAPI_Interface_DAL;
using authAPI_Interfaces;
namespace authAPI_Logic.Containers
{
    public class AuthContainer : IAuthContainer
    {
        readonly IAuthDAL _AuthDAL;
        public AuthContainer(IAuthDAL AuthDAL)
        {
            _AuthDAL = AuthDAL;
        }

        public async Task<TokenDTO> CreateUser(string email, string password)
        {
            return await _AuthDAL.CreateUserAsync(email, password);
        }

        public async Task<TokenDTO> LoginUser(string email, string password)
        {
            return await _AuthDAL.LoginUserAsync(email, password);
        }
    }
}
