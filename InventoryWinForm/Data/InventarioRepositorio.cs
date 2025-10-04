using InventoryWinForm.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace InventoryWinForm.Data
{
    public class InventarioRepositorio
    {
        public List<Categoria> Categories = new List<Categoria>();
        public List<Productos> Products = new List<Productos>();
        public List<Movimientos> Movements = new List<Movimientos>();

        private int categoriaContador = 1;
        private int productoContador = 1;
        private int movimientoContador = 1;

        public void AgregarCategoria(string nombre)
        {
            Categoria c = new Categoria();
            c.Id = categoriaContador++;
            c.Nombre = nombre;
            Categories.Add(c);
        }

        public bool EliminarCategoria(int id)
        {
            foreach (Productos p in Products)
            {

                if (p.IdCategoria == id)
                {
                    return false;
                }
            }

            for (int i = 0; i < Categories.Count; i++)
            {
                if (Categories[i].Id == id)
                {
                    Categories.RemoveAt(i);
                    return true;
                }
            }
            return false;


        }

        public bool AgregarProductos(string nombre, int categoriaId, decimal precio, int stock)
        {
            if (categoriaId == 0 || precio <= 0 || stock < 0)
            {
                return false;
            }

            Productos p = new Productos();
            p.Id = productoContador++;
            p.Nombre = nombre;
            p.IdCategoria = categoriaId;
            p.Precio = precio;
            p.Stock = stock;
            Products.Add(p);
            return true;

        }
        public void EliminarProducto(int id)
        {
            for (int i = 0; i < Products.Count; i++)
            {
                if (Products[i].Id == id)
                {
                    Products.RemoveAt(i);
                    break;
                }
            }
        }

        public bool AgregarMovimiento(int productoId, string tipo, int cantidad)
        {
            Productos producto = null;

            foreach (Productos p in Products)
            {
                if (p.Id == productoId)
                {
                    producto = p;
                    break;



                }


            }
            if (producto == null) return false;

            if (tipo == "Salida" && producto.Stock < cantidad)
            {
                return false; // No hay suficiente stock
            }

            Movimientos m = new Movimientos();
            m.Id = movimientoContador++;
            m.ProductoId = productoId;
            m.Tipo = tipo;
            m.Cantidad = cantidad;
            m.Fecha = DateTime.Now.ToString("dd/MM/yyyy HH:mm");
            Movements.Add(m);

            if (tipo == "Entrada")
            {
                producto.Stock += cantidad;
            }
            else
            {
                producto.Stock -= cantidad;
            }

            return true;
        }

        public int TotalProductos()
        {
            return Products.Count;
        }

        public int TotalCategorias()
        {
            return Categories.Count;
        }

        public decimal ValorDelInventario()
        {
            decimal total = 0;
            foreach (Productos p in Products)
            {
                total += p.Precio * p.Stock;
            }
            return total;
        }

        public Productos GetTopStockProduct()
        {
            if (Products.Count == 0) return null;

            Productos top = Products[0];
            foreach (Productos p in Products)
            {
                if (p.Stock > top.Stock)
                {
                    top = p;
                }
            }
            return top;
        }
    }
}