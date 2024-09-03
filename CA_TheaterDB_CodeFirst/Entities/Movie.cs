namespace CA_TheaterDB_CodeFirst.Entities
{
    internal class Movie
    {
        public int ID { get; set; }
        public string MovieName { get; set; }
        public string Description { get; set; }
        public int Duration { get; set; }
        //Mapping
        public MovieCategory MovieCategory { get; set; }
        //Mapping
        public List<Theater> Theater { get; set; }

    }
}
