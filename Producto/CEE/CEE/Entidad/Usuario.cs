using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CEE.Entidad
{
    class Usuario
    {
        public int IdUsuario { get; set; }
        public string NombreUsuario { get; set; }

        private string pass;

        public string Pass
        {
            get { return pass; }
            set { pass = GetMd5Hash(value); }
        }

        // Desde aca las Propertys son Nullable
        public IList<Perfil> Perfiles { get; set; }




        // ############################################################################### Metodos

        /// <summary>
        /// Metodo para Hashear un string y obtener el string con el hash segun el algoritmo MD5
        /// esto para las passwords
        /// </summary>
        /// <param name="input">la string a Hashear</param>
        /// <returns>el hash en md5 de la string input</returns>
        private string GetMd5Hash(string input)
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
