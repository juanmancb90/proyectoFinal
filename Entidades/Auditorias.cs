using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Auditorias
    {
        public int ID_Auditoria { get; set; }
        public System.DateTime TiempoEvento { get; set; }
        public string NombreUsuario { get; set; }
        public string NombreBaseDatos { get; set; }
        public string NombreObjeto { get; set; }
        public string TipoObjeto { get; set; }
        public string ComandoDML { get; set; }
    }
}
