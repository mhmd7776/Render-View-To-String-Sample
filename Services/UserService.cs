using RenderViewToStringSample.Models;

namespace RenderViewToStringSample.Services
{
    public class UserService : IUserService
    {
        #region Ctor

        private readonly IViewRenderService _viewRenderService;

        public UserService(IViewRenderService viewRenderService)
        {
            _viewRenderService = viewRenderService;
        }

        #endregion

        public async Task<string> SendEmail(EmailViewModel emailViewModel)
        {
            var result = await _viewRenderService.RenderToStringAsync("Email/EmailSampleView", emailViewModel);

            return result;
        }
    }
}