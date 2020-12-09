using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace tiendaBarrio.Models
{
    
    

        public enum Grade
        {
            A, B, C, D, F
        }

        public class Compra
        {
            public int CompraID { get; set; }
            public int ProductoID { get; set; }
            public int ClienteID { get; set; }
            public Grade? Grade { get; set; }

            public virtual Producto Producto { get; set; }
            public virtual Cliente Cliente { get; set; }
        }


    }
