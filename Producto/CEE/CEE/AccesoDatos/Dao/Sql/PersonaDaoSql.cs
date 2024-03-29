﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CEE.AccesoDatos.DBHelper;
using System.Data;
using CEE.Negocio.DTO;

namespace CEE.AccesoDatos.Dao.Sql
{
    class PersonaDaoSql : IPersonaDao
    {
        public PersonaDTO GetPersonaById(int idPersona)
        {
            string strSql = "SELECT P.persona_id, " +
                            "P.numero_documento, " +
                            "P.tipo_documento_id, " +
                            "TD.nombre_tipo_documento, " +
                            "P.apellido, " +
                            "P.nombre, " +
                            "P.legajo, " +
                            "P.universidad_id, " +
                            "U.nombre_universidad, " +
                            "P.carrera_id, " +
                            "C.nombre_carrera, " +
                            "P.telefono, " +
                            "P.mail, " +
                            "P.calle, " +
                            "P.numero_calle, " +
                            "P.piso, " +
                            "P.departamento, " +
                            "P.observaciones, " +
                            "P.fecha_alta, " +
                            "P.fecha_baja " +
                            "FROM PERSONA P " +
                            "LEFT JOIN TIPO_DOCUMENTO TD ON TD.tipo_documento_id = P.tipo_documento_id " +
                            "LEFT JOIN CARRERA C ON C.carrera_id = P.carrera_id " +
                            "LEFT JOIN UNIVERSIDAD U ON U.universidad_id = P.universidad_id " +
                            "WHERE P.persona_id = " + idPersona.ToString() + " " +
                            "AND P.fecha_baja IS NULL; ";

            return MappingPersona(DBHelperSql.GetDBHelper().ConsultaSQL(strSql).Rows[0]);
        }

        public IList<PersonaDTO> GetPersonaByFilters(Dictionary<string, object> parametros)
        {
            List<PersonaDTO> resultado = new List<PersonaDTO>();

            string strSql = "SELECT P.persona_id, " +
                            "P.numero_documento, " +
                            "P.tipo_documento_id, " +
                            "TD.nombre_tipo_documento, " +
                            "P.apellido, " +
                            "P.nombre, " +
                            "P.legajo, " +
                            "P.universidad_id, " +
                            "U.nombre_universidad, " +
                            "P.carrera_id, " +
                            "C.nombre_carrera, " +
                            "P.telefono, " +
                            "P.mail, " +
                            "P.calle, " +
                            "P.numero_calle, " +
                            "P.piso, " +
                            "P.departamento, " +
                            "P.observaciones, " +
                            "P.fecha_alta, " +
                            "P.fecha_baja " +
                            "FROM PERSONA P " +
                            "LEFT JOIN TIPO_DOCUMENTO TD ON TD.tipo_documento_id = P.tipo_documento_id " +
                            "LEFT JOIN CARRERA C ON C.carrera_id = P.carrera_id " +
                            "LEFT JOIN UNIVERSIDAD U ON U.universidad_id = P.universidad_id " +
                            "WHERE 1 = 1 ";

            if (parametros.ContainsKey("Legajo"))
                strSql += " AND (P.legajo = @Legajo) ";
            if (parametros.ContainsKey("NumeroDocumento"))
                strSql += " AND (P.numero_documento = @NumeroDocumento) ";
            if (parametros.ContainsKey("IdTipoDocumento"))
                strSql += "  AND (P.tipo_documento_id = @IdTipoDocumento) ";
            if (parametros.ContainsKey("TipoDocumento"))
                strSql += "  AND (TD.nombre_tipo_documento = @TipoDocumento) ";
            if (parametros.ContainsKey("Apellido"))
                strSql += " AND (P.apellido LIKE '%' + @Apellido + '%') ";
            if (parametros.ContainsKey("Nombre"))
                strSql += " AND (P.nombre LIKE '%' + @Nombre + '%') ";
            if (!parametros.ContainsKey("FechaBajaNotNull"))
                strSql += " AND P.fecha_baja IS NULL ";

            DataTable dt = DBHelperSql.GetDBHelper().ConsultaSQLConParametros(strSql, parametros);

            foreach (DataRow row in dt.Rows)
            {
                resultado.Add(MappingPersona(row));
            }

            return resultado;
        }

        private PersonaDTO MappingPersona(DataRow row)
        {
            PersonaDTO oPersona = new PersonaDTO();

            oPersona.IdPersona = Int32.Parse(row["persona_id"].ToString());
            oPersona.Apellido = row["apellido"].ToString();
            oPersona.Nombre = row["nombre"].ToString();
            oPersona.NombreTipoDocumento = row["nombre_tipo_documento"].ToString();
            oPersona.IdTipoDocumento = Int32.Parse(row["tipo_documento_id"].ToString());
            oPersona.NumeroDocumento = Int32.Parse(row["numero_documento"].ToString());

            if (!DBNull.Value.Equals(row["legajo"]))
                oPersona.Legajo = Int32.Parse(row["legajo"].ToString());
            if (!DBNull.Value.Equals(row["universidad_id"]))
                oPersona.IdUniversidad = Int32.Parse(row["universidad_id"].ToString());
            if (!DBNull.Value.Equals(row["nombre_universidad"]))
                oPersona.NombreUniversidad = row["nombre_universidad"].ToString();
            if (!DBNull.Value.Equals(row["carrera_id"]))
                oPersona.IdCarrera = Int32.Parse(row["carrera_id"].ToString());
            if (!DBNull.Value.Equals(row["nombre_carrera"]))
                oPersona.NombreCarrera = row["nombre_carrera"].ToString();

            if (!DBNull.Value.Equals(row["mail"]))
                oPersona.Mail = row["mail"].ToString();
            if (!DBNull.Value.Equals(row["telefono"]))
                oPersona.Telefono = row["telefono"].ToString();

            if (!DBNull.Value.Equals(row["calle"]))
                oPersona.Calle = row["calle"].ToString();
            if (!DBNull.Value.Equals(row["numero_calle"]))
                oPersona.NumeroCalle = Int32.Parse(row["numero_calle"].ToString());
            if (!DBNull.Value.Equals(row["piso"]))
                oPersona.Piso = Int32.Parse(row["piso"].ToString());
            if (!DBNull.Value.Equals(row["departamento"]))
                oPersona.Departamento = row["departamento"].ToString();
            if (!DBNull.Value.Equals(row["observaciones"]))
                oPersona.Observaciones = row["observaciones"].ToString();

            if (!DBNull.Value.Equals(row["fecha_alta"]))
                oPersona.FechaAlta = DateTime.Parse(row["fecha_alta"].ToString());
            if (!DBNull.Value.Equals(row["fecha_baja"]))
                oPersona.FechaBaja = DateTime.Parse(row["fecha_baja"].ToString());

            return oPersona;
        }

        public bool DeletePersonaById(int idPersona)
        {
            string strSql = "UPDATE PERSONA " +
                            "SET fecha_baja = GETDATE() " +
                            "WHERE persona_id =  " + idPersona.ToString();

            DBHelperSql.GetDBHelper().EjecutarSQL(strSql);
            return true;
        }

        public bool InsertPersona(PersonaDTO oPersona)
        {
            string strSql = "INSERT INTO PERSONA(numero_documento, tipo_documento_id, apellido, nombre, ";
            if (oPersona.Legajo > 0)
                strSql += "legajo, ";
            if (oPersona.IdUniversidad > 0)
                strSql += "universidad_id, ";
            if (oPersona.IdCarrera > 0)
                strSql += "carrera_id, ";


            strSql += "telefono, mail, calle, numero_calle, piso, departamento, observaciones, fecha_alta) " +
                            "VALUES(" +
                            "'" + oPersona.NumeroDocumento.ToString()   + "', " +
                            "'" + oPersona.IdTipoDocumento.ToString()   + "', " +
                            "'" + oPersona.Apellido.ToString()          + "', " +
                            "'" + oPersona.Nombre.ToString()            + "', " ;


            if (oPersona.Legajo > 0)
                strSql += "'" + oPersona.Legajo.ToString() + "', ";
            if (oPersona.IdUniversidad > 0)
                strSql += "'" + oPersona.IdUniversidad.ToString() + "', ";
            if (oPersona.IdCarrera > 0)
                strSql += "'" + oPersona.IdCarrera.ToString() + "', ";


            strSql +=       "'" + oPersona.IdUniversidad.ToString()     + "', " +
                            "'" + oPersona.IdCarrera.ToString()         + "', " +
                            "'" + oPersona.Telefono.ToString()          + "', " +
                            "'" + oPersona.Mail.ToString()              + "', " +
                            "'" + oPersona.Calle.ToString()             + "', " +
                            "'" + oPersona.NumeroCalle.ToString()       + "', " +
                            "'" + oPersona.Piso.ToString()              + "', " +
                            "'" + oPersona.Departamento.ToString()      + "', " +
                            "'" + oPersona.Observaciones.ToString()     + "', " +
                            "GETDATE() )";
            DBHelperSql.GetDBHelper().EjecutarSQL(strSql);
            return true; 
        }

        public bool UpdatePersonaById(PersonaDTO oPersona)
        {
            string strSql = "UPDATE PERSONA " +
                            "SET numero_documento = '" + oPersona.NumeroDocumento.ToString()    + "', " +
                            "    tipo_documento_id = '" + oPersona.IdTipoDocumento.ToString()   + "', " +
                            "    apellido = '" + oPersona.Apellido.ToString()                   + "', " +
                            "    nombre = '" + oPersona.Nombre.ToString()                       + "', ";


            if (oPersona.Legajo > 0)
                strSql += "    legajo = '" + oPersona.Legajo.ToString()                       + "', " ;
            else
                strSql += "    legajo = NULL, ";
            if (oPersona.IdUniversidad > 0)
                strSql += "    universidad_id = '" + oPersona.IdUniversidad.ToString()        + "', ";
            else
                strSql += "    universidad_id = NULL, ";
            if (oPersona.IdCarrera > 0)
                strSql += "    carrera_id = '" + oPersona.IdCarrera.ToString() + "', ";
            else
                strSql += "    carrera_id = NULL, ";


            strSql +=       "    telefono = '" + oPersona.Telefono.ToString()                   + "', " +
                            "    mail = '" + oPersona.Mail.ToString()                           + "', " +
                            "    calle = '" + oPersona.Calle.ToString()                         + "', " +
                            "    numero_calle = '" + oPersona.NumeroCalle.ToString()            + "', " +
                            "    piso = '" + oPersona.Piso.ToString()                           + "', " +
                            "    departamento = '" + oPersona.Departamento.ToString()           + "', " +
                            "    observaciones = '" + oPersona.Observaciones.ToString()         + "' " +
                            "WHERE persona_id = " + oPersona.IdPersona.ToString();

            DBHelperSql.GetDBHelper().EjecutarSQL(strSql);
            return true;
        }
    }
}
