using EMS.Core.Interfaces;

namespace EMS.Services.EmailService 
{
    public class EmailService : IEmailService {
        private readonly ILogger _logger;

        public EmailService(ILogger logger){
            _logger = logger;
        }

        public void SendEmail(string recipientEmail, string subject, string content){
            
            // Implementer la logique pour envoyer un email
            _logger.Log($"E-mail envoyé à {recipientEmail}: {content} avec le sujet {subject} ");
        }

    }
}