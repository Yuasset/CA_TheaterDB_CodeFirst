namespace CA_TheaterDB_CodeFirst.Entities
{
    internal class Session
    {
        public int ID { get; set; }
        public DateTime SessionTime { get; set; }
        //Mapping
        public List<Theater> Theater { get; set; }
    }
}
