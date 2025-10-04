using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryWinForm.Models
{
    public class Productos
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string CategoriaNombre { get; set; }
        public int IdCategoria { get; set; }
        public decimal Precio { get; set; }
        public int Stock { get; set; }
    }
}
