using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SegundoProyectoCompleto.Logica
{
    public class LogicaCargos
    {
        // agregamos todos los campos que tenga la tabla Cargo en la Base de Datos
        public int Id_cargo { get; set; }
        public string Cargo { get; set; }
        public double SueldoCargo { get; set; }
    }
}
