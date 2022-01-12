using System;
using System.Threading.Tasks;
using authAPI_DTO;

namespace authAPI_Interface_DAL
{
    public interface IAuthDAL
    {
        public Task<TokenDTO> CreateUserAsync(string email, string password);

        public Task<TokenDTO> LoginUserAsync(string email, string password);
    }
}
