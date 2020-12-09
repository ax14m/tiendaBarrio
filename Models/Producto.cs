using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;


namespace tiendaBarrio.Models
{
    public class Producto
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ProductoID { get; set; }
        public string Nomp { get; set; }
        public int Descripcion { get; set; }

        public virtual ICollection<Compra> Compras { get; set; }


    }
}