using CTCT.Components.Contacts;
using CTCT.Services;
using Microsoft.WindowsAzure.MediaServices.Client;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> Exoiry = new List<int> { 20, 10, 5 };
            var CurrentDate = DateTime.Now;
            var ExpDate = DateTime.Now.AddDays(30);
            int? SaveDate = null;
            while ((ExpDate - CurrentDate).TotalDays > 0)
            {
                int First;
                if (SaveDate.HasValue)
                {
                      First = Exoiry.Where(x => x < SaveDate.Value).FirstOrDefault();

                }
                else
                {
                      First = Exoiry.FirstOrDefault();
                  
                }
                if ( Math.Floor((ExpDate - CurrentDate).TotalDays) == First)
                {
                    SendEMail();
                    SaveDate = First;
                }
                CurrentDate= CurrentDate.AddDays(1);
            }

        }

        public static  void SendEMail()
        {
            Console.WriteLine("Email Sent");
        }

        public void c()
        {
            try
            {

                IUserServiceContext userServiceContext = new UserServiceContext("28b41d8c-73d6-4dea-8cc9-cb99a7192e51", "uc37g5sq8nzryxmhn8n6qemj");
                var contactService = new ContactService(userServiceContext);
                var ListService = new ListService(userServiceContext);
                var contact = contactService.GetContacts("bhalmung3.knight@gmail.com", null, null, null);
                if (contact.Results.Count == 0)
                {
                    var List = ListService.GetLists(null);
                    Contact c = new Contact();
                    c.Confirmed = true;
                    c.EmailAddresses.Add(new EmailAddress()
                    {
                        EmailAddr = "bhalmung.knight3@gmail.com"
                        ,
                        ConfirmStatus = "CONFIRMED",
                        OptInDate = DateTime.Now.ToString("o"),
                        OptInSource = "ACTION_BY_VISITOR"
                    });
                    c.Lists = List.ToList();

                    //   c.FirstName = "bhalmung";
                    //  c.LastName = "Knight";

                    var cx = contactService.AddContact(c, true);
                }
            }
            catch (Exception ex)
            {

            }
        }
    }
}
