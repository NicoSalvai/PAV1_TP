using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CEE.AccesoDatos.Dao.Sql;
using CEE.AccesoDatos.Dao;

using CEE.Negocio.DTO;

using System.Security.Cryptography;

namespace CEE.Negocio
{
    public class UsuarioService
    {
        private IUsuarioDao oUsuarioDao;
        public int IdUsuarioLogeado { get; set; }

        public UsuarioService()
        {
            oUsuarioDao = new UsuarioDaoSql();
        }

        public UsuarioDTO GetUsuarioById(int idUsuario)
        {
            return oUsuarioDao.GetUsuarioById(idUsuario);
        }

        public IList<UsuarioDTO> GetUsuarioByFilters(Dictionary<string, object> parametros)
        {
            return oUsuarioDao.GetUsuarioByFilters(parametros);
        }

        public bool LoginUsuario(string nombreUsuario, string passwordUsuario)
        {
            Dictionary<string, object> parametros = new Dictionary<string, object>();
            parametros.Add("NombreUsuario", nombreUsuario);

            IList<UsuarioDTO> lista = GetUsuarioByFilters(parametros);

            if (lista.Count == 1)
            {
                if (lista.First().Pass.Equals(GetMd5Hash(passwordUsuario)))
                {
                    IdUsuarioLogeado = lista.First().IdUsuario;
                    return true;
                }
                throw new Exception("Password Incorrecta");
            }
            throw new Exception("Usuario Inexistente");
        }







        public string GetMd5Hash(string input)
        {
            StringBuilder sbOutput = new StringBuilder(); // StringBuilder Auxiliar para rearmar el hash de la calve

            var md5 = new MD5CryptoServiceProvider();   // Clase que computa el Hash
            byte[] data = md5.ComputeHash(Encoding.UTF8.GetBytes(input));

            for (int i = 0; i < data.Length; i++)
            {
                sbOutput.Append(data[i].ToString("x2"));    // Armo el hash como un string
            }

            return sbOutput.ToString();
        }
    }
}
