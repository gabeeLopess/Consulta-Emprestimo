using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrmConsultaEmprestimo
{
    internal class SecaoDao
    {
        private SqlConnection Connection { get; }
        public SecaoDao(SqlConnection connection)
        {
            Connection = connection;
        }

        public List<SecaoModel> GetSecaos()
        {
            List<SecaoModel> secaos = new List<SecaoModel>();
            using (SqlCommand command = Connection.CreateCommand())
            {
                StringBuilder sql = new StringBuilder();
                sql.AppendLine("SELECT codSecao, descricaoSecao FROM MvtBIBSecao");
                command.CommandText = sql.ToString();
                using (SqlDataReader dr = command.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        secaos.Add(populateDr(dr));

                    }
                }

            }
            return secaos;
        }


        private SecaoModel populateDr(SqlDataReader dr)
        {
            string codSecao = "";
            string descricaoSecao = "";

            if (DBNull.Value != dr["codSecao"])
            {
                codSecao = dr["codSecao"] + "";
            }
            if (DBNull.Value != dr["descricaoSecao"])
            {
                descricaoSecao = dr["descricaoSecao"] + "";
            }

            return new SecaoModel()
            {

                CodSecao = codSecao,
                DescricaoSecao = descricaoSecao,


            };
        }
    }
}

