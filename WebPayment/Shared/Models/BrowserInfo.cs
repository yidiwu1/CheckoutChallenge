namespace WebPayment.Shared.Models
{
    public class BrowserInfo
    {
        public string AcceptHeader { get; set; }
        public int ColorDepth { get; set; }
        public string Language { get; set; }
        public bool JavaEnabled { get; set; }
        public int ScreenHeight { get; set; }
        public int ScreenWidth { get; set; }
        public string UserAgent { get; set; }
        public int TimeZoneOffset { get; set; }
    }
}

