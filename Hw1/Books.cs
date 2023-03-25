namespace Hw1
{
    public class Books
    {
        public int Id { get; set; }
        public string Name { get; set; }    
        //fk author
        public string Author { get; set; }
        public string Publisher { get; set; }
        public DateTime PublishedDate { get; set; }
    }
}


