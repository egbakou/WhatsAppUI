namespace WhatsApp.Models
{
    /// <summary>
    /// The user of the current WhatsApp UI application.
    /// </summary>
    public class Me
    {
        public long MeID { get; set; }
        public string PhoneNumber { get; set; }
        public string Name { get; set; }
        public string ProfileImage { get; set; }
        public  virtual Status Status { get; set; }
    }
}
