using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria.Shared.Models {
    public class Libro {
        public string Titulo { get; set; }
        public string Editorial { get; set; }
        public long ISBN { get; set; }
        public int Edicion { get; set; }
        public float Precio { get; set; }
        public string Imagen { get; set; }
    }
}