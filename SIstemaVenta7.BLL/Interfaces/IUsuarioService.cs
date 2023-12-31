﻿using SistemaVenta7.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIstemaVenta7.BLL.Interfaces
{
    public interface IUsuarioService
    {
        Task<List<Usuario>> Lista();
        Task<Usuario> Crear(Usuario entidad, Stream Foto = null, string nombreFoto = "", string UrlPlantillaCorreo = "");
        Task<Usuario> Editar(Usuario entidad, Stream Foto = null, string nombreFoto = "");
        Task<bool> Eliminar(int idUsuario);
        Task<Usuario> ObtenerPorCredenciales(string correo, string clave);
        Task<Usuario> ObtenerPorId(int IdUsuario);
        Task<bool> GuardarPerfil(Usuario entidad);
        Task<bool> CambiarClave(int IdUsuario, string ClaveActual, string ClaveNueva);
        Task<bool> RestablecerClave(string correo, string UrlPlantillaCorreo);
    }
}
