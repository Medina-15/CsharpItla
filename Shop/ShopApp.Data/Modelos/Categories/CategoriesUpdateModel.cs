﻿

namespace ShopApp.Data.Modelos.Categories
{
    public class CategoriesUpdateModel: Update
    {
        public int categoryid { get; set; }
        public string categoryname { get; set; }
        public string description { get; set; }

    }
}