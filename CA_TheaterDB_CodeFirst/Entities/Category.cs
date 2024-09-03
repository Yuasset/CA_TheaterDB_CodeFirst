namespace CA_TheaterDB_CodeFirst.Entities
{
    internal class Category
    {
        public int ID { get; set; }
        public string CategoryName { get; set; }
        //Mapping
        public MovieCategory MovieCategory { get; set; }
    }
}
