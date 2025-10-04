using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryWinForm.Models
{
    public class Movimientos
    {
        public int Id { get; set; }
        public int ProductoId { get; set; }
        public string Tipo { get; set; }   // Si es Entrada o Salida
        public int Cantidad { get; set; }  // tiene que ser mayor a 0
        public string Fecha { get; set; }
    }
}
