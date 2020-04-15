namespace AOM.CQRS.Api.Services.Interfaces
{
    public interface IEmailService
    {
        void Send(string name, string email);
    }
}
