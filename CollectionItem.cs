using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtCrafter.MasterofCollections
{
    public class CollectionItem
    {
        public int? ID { get; set; }
        public string Name { get; set; }
        public DateTime? PurchaseDate { get; set; }
        public decimal? PurchasePrice { get; set; }
        public string PurchaseLocation { get; set; }
        public DateTime? SaleDate { get; set; }
        public decimal? SalePrice { get; set; }
        public string SaleLocation { get; set; }
        public string FrontImageFilePath { get; set; }
        public string BackImageFilePath { get; set; }
        public string Description { get; set; }
        public int? CategoryID { get; set; }
    }



}
