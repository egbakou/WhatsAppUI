using System.Collections.Generic;
using WhatsApp.Models;

namespace WhatsApp.Services
{
    public class StatutsService
    {
        public static Me GetMyInfo()
        {
            Me MyInfo = new Me
            {
                MeID = 1,
                Name = "Egbakou",
                PhoneNumber = "+22800000000",
                ProfileImage = "noimage.png",
                Status = new Status
                {
                    StutusID = 1,
                    Description = "Ready for sale",
                    Image = "hmo.png",
                    PushDate = "20 minutes ago"                                    
                }
            };

            return MyInfo;
        }



        public static List<Status> GetRecentUpdates()
        {
            List<Status> RecentUpdates = new List<Status>
            {
                new Status
                {
                    StutusID = 2,
                    Image = "hawei.png",
                    Description = "Chinese Phone",
                    PushDate = "2 minutes ago",                  
                    Contact = new Contact
                    {
                        ContactID = 3,
                        Name = "Flora",
                        PhoneNumber = "+228999999",
                        ProfileImage = "Flora.jpg"
                    }
                },
                new Status
                {
                     StutusID = 3,
                     Image = "MacBookPro.png",
                     Description = " For sale",
                     PushDate = "10 minutes ago",
                     Contact = new Contact
                     {
                        ContactID = 4,
                        Name = "Rita",
                        PhoneNumber = "+228999999",
                        ProfileImage = "Rita.jpg"                      
                     }
                },
                new Status
                {
                    StutusID = 4,
                    Image = "infinix.jpg",
                    Description = "Infinix Phone",
                    PushDate = "15 minutes ago.",
                    Contact = new Contact
                    {
                        ContactID = 5,
                        Name = "Sara",
                        PhoneNumber = "+228999999",
                        ProfileImage = "Sara.jpg"
                    }
                },
                new Status
                {
                    StutusID = 5,
                    Image = "firstMacAppVS.jpg",
                    Description = "Create first App for Mac",
                    PushDate = "32 minutes ago",                   
                    Contact = new Contact
                    {
                        ContactID = 6,
                        Name = "Riana",
                        PhoneNumber = "+228999999",
                        ProfileImage = "Riana.jpg"
                    }
                },
                new Status
                {
                    StutusID = 6,
                    Image = "raspberryCar.jpg",
                    Description = "Raspberry Car from Sunfounder",
                    PushDate = "49 minutes ago",
                    Contact = new Contact
                    {
                        ContactID = 7,
                        Name = "Grace",
                        PhoneNumber = "+228999999",
                        ProfileImage = "Grace.jpg"                       
                    }
                },
                new Status
                {
                    StutusID = 7,
                    Image = "firstMacAppVS.jpg",
                    Description = "Create first App for Mac",
                    PushDate = "49 minutes ago",
                    Contact = new Contact
                    {
                        ContactID = 8,
                        Name = "Alice",
                        PhoneNumber = "+228999999",
                        ProfileImage = "Alice.jpg"
                    }
                }
            };

            return RecentUpdates;
        }
    }
}
