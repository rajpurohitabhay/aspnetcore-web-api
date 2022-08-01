using System.Security.Claims;

namespace SuperHeroAPI.Services.UserService
{
    public class UserService : IUserService
    {
        private readonly IHttpContextAccessor _httpContextAccessor;

        public UserService(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
        }
        public string GetMyName()
        {
            var name = string.Empty;
            if(_httpContextAccessor.HttpContext != null)
            {
                name = _httpContextAccessor.HttpContext.User.FindFirstValue(ClaimTypes.Name);
            }
            return name;
        }
    }
}
