using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace tiendaBarrio.Models
{
    public class Cliente
    {

        public int ID { get; set; }
        public string LastName { get; set; }
        public string FirstMidName { get; set; }
        public DateTime CompraDate { get; set; }

        public virtual ICollection<Compra> Compras { get; set; }

    }
}