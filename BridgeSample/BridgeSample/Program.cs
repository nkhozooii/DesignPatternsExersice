using BridgeSample.MailService;
using System;

namespace BridgeSample
{
    class Program
    {
        static void Main(string[] args)
        {
            RefinedMailService mailService = new RefinedMailService();
            mailService.Send(new EmailInformationDto
            {
                Message = "this is a message from my app ",
                Reciver = "nkhozooii@gmail.com",
                Title = "Alert mail"
            });

            Console.ReadKey();
        }
    }
}
