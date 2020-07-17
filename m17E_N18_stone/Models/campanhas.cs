using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Data.SqlClient;


namespace trabalhoas.Models
{
    public class CampanhasModel
    {
        [Key]
        public int CAMPANHAS { get; set; }

        public string NOME_CAMPANHA { get; set; }

        public string DATA_INICIO_CAMPANHA { get; set; }

        public string DATA_FIM_CAMPANHA { get; set; }

        public string DESCRICAO_CAMPANHAS { get; set; }
    
    }
    public class CampanhasBD
    {
      
        public List<CampanhasModel> lista()
        {
            string sql = "SELECT * FROM CAMPANHAS";
            DataTable registos = BD.Instance.devolveConsulta(sql);
            List<CampanhasModel> lista = new List<CampanhasModel>();
            foreach (DataRow data in registos.Rows)
            {
                CampanhasModel novo = new CampanhasModel();
                novo.CAMPANHAS = int.Parse(data[0].ToString());
                novo.NOME_CAMPANHA = data[1].ToString();
                novo.DATA_INICIO_CAMPANHA = data[2].ToString();
                novo.DATA_FIM_CAMPANHA = data[3].ToString();
                novo.DESCRICAO_CAMPANHAS = data[4].ToString();
                lista.Add(novo);
            }
            return lista;
        }

        public List<CampanhasModel> pesquisa(string Nome)
        {
            string sql = "SELECT * FROM CAMPANHAS WHERE NOME_CAMPANHA like @nome";
            List<SqlParameter> parametros = new List<SqlParameter>()
            {
                new SqlParameter() {ParameterName="@nome",SqlDbType=System.Data.SqlDbType.VarChar,Value='%'+(string)Nome+'%'   }
            };
            DataTable registos = BD.Instance.devolveConsulta(sql, parametros);
            List<CampanhasModel> lista = new List<CampanhasModel>();
            foreach (DataRow data in registos.Rows)
            {
                CampanhasModel novo = new CampanhasModel();
                novo.CAMPANHAS = int.Parse(data[0].ToString());
                novo.NOME_CAMPANHA = data[1].ToString();
                novo.DATA_INICIO_CAMPANHA = data[2].ToString();
                novo.DATA_FIM_CAMPANHA = data[3].ToString();
                novo.DESCRICAO_CAMPANHAS = data[4].ToString();
                lista.Add(novo);
            }

            return lista;
        }
    }
    }