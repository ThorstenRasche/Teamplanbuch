namespace Teamplanbuch.Application.Abstractions;

public interface IEmailService
{
    Task SendInvitationAsync();
    Task SendInvitationAcceptedAsync();
}
