namespace CA_TheaterDB_CodeFirst.Entities
{
    internal class MovieCategory
    {
        public int MovieID { get; set; }
        public int CategoryID { get; set; }
        //Mapping
        public Movie Movie { get; set; }
        public Category Category { get; set; }
    }
}
