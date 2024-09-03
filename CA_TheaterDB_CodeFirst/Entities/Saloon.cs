namespace CA_TheaterDB_CodeFirst.Entities
{
    internal class Saloon
    {
        public int ID { get; set; }
        public string SaloonName { get; set; }
        public int Capacity { get; set; }
        //Mapping
        public List<Theater> Theater { get; set; }
    }
}
