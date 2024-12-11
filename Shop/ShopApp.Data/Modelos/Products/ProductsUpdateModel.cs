

namespace ShopApp.Data.Modelos.Products
{
    public class ProductsUpdateModel: Update
    {
        public int productid { get; set; }
        public string productname { get; set; } //40

        public int supplierid { get; set; }
        public int categoryid { get; set; }

        public int unitprice { get; set; }
        public bool discontinued { get; set; }
    }
}
