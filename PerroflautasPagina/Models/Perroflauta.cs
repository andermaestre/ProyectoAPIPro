using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PerroflautasPagina.Models
{
    
    public class Perroflauta
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string OrientacionIdeologica { get; set; }
        public string Direccion { get; set; }
        public string Posesiones { get; set; }
        public string GritoComun { get; set; }
        public string GritoAparea { get; set; }
    }
}
