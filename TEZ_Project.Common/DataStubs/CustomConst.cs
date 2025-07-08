namespace TEZ_Project.Common.Data
{
    public class CustomConst
    {
        public int Id { get; set; }
        public string NameInApp { get; set; }
        public string MaterialName { get; set; }
        public double Price { get; set; }
        public string MaterialNameFlight { get; set; }
        public string Code1 { get; set; }
        public string MaterialName1C { get; set; }
        public string Code2 { get; set; }
        public string OdVym1 { get; set; }
        public string OdVym2 { get; set; }

        // Default constructor
        public CustomConst()
        {
        }

        // Constructor with basic parameters
        public CustomConst(string nameInApp, string materialName, double price)
        {
            NameInApp = nameInApp;
            MaterialName = materialName;
            Price = price;
        }
    }
}
