

using ShopApp.Data.Base;

namespace ShopApp.Data.Entidades
{
    public class Categories: AudiEntity
    {
        public int categoryid { get; set; }
        public string categoryname {  get; set; } //15 
        public string description { get; set; } //200 

    }
}
