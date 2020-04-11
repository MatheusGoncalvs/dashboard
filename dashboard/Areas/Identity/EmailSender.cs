﻿using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.Extensions.Configuration;
using SendGrid;
using SendGrid.Helpers.Mail;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dashboard.Areas.Identity
{
    public class EmailSender : IEmailSender
    {
        private readonly string _apiKey;
        private readonly string _fromName;
        private readonly string _fromEmail;

        public EmailSender(IConfiguration config)
        {
            _apiKey = config["SendGrid:ApiKey"];
            _fromName = config["SendGrid:FromName"];
            _fromEmail = config["SendGrid:FromEmail"];
        }

        public async Task SendEmailAsync(string email, string subject, string message)
        {
            var client = new SendGridClient(_apiKey);
            var msg = new SendGridMessage()
            {
                From = new EmailAddress(_fromEmail, _fromName),
                Subject = subject,
                PlainTextContent = message,
                HtmlContent = message
            };
            msg.AddTo(new EmailAddress(email));

            msg.SetClickTracking(false, false);

            await client.SendEmailAsync(msg);
        }
    }
}
