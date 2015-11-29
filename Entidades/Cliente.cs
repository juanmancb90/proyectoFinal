using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    class Cliente
    {
        //delegados
        public int ID_Cliente { get; set; }
        public int ID_Vendedor { get; set; }
        public int ID_Ciudad { get; set; }
        public int ID_Documento { get; set; }
        public string nombresApelldios { get; set; }
        public string NumeroDocumento { get; set; }
        public string Telefono { get; set; }
        public string Celular { get; set; }
        public string Email { get; set; }
        public string Direccion { get; set; }
    }
}
