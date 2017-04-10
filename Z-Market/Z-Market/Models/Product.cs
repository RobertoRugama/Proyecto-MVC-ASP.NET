using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Z_Market.Models
{
    public class Product
    {
        [Key]
        public int ProductID { get; set; }

        [Display(Name="Descripcion")]
        public string Descripcion { get; set; }

        [Display(Name = "Precio")]
        public decimal Price { get; set; }

        [Display(Name = "Fecha de Compra")]
        public DateTime LastBuy { get; set; }

        [Display(Name = "Valores")]
        public float Stock { get; set; }

        [Display(Name = "Observacion")]
        public string Remarks { get; set; }

        public virtual ICollection<SupplierProduct> Supplierproducts { get; set; }
    }
}