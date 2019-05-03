using System.Collections.Generic;
using WhatsApp.Models;

namespace WhatsApp.Services
{
    public class CallService
    {
        public static List<Call> GetCallHistory()
        {
            List<Call> CallHistory = new List<Call>
            {
                new Call
                {
                    CallID = 1,
                    CallDate = "Just now",
                    OutCall = true,
                    InCall = false,
                    IsMissedCall = false,
                    Contact = new Contact
                    {
                        ContactID = 10,
                        Name = "Natalie",
                        PhoneNumber = "+228999999",
                        ProfileImage = "Natalie.jpg"
                    }
                },
                new Call
                {
                    CallID = 2,
                    CallDate = "2 minutes ago",
                    OutCall = false,
                    InCall = true,
                    IsMissedCall = true,
                    Contact = new Contact
                    {
                        ContactID = 9,
                        Name = "Centia",
                        PhoneNumber = "+228999999",
                        ProfileImage = "Centia.jpg"
                    }
                },
                new Call
                {
                    CallID = 3,
                    CallDate = "4 minutes ago",
                    OutCall = false,
                    InCall = true,
                    IsMissedCall = true,
                    Contact = new Contact
                    {
                        ContactID = 8,
                        Name = "Sandrine",
                        PhoneNumber = "+228999999",
                        ProfileImage = "Sandrine.jpg"
                    }
                },
                new Call
                {
                    CallID = 4,
                    CallDate = "11 minutes ago",
                    OutCall = true,
                    InCall = false,
                    IsMissedCall = false,
                    Contact = new Contact
                    {
                        ContactID = 7,
                        Name = "Valerie",
                        PhoneNumber = "+228999999",
                        ProfileImage = "Valerie.jpg"
                    }
                },
                new Call
                {
                    CallID = 5,
                    CallDate = "13 minutes ago",
                    OutCall = false,
                    InCall = true,
                    IsMissedCall = true,
                    Contact = new Contact
                    {
                        ContactID = 7,
                        Name = "Valerie",
                        PhoneNumber = "+228999999",
                        ProfileImage = "Valerie.jpg"
                    }
                },
                new Call
                {
                    CallID = 6,
                    CallDate = "23 minutes ago",
                    OutCall = true,
                    InCall = false,
                    IsMissedCall = false,
                    Contact = new Contact
                    {
                        ContactID = 6,
                        Name = "Alice",
                        PhoneNumber = "+228999999",
                        ProfileImage = "Alice.jpg"
                    }
                },
                new Call
                {
                    CallID = 7,
                    CallDate = "30 minutes ago",
                    OutCall = true,
                    InCall = false,
                    IsMissedCall = false,
                    Contact = new Contact
                    {
                        ContactID = 5,
                        Name = "Grace",
                        PhoneNumber = "+228999999",
                        ProfileImage = "Grace.jpg"
                    }
                },
                new Call
                {
                    CallID = 8,
                    CallDate = "50 minutes ago",
                    OutCall = true,
                    InCall = false,
                    IsMissedCall = false,
                    Contact = new Contact
                    {
                        ContactID = 4,
                        Name = "Riana",
                        PhoneNumber = "+228999999",
                        ProfileImage = "Riana.jpg"
                    }
                }
            };

            return CallHistory;
        }
    }
    
}
