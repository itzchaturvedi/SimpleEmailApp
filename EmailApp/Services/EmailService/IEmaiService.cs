namespace EmailApp.Services.EmailService
{
    public interface IEmaiService
    {
        void SendEmail(EmailDto request);
    }
}
