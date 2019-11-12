using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CEE.AccesoDatos.DBHelper;
using System.Data;
using CEE.Negocio.DTO;

namespace CEE.AccesoDatos.Dao.Sql
{
    class PrestamoDaoSql : IPrestamoDao
    {
        public PrestamoDTO GetPrestamoyId(int idPrestamo)
        {
            string strSql = "SELECT P.prestamo_id, " +
                            "P.persona_id, " +
                            "PER.numero_documento, " +
                            "PER.tipo_documento_id, " +
                            "TD.nombre_tipo_documento, " +
                            "PER.apellido, " +
                            "PER.nombre, " +
                            "PER.legajo, " +
                            "P.estado_id, " +
                            "EST.nombre_estado, " +
                            "P.fecha_desde, " +
                            "P.fecha_hasta_estimada, " +
                            "P.fecha_hasta, " +
                            "P.fecha_cancelacion " +
                            "FROM PRESTAMO P " +
                            "JOIN PERSONA PER ON PER.persona_id = P.persona_id " +
                            "JOIN TIPO_DOCUMENTO TD ON TD.tipo_documento_id = PER.tipo_documento_id " +
                            "JOIN ESTADO EST ON EST.estado_id = P.estado_id " +
                            "WHERE P.prestamo_id = " + idPrestamo.ToString();

            string strSql2 = "SELECT DP.detalle_prestamo_id, " +
                            "DP.prestamo_id, " +
                            "E.equipo_id, " +
                            "E.codigo, " +
                            "E.nombre, " +
                            "TE.tipo_equipo_id, " +
                            "TE.tipo_equipo, " +
                            "DP.fecha_devuelto " +
                            "FROM DETALLE_PRESTAMO DP " +
                            "JOIN EQUIPO E ON E.equipo_id = DP.equipo_id " +
                            "JOIN TIPO_EQUIPO TE ON TE.tipo_equipo_id = E.tipo_equipo_id " +
                            "WHERE DP.prestamo_id = " + idPrestamo.ToString();

            return MappingPrestamo(DBHelperSql.GetDBHelper().ConsultaSQL(strSql).Rows[0], DBHelperSql.GetDBHelper().ConsultaSQL(strSql2));
        }

        public IList<PrestamoDTO> GetPrestamoByFilters(Dictionary<string, object> parametros)
        {
            List<PrestamoDTO> resultado = new List<PrestamoDTO>();

            string strSql = "SELECT P.prestamo_id, " +
                            "P.persona_id, " +
                            "PER.numero_documento, " +
                            "PER.tipo_documento_id, " +
                            "TD.nombre_tipo_documento, " +
                            "PER.apellido, " +
                            "PER.nombre, " +
                            "PER.legajo, " +
                            "P.estado_id, " +
                            "EST.nombre_estado, " +
                            "P.fecha_desde, " +
                            "P.fecha_hasta_estimada, " +
                            "P.fecha_hasta, " +
                            "P.fecha_cancelacion " +
                            "FROM PRESTAMO P " +
                            "JOIN PERSONA PER ON PER.persona_id = P.persona_id " +
                            "JOIN TIPO_DOCUMENTO TD ON TD.tipo_documento_id = PER.tipo_documento_id " +
                            "JOIN ESTADO EST ON EST.estado_id = P.estado_id " +
                            "WHERE 1 = 1 ";

            if (parametros.ContainsKey("IdPersona"))
                strSql += " AND (P.persona_id = @IdPersona) ";
            if (parametros.ContainsKey("TipoDocumentoId"))
                strSql += " AND (PER.tipo_documento_id = @TipoDocumentoId) ";
            if (parametros.ContainsKey("TipoDocumento"))
                strSql += " AND TD.nombre_tipo_documento = @TipoDocumento) ";
            if (parametros.ContainsKey("NumeroDocumento"))
                strSql += " AND (PER.numero_documento = @NumeroDocumento) ";
            if (parametros.ContainsKey("Nombre"))
                strSql += " AND (PER.nombre = @Nombre) ";
            if (parametros.ContainsKey("Apellido"))
                strSql += " AND (PER.apellido = @Apellido) ";
            if (parametros.ContainsKey("Legajo"))
                strSql += " AND (PER.legajo = @Legajo) ";
            if (parametros.ContainsKey("IdEstado"))
                strSql += " AND (P.estado_id = @IdEstado) ";
            if (parametros.ContainsKey("NombreEstado"))
                strSql += " AND (EST.nombre_estado = @NombreEstado) ";
            if (parametros.ContainsKey("FechaDesde"))
                strSql += " AND (P.fecha_desde = @FechaDesde) ";
            if (parametros.ContainsKey("FechaHastaEstimada"))
                strSql += " AND (P.fecha_hasta_estimada = @FechaHastaEstimada) ";
            if (parametros.ContainsKey("FechaHasta"))
                strSql += " AND (P.fecha_hasta = @FechaHasta) ";
            if (parametros.ContainsKey("FechaCancelacion"))
                strSql += " AND (P.fecha_cancelacion = @FechaCancelacion) ";
            if (parametros.ContainsKey("FechaHastaNull"))
                strSql += " AND (P.fecha_hasta IS NULL) ";
            if (parametros.ContainsKey("FechaCancelacionNull"))
                strSql += " AND (P.fecha_cancelacion IS NULL) ";

            /*  AND (E.codigo LIKE '%' + @Codigo + '%')   */

            DataTable dt = DBHelperSql.GetDBHelper().ConsultaSQLConParametros(strSql, parametros);

            foreach (DataRow row in dt.Rows)
            {
                resultado.Add(MappingPrestamo(row));
            }

            return resultado;
        }

        private PrestamoDTO MappingPrestamo(DataRow row)
        {
            PrestamoDTO oPrestamo = new PrestamoDTO();

            oPrestamo.IdPrestamo = Int32.Parse(row["prestamo_id"].ToString());
            oPrestamo.IdPersona = Int32.Parse(row["persona_id"].ToString());
            oPrestamo.NumeroDocumentoPersona = Int32.Parse(row["numero_documento"].ToString());
            oPrestamo.IdTipoDocumentoPersona = Int32.Parse(row["tipo_documento_id"].ToString());
            oPrestamo.NombreTipoDocumentoPersona = row["nombre_tipo_documento"].ToString();
            oPrestamo.ApellidoPersona = row["apellido"].ToString();
            oPrestamo.NombrePersona = row["nombre"].ToString();

            if(!DBNull.Value.Equals(row["legajo"]))
                oPrestamo.LegajoPersona = Int32.Parse(row["legajo"].ToString());

            oPrestamo.IdEstado = Int32.Parse(row["estado_id"].ToString());
            oPrestamo.NombreEstado = row["nombre_estado"].ToString();

            oPrestamo.FechaDesde = DateTime.Parse(row["fecha_desde"].ToString());
            oPrestamo.FechaHastaEstimada = DateTime.Parse(row["fecha_hasta_estimada"].ToString());

            if (!DBNull.Value.Equals(row["fecha_hasta"]))
                oPrestamo.FechaHasta = DateTime.Parse(row["fecha_hasta"].ToString());
            if (!DBNull.Value.Equals(row["fecha_cancelacion"]))
                oPrestamo.FechaCancelacion = DateTime.Parse(row["fecha_cancelacion"].ToString());

            return oPrestamo;
        }

        private PrestamoDTO MappingPrestamo(DataRow rowPrestamo, DataTable tableDetalles)
        {
            PrestamoDTO oPrestamo = MappingPrestamo(rowPrestamo);

            oPrestamo.Detalles = new List<DetallePrestamoDTO>();
            foreach (DataRow row in tableDetalles.Rows)
            {
                oPrestamo.Detalles.Add(MappingDetallePrestamo(row));
            }

            return oPrestamo;
        }

        private DetallePrestamoDTO MappingDetallePrestamo(DataRow row)
        {
            DetallePrestamoDTO oDetallePrestamo = new DetallePrestamoDTO();

            oDetallePrestamo.IdDetallePrestamo = Int32.Parse(row["detalle_prestamo_id"].ToString());
            oDetallePrestamo.IdPrestamo = Int32.Parse(row["prestamo_id"].ToString());
            oDetallePrestamo.IdEquipo = Int32.Parse(row["equipo_id"].ToString());
            oDetallePrestamo.CodigoEquipo = row["codigo"].ToString();
            oDetallePrestamo.NombreEquipo = row["nombre"].ToString();
            oDetallePrestamo.IdTipoEquipo = Int32.Parse(row["tipo_equipo_id"].ToString());
            oDetallePrestamo.NombreTipoEquipo = row["tipo_equipo"].ToString();

            oDetallePrestamo.Devuelto = false;
            if (!DBNull.Value.Equals(row["fecha_devuelto"]))
            {
                oDetallePrestamo.FechaDevuelto = DateTime.Parse(row["fecha_devuelto"].ToString());
                oDetallePrestamo.Devuelto = true;
            }

            return oDetallePrestamo;
        }

        public bool DeletePrestamoById(int idPrestamo)
        {
            throw new NotImplementedException();
        }

        public bool InsertPrestamo(PrestamoDTO oPrestamo)
        {
            Dictionary<string, object> parametros = new Dictionary<string, object>();
            parametros.Add("IdPersona", oPrestamo.IdPersona.ToString());
            parametros.Add("IdEstado", oPrestamo.IdEstado.ToString());


            string strSql = "BEGIN TRANSACTION " +
                            "USE[64429Pav1] " +

                            "INSERT INTO PRESTAMO(persona_id, estado_id, fecha_desde, fecha_hasta_estimada) " +
                            "VALUES(@IdPersona, @IdEstado, GETDATE(), '"+ oPrestamo.FechaHastaEstimada +"'); " +

                            "DECLARE @IdPrestamo INT; " +
                            "SELECT @IdPrestamo = @@IDENTITY; ";
            int i = 0;
            foreach (DetallePrestamoDTO oDetallePrestamo in oPrestamo.Detalles)
            {
                i++;
                strSql += "INSERT INTO DETALLE_PRESTAMO(prestamo_id, equipo_id) " +
                            "VALUES(@IdPrestamo, @IdEquipo" + i.ToString() + "); ";

                strSql += "UPDATE EQUIPO SET estado_id = (SELECT estado_id FROM ESTADO WHERE nombre_estado = 'PRESTADO') " +
                    "WHERE equipo_id = " + oDetallePrestamo.IdEquipo.ToString() + ";";

                parametros.Add("IdEquipo" + i.ToString(), oDetallePrestamo.IdEquipo.ToString());
            }
            
            strSql += "IF((SELECT COUNT(*) FROM DETALLE_PRESTAMO WHERE prestamo_id = @IdPrestamo) = " + oPrestamo.Detalles.Count.ToString() +") " +
                            "COMMIT; " +
                            "ELSE " +
                            "ROLLBACK; " ;

            DBHelperSql.GetDBHelper().EjecutarSQL(strSql, parametros);
            return true;
        }

        public bool UpdatePrestamoById(PrestamoDTO oPrestamo)
        {
            Dictionary<string, object> parametros = new Dictionary<string, object>();
            parametros.Add("IdPrestamo", oPrestamo.IdPrestamo.ToString());

            string strSql = "BEGIN TRANSACTION " +
                            "USE[64429Pav1] ";

            int i = 0;
            foreach (DetallePrestamoDTO oDetallePrestamo in oPrestamo.Detalles)
            {
                if (oDetallePrestamo.Devuelto)
                {
                    i++;
                    strSql += "UPDATE DETALLE_PRESTAMO " +
                                "SET fecha_devuelto = GETDATE() " +
                                "WHERE detalle_prestamo_id = " + oDetallePrestamo.IdDetallePrestamo.ToString();

                    strSql += " UPDATE EQUIPO SET estado_id = (SELECT estado_id FROM ESTADO WHERE nombre_estado = 'DISPONIBLE') " +
                        "WHERE equipo_id = " + oDetallePrestamo.IdEquipo.ToString() + "";
                }
            }

            strSql += " IF((SELECT COUNT(*) FROM DETALLE_PRESTAMO WHERE prestamo_id = @IdPrestamo AND fecha_devuelto IS NULL GROUP BY prestamo_id ) IS NULL) " +
                        "UPDATE PRESTAMO SET fecha_hasta = GETDATE(), estado_id = (SELECT estado_id FROM ESTADO WHERE nombre_estado = 'DEVUELTO') WHERE prestamo_id = @IdPrestamo; " +
                        "ELSE " +
                        "UPDATE PRESTAMO SET estado_id = (SELECT estado_id FROM ESTADO WHERE nombre_estado = 'DEVUELTO PARCIAL') WHERE prestamo_id = @IdPrestamo; ";
            strSql += " IF(1 = 1) " +
                        "COMMIT; " +
                        "ELSE " +
                        "ROLLBACK; ";

            DBHelperSql.GetDBHelper().EjecutarSQL(strSql, parametros);
            return true;
        }
    }
}
