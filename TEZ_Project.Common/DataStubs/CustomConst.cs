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

        // Constructor with 8 parameters as used in Consts2.cs
        public CustomConst(string nameInApp, double price, string materialName, string code1, string materialName1C, string code2, string odVym1, string odVym2)
        {
            NameInApp = nameInApp;
            Price = price;
            MaterialName = materialName;
            Code1 = code1;
            MaterialName1C = materialName1C;
            Code2 = code2;
            OdVym1 = odVym1;
            OdVym2 = odVym2;
        }

        // Constructor with 10 parameters as used in LoadConstsFromDb
        public CustomConst(int id, string materialName, double price, string materialNameFlight, string code1, string materialName1C, string code2, string odVym1, string odVym2, string nameInApp)
        {
            Id = id;
            MaterialName = materialName;
            Price = price;
            MaterialNameFlight = materialNameFlight;
            Code1 = code1;
            MaterialName1C = materialName1C;
            Code2 = code2;
            OdVym1 = odVym1;
            OdVym2 = odVym2;
            NameInApp = nameInApp;
        }

        // ToConst method stub
        public Const ToConst(string name)
        {
            return new Const
            {
                Id = this.Id,
                MaterialName = this.MaterialName,
                Price = this.Price,
                MaterialNameFlight = this.MaterialNameFlight,
                Code1 = this.Code1,
                MaterialName1C = this.MaterialName1C,
                Code2 = this.Code2,
                OdVym1 = this.OdVym1,
                OdVym2 = this.OdVym2,
                NameInApp = this.NameInApp
            };
        }
    }
}
