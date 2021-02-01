using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using System.Net.Mime;
using BitventureApp.Models;
using System.ComponentModel;
using System.Net;

namespace BitventureApp.Service
{
    public class EmailService
    {

        public string SendEmail(Email email)
        {

            string Message;

            using (MailMessage mail = new MailMessage())
            {
               
                mail.From = new MailAddress("Tshidzivhe@gmail.com");
                mail.To.Add(email.To);
                mail.Subject = "Bitventure Code test";
                mail.Body = email.Body;
                mail.IsBodyHtml = true;
                
                //this email and password is used for purpose of sending app email only 

                using (SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587))
                {
                    smtp.Credentials = new NetworkCredential("Tshidzivhe@gmail.com", "Password@111@");
                    smtp.EnableSsl = true;
                    try
                    {
                      
                        smtp.Send(mail);
                        Message = "Email Sent";

                    }
                    catch (Exception ex)
                    {
                        Message = "Email not Sent";
                        Console.WriteLine($"{ex.Message}");
                    }
                }

            }

            return  Message;
        }


    }
}
