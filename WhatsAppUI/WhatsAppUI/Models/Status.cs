namespace WhatsApp.Models
{
    /// <summary>
    /// WhatsApp Status class.
    /// </summary>
    public class Status
    {
        public long StutusID { get; set; }
        public Contact Contact { get; set; }
        public string Image { get; set; }
        public string Description { get; set; }
        public string PushDate { get; set; }
    }
}
