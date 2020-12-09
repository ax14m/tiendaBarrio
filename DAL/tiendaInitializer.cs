using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using tiendaBarrio.Models;

namespace tiendaBarrio.DAL
{
    public class tiendaInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<Context>
    {
        protected override void Seed(Context context)
        {
            var Clientes = new List<Cliente>
            {
            new Cliente{FirstMidName="Alexander",LastName="Martinez",CompraDate=DateTime.Parse("2005-09-01")},
            new Cliente{FirstMidName="Carolina",LastName="Montoya",CompraDate=DateTime.Parse("2002-09-01")},
            new Cliente{FirstMidName="Isabel",LastName="Alvarez",CompraDate=DateTime.Parse("2003-09-01")},
            new Cliente{FirstMidName="Maribel",LastName="Gonzalez",CompraDate=DateTime.Parse("2002-09-01")},
            new Cliente{FirstMidName="Melissa",LastName="Martinez",CompraDate=DateTime.Parse("2002-09-01")},
            new Cliente{FirstMidName="Vivana",LastName="Sanchez",CompraDate=DateTime.Parse("2001-09-01")},
            new Cliente{FirstMidName="Diana",LastName="Cadavid",CompraDate=DateTime.Parse("2003-09-01")},
            new Cliente{FirstMidName="Roxy",LastName="medina",CompraDate=DateTime.Parse("2005-09-01")}
            };

            Clientes.ForEach(s => context.Clientes.Add(s));
            context.SaveChanges();
            var Productos = new List<Producto>
            {
            new Producto{ProductoID=1050,Nomp="Chunky",Descripcion=3,},
            new Producto{ProductoID=4022,Nomp="Dogurmet",Descripcion=3,},
            new Producto{ProductoID=4041,Nomp="Agility",Descripcion=3,},
            new Producto{ProductoID=1045,Nomp="DogChow",Descripcion=4,},
            new Producto{ProductoID=3141,Nomp="Mirringo",Descripcion=4,},
            new Producto{ProductoID=2021,Nomp="MaxCat",Descripcion=3,},
            new Producto{ProductoID=2042,Nomp="Donkat",Descripcion=4,}
            };
            Productos.ForEach(s => context.Productos.Add(s));
            context.SaveChanges();
            var Compras = new List<Compra>
            {
            new Compra{ClienteID=1,ProductoID=1050,Grade=Grade.A},
            new Compra{ClienteID=1,ProductoID=4022,Grade=Grade.C},
            new Compra{ClienteID=1,ProductoID=4041,Grade=Grade.B},
            new Compra{ClienteID=2,ProductoID=1045,Grade=Grade.B},
            new Compra{ClienteID=2,ProductoID=3141,Grade=Grade.F},
            new Compra{ClienteID=2,ProductoID=2021,Grade=Grade.F},
            new Compra{ClienteID=3,ProductoID=1050},
            new Compra{ClienteID=4,ProductoID=1050,},
            new Compra{ClienteID=4,ProductoID=4022,Grade=Grade.F},
            new Compra{ClienteID=5,ProductoID=4041,Grade=Grade.C},
            new Compra{ClienteID=6,ProductoID=1045},
            new Compra{ClienteID=7,ProductoID=3141,Grade=Grade.A},
            };
            Compras.ForEach(s => context.Compras.Add(s));
            context.SaveChanges();
        }
    }
}
