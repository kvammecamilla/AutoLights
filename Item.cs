namespace Test2.Models
{
    public class Item
    {
        public string Id { get; set; }
        public string Month { get; set; }
        public double Monthly_power { get; set; }
        public double Monthly_cost { get; set; }
        public double RatingLight { get; set; }
        public double DimLight { get; set; }
        public int NrLight { get; set; }
        public int NrPeople { get; set; }
        public double Distance { get; set; }
        public double Speed { get; set; }
        public int NrLight100 { get; internal set; }
    }
}