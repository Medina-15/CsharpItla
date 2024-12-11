
namespace ShopApp.Data.Modelos.Customers
{
    public class CustomerCreateModel: Create
    {
        public int custid { get; set; }
        public string companyname { get; set; } //40
        public string contactname { get; set; } //30
        public string contacttitle { get; set; } //30
        public string address { get; set; } //60
        public string emali { get; set; } //50
        public string city { get; set; } // 15
        public string? region { get; set; } //15
        public string postalcode { get; set; } //10
        public string country { get; set; } //15
        public string phone { get; set; } //24
        public string? fax { get; set; } //24
    }
}
