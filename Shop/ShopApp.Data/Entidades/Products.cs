
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using ShopApp.Data.Base;

namespace ShopApp.Data.Entidades
{
    public class Products : AudiEntity
    {
        public int productid { get; set; }
        public string productname { get; set; } //40

        public int supplierid { get; set; }
        public int categoryid { get; set; } 

        public int unitprice { get; set; }
        public bool  discontinued { get; set; }
            

    }
}
