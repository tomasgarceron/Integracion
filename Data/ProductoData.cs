using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Models.Entidades;

namespace Data
{
    public static class ProductoData
    {
        public static List<Producto> listaProducto = new List<Producto>{
            new Producto { Id=1 , NombreProducto= "Producto1", Categoria= "Computadoras", Marca= "HP", Precio=2000, Costo=1000},
            new Producto { Id=2 , NombreProducto= "Producto2", Categoria= "Computadoras", Marca= "Windows", Precio=2200, Costo=1200},
            new Producto { Id=3 , NombreProducto= "Producto3", Categoria= "Computadoras", Marca= "Lg", Precio=2350, Costo=1300},
            new Producto { Id=4 , NombreProducto= "Producto4", Categoria= "Computadoras", Marca= "Samsung", Precio=2000, Costo=1400},
            new Producto { Id=5 , NombreProducto= "Producto5", Categoria= "Computadoras", Marca= "Asus", Precio=2450, Costo=1500},
        };
    }
}