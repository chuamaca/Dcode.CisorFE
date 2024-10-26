using Dcode.Pos.Domain.Models.SendGridEmail;

namespace Dcode.Pos.Application.External.SendGridEmail
{
    public interface ISendGridEmailService
    {
        Task<bool> Execute(SendGridEmailRequestModel model);
    }
}
