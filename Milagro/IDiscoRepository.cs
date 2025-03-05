using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Milagro
{
    internal interface IDiscoRepository
    {
        void InsertarDisco(Disco disco);
        void ActualizarDisco(Disco disco);
        void EliminarDisco(int id);
        List<Disco> ObtenerDisco();
    }
}
