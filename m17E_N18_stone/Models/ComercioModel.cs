using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Data.SqlClient;


namespace trabalhoas.Models
{
    public class ComercioModel
    {
        [Key]
        public int ID_COMERCIO { get; set; }

        public string NOME_COMERCIO { get; set; }

        public string EMAIL_COMERCIO { get; set; }

        public int TELEFONE_COMERCIO { get; set; }

        public string MORADA_COMERCIO { get; set; }

        public string LOCALIDADE_COMERCIO { get; set; }

        public string COD_POSTAL_COMERCIO { get; set; }

        public string DESCRICAO_COMERCIO { get; set; }

        public string DATA_ABERTURA_COMERCIO { get; set; }

        public string PROPRIETARIO_COMERCIO { get; set; }

    }
    public class ComercioBD
    {
      
        public List<ComercioModel> lista()
        {
            string sql = "SELECT * FROM COMERCIO";
            DataTable registos = BD.Instance.devolveConsulta(sql);
            List<ComercioModel> lista = new List<ComercioModel>();
            foreach (DataRow data in registos.Rows)
            {
                ComercioModel novo = new ComercioModel();
                novo.ID_COMERCIO = int.Parse(data[0].ToString());
                novo.NOME_COMERCIO = data[1].ToString();
                novo.EMAIL_COMERCIO = data[2].ToString();
                novo.TELEFONE_COMERCIO = int.Parse(data[3].ToString());
                novo.MORADA_COMERCIO = data[4].ToString();
                novo.LOCALIDADE_COMERCIO = data[5].ToString();
                novo.COD_POSTAL_COMERCIO = data[6].ToString();
                novo.DESCRICAO_COMERCIO = data[7].ToString();
                novo.DATA_ABERTURA_COMERCIO = data[8].ToString();
                novo.PROPRIETARIO_COMERCIO = data[9].ToString();
                lista.Add(novo);
            }
            return lista;
        }
        

    }
    }