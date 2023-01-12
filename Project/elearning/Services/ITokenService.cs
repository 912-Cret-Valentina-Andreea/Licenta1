using elearning.Entities;

namespace elearning.Services
{
    public interface ITokenService
    {
        string CreateToken(Users user);
    }
}
