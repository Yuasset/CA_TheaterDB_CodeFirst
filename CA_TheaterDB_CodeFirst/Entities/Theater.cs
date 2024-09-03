namespace CA_TheaterDB_CodeFirst.Entities
{
    internal class Theater
    {
        public int ID { get; set; }
        public int MovieID { get; set; }
        //Mapping
        public Movie Movie { get; set; }
        public int SessionID { get; set; }
        //Mapping
        public Session Session { get; set; }
        public int SaloonID { get; set; }
        //Mapping
        public Saloon Saloon { get; set; }
        public int WeekID { get; set; }
        //Mapping
        public Week Week { get; set; }
    }
}
