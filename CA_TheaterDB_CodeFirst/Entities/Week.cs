namespace CA_TheaterDB_CodeFirst.Entities
{
    internal class Week
    {
        public int ID { get; set; }
        public string WeekName { get; set; }
        public DateTime WakeFirstDay { get; set; }
        public DateTime WakeLastDay { get; set; }
        //Mapping
        public List<Theater> Theater { get; set; }
    }
}
