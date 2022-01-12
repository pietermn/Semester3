using System;
using System.Threading.Tasks;
using authAPI_DTO;
using authAPI_Interface_DAL;

namespace authAPI_DAL
{
    public class AuthDAL : IAuthDAL
    {
        public async Task<TokenDTO> CreateUserAsync(string email, string password)
        {
            try
            {
                var Token = await FirebaseAuth.AuthProvider.CreateUserWithEmailAndPasswordAsync(email, password);

                return new(Token.FirebaseToken, Token.RefreshToken);
            }
            catch
            {
                throw new Exception("Error");
            }
            
        }

        public async Task<TokenDTO> LoginUserAsync(string email, string password)
        {
            var Token = await FirebaseAuth.AuthProvider.SignInWithEmailAndPasswordAsync(email, password);

            return new(Token.FirebaseToken, Token.RefreshToken);
        }
    }
}
