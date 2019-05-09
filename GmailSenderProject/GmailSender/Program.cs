using System;
using System.Net.Mail;

namespace GmailSender
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("### E-mail sender gmail ###");

            GEmail gmail = new GEmail();
            Console.WriteLine("Enter Sender Email");
            gmail.SenderEmail = new MailAddress(Console.ReadLine());
            Console.WriteLine("Enter Recipient Email");
            gmail.RecipientEmail = new MailAddress(Console.ReadLine());
            Console.WriteLine("Enter Subject");
            gmail.Subject = Console.ReadLine();
            //Console.WriteLine("Enter email message");
            gmail.Message = "<h1>Hello World 2.</h1><br /><img src='http://localhost:56078/Handler1.ashx?id=1' />";
            Console.WriteLine("Enter gmail id");
            gmail.GmailId = Console.ReadLine();
            Console.WriteLine("Enter password");
            gmail.GmailPwd = Console.ReadLine();

            try
            {
                GEmail.SendMessage(gmail);
                Console.WriteLine("Mail send");
                Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception occured " + ex.Message);
                Console.ReadLine();
            }
        }
    }
}
