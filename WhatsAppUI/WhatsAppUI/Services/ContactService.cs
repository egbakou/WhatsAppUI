using System.Collections.Generic;
using WhatsApp.Models;

namespace WhatsApp.Services
{
    public class ContactService
    {
        public static List<Contact> GetAllContact()
        {
            List<Contact> contacts = new List<Contact>
            {
                new Contact
                {
                    ContactID = 1,
                    Name = "Flora",
                    PhoneNumber = "+228999999",
                    ProfileImage = "Flora.jpg",
                    ChatPinned = true,
                    ChatMetaData = new LastChatMetaData{
                        LastChatMetaDataID = 1,
                        LastChatDatetime = "Yesterday",
                        MessageIsFromMe = true,
                        MessageContent = new Emoji(new int[] { 0x1F468, 0x200D, 0x1F4BB }).ToString()+" Xamarin.Forms"
                    }
                },
                new Contact
                {
                    ContactID = 2,
                    Name = "Rita",
                    PhoneNumber = "+228999999",
                    ProfileImage = "Rita.jpg",
                    ChatPinned = true,
                    ChatMetaData = new LastChatMetaData{
                        LastChatMetaDataID = 2,
                        LastChatDatetime = "23:12",
                        MessageIsFromMe = true,
                        MessageContent = "It's time to go !"
                    }
                },
                new Contact
                {
                    ContactID = 3,
                    Name = "Sara",
                    PhoneNumber = "+228999999",
                    ProfileImage = "Sara.jpg",
                    ChatPinned = true,
                    ChatMetaData = new LastChatMetaData{
                        LastChatMetaDataID = 3,
                        LastChatDatetime = "23:00",
                        MessageIsFromMe = true,
                        MessageContent = new Emoji(0x2764).ToString()
                    }
                },
                new Contact
                {
                    ContactID = 4,
                    Name = "Riana",
                    PhoneNumber = "+228999999",
                    ProfileImage = "Riana.jpg",
                    ChatPinned = true,
                    ChatMetaData = new LastChatMetaData{
                        LastChatMetaDataID = 4,
                        LastChatDatetime = "12:12",
                        MessageIsFromMe = false,
                        MessageContent = "Are you sure ?"+new Emoji(0x1F914).ToString()
                    }
                },
                new Contact
                {
                    ContactID = 5,
                    Name = "Grace",
                    PhoneNumber = "+228999999",
                    ProfileImage = "Grace.jpg",
                    ChatPinned = false,
                    ChatMetaData = new LastChatMetaData{
                        LastChatMetaDataID = 5,
                        LastChatDatetime = "11:10",
                        MessageIsFromMe = false,
                        MessageContent = "Right ! " +new Emoji(0x1F44C).ToString()
                    }
                },
                new Contact
                {
                    ContactID = 6,
                    Name = "Alice",
                    PhoneNumber = "+228999999",
                    ProfileImage = "Alice.jpg",
                    ChatPinned = false,
                    ChatMetaData = new LastChatMetaData{
                        LastChatMetaDataID = 6,
                        LastChatDatetime = "10:02",
                        MessageIsFromMe = false,
                        MessageContent = "You say what, ... "+new Emoji(0x1F923).ToString()+new Emoji(0x1F923).ToString()+new Emoji(0x1F923).ToString()
                    }
                },
                new Contact
                {
                    ContactID = 7,
                    Name = "Valerie",
                    PhoneNumber = "+228999999",
                    ProfileImage = "Valerie.jpg",
                    ChatPinned = false,
                    ChatMetaData = new LastChatMetaData{
                        LastChatMetaDataID = 7,
                        LastChatDatetime = "10:00",
                        MessageIsFromMe = false,
                        MessageContent = "My husband is sick. "+new Emoji(0x1F62D).ToString()
                    }
                },
                new Contact
                {
                    ContactID = 8,
                    Name = "Sandrine",
                    PhoneNumber = "+228999999",
                    ProfileImage = "Sandrine.jpg",
                    ChatPinned = false,
                    ChatMetaData = new LastChatMetaData{
                        LastChatMetaDataID = 8,
                        LastChatDatetime = "09:50",
                        MessageIsFromMe = false,
                        MessageContent = new Emoji(0x1F6B4).ToString()
        }
                },
                new Contact
                {
                    ContactID = 9,
                    Name = "Centia",
                    PhoneNumber = "+228999999",
                    ProfileImage = "Centia.jpg",
                    ChatPinned = false,
                    ChatMetaData = new LastChatMetaData{
                        LastChatMetaDataID = 9,
                        LastChatDatetime = "08:45",
                        MessageIsFromMe = false,
                        MessageContent = new Emoji(0x1F6B4).ToString()
                    }
                },
                new Contact
                {
                    ContactID = 10,
                    Name = "Natalie",
                    PhoneNumber = "+228999999",
                    ProfileImage = "Natalie.jpg",
                    ChatPinned = false,
                    ChatMetaData = new LastChatMetaData{
                        LastChatMetaDataID = 8,
                        LastChatDatetime = "07:03",
                        MessageIsFromMe = true,
                        MessageContent = "Hello, how are you today ?"
                    }
                },
            };

            return contacts;
        }
    }
}
