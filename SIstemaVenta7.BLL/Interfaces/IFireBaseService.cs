using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIstemaVenta7.BLL.Interfaces
{
    public interface IFireBaseService
    {
        Task<string> SubirStorage(Stream StreamArchivo, string CapertaDestino, String NombreArchivo);

        Task<bool> EliminarStorage(string CapertaDestino, String NombreArchivo);

    }
}
