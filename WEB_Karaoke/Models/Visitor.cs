namespace WEB_Karaoke.Models
{
    public class Visitor
    {
        public int Id { get; set; }
        public string UserName { get; set; }

        public enum Status { Gold, Silver }
        public Status MyStatus { get; set; }
        public List<string> SongList = new List<string>() ;
        public string ToString
        {
            get
            {
                return $"id- {Id} Name-{UserName}  MyStatus-{MyStatus}";
            }
        }

    }
}
 