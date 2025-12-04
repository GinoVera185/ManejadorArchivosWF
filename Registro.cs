using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManejadorArchivosWF
{
    public class Registro
    {
        public int ID { get; set; }
        public Dictionary<string, object> Valores { get; set; } = new Dictionary<string, object>();

        public void SetValor(string nombreCampo, object valor)
        {
            Valores[nombreCampo] = valor;
        }

        public object GetValor(string nombreCampo)
        {
            return Valores.TryGetValue(nombreCampo, out var valor) ? valor : null;
        }
    }
}
