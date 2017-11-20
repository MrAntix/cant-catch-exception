using System;
using System.Net.Mail;
using System.Threading.Tasks;
using Xunit;

namespace SmtpClient.CantCatchException
{
    public class try_to_catch
    {
        public const int NO_SERVER_PORT = 26;

        [Fact]
        public async Task when_no_server()
        {
            try
            {
                using (var smtp = new System.Net.Mail.SmtpClient("localhost", NO_SERVER_PORT))
                {
                    var message = new MailMessage(
                        "from@localhost", "to@localhost",
                        "Message Subject",
                        "Message Body");

                   await smtp.SendMailAsync(message);
                }
            }
            catch (Exception)
            {
                Assert.True(true, "success");
            }
        }
    }
}
