using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaDeClases
{
    public interface ISerializacion
    {
        public bool Serializar(Object lista);
        public Object Deserializar();
    }
}
