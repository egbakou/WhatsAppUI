namespace WhatsApp.Models
{
    /// <summary>
    /// WhatsApp call class.
    /// </summary>
    public class Call
    {
        public int CallID { get; set; }
        public Contact Contact { get; set; }
        public string CallDate { get; set; }
        public bool OutCall { get; set; }
        public bool InCall { get; set; }
        public bool IsMissedCall { get; set; }
    }
}
