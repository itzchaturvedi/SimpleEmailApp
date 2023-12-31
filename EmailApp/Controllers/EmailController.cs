﻿using MailKit.Net.Smtp;
using MailKit.Security;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MimeKit;
using MimeKit.Text;

namespace EmailApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmailController : ControllerBase
    {
        private readonly IEmaiService _emailService;

        public EmailController(IEmaiService emailService)
        {
            _emailService = emailService;
        }

        [HttpPost]
        public IActionResult SendEmail(EmailDto request)
        {
            //var email = new MimeMessage();
            //email.From.Add(MailboxAddress.Parse("glen.langworth26@ethereal.email"));
            //email.To.Add(MailboxAddress.Parse("glen.langworth26@ethereal.email"));
            //email.Subject = "Test Email Subject";
            //email.Body = new TextPart(TextFormat.Html) { Text = body };
            //using var smtp = new SmtpClient();
            //smtp.Connect("smtp.ethereal.email", 587, SecureSocketOptions.StartTls);
            //smtp.Authenticate("glen.langworth26@ethereal.email", "nhqFytft6Ur4SwJyAk");
            //smtp.Send(email);
            //smtp.Disconnect(true);

            _emailService.SendEmail(request);
            return Ok();
        }
    }
}
