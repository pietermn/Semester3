using System;
namespace authAPI_DTO
{
    public class TokenDTO
    {
        public string JwtToken { get; private set; }
        public string RefreshToken { get; private set; }

        public TokenDTO(string jwtToken, string refreshToken)
        {
            JwtToken = jwtToken;
            RefreshToken = refreshToken;
        }
    }
}
