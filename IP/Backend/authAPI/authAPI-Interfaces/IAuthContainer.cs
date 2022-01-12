using System;
using System.Threading.Tasks;
using authAPI_DTO;

namespace authAPI_Interfaces
{
    public interface IAuthContainer
    {
        public Task<TokenDTO> CreateUser(string email, string password);

        public Task<TokenDTO> LoginUser(string email, string password);
    }
}
