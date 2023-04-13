using System.ComponentModel.DataAnnotations;
using RenderViewToStringSample.Models;

namespace RenderViewToStringSample.Services
{
    public interface IUserService
    {
        Task<string> SendEmail(EmailViewModel emailViewModel);
    }
}
