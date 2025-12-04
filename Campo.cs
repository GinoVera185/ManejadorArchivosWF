using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManejadorArchivosWF
{
    public class Campo
    {
        public string Nombre { get; set; }
        public string Tipo { get; set; } // "Cadena", "Entero", "Decimal", "Booleano"

        public Campo(string nombre, string tipo)
        {
            Nombre = nombre;
            Tipo = tipo;
        }
        public Type GetNetType()
        {
            return Tipo switch
            {
                "Cadena" => typeof(string),
                "Entero" => typeof(int),
                "Decimal" => typeof(decimal),
                "Booleano" => typeof(bool),
                _ => throw new InvalidOperationException("Tipo no soportado")
            };
        }
    }
}
