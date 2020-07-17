using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Data.SqlClient;


namespace trabalhoas.Models
{
    public class FuncionariosModel
    {
        [Key]
        public int ID_FUNCIONARIO { get; set; }

        public int ID_COMERCIO { get; set; }

        public string NOME_FUNCIONARIO { get; set; }

        public string EMAIL_FUNCIONARIO { get; set; }

        public int TELEFONE_FUNCIONARIO { get; set; }

        public string LOCALIDADE_FUNCIONARIO { get; set; }

        public string COD_POSTAL_FUNCIONARIO { get; set; }
    
    }
    public class FuncionarioBD
    {
      
        public List<FuncionariosModel> lista()
        {
            string sql = "SELECT * FROM FUNCIONARIOS";
            DataTable registos = BD.Instance.devolveConsulta(sql);
            List<FuncionariosModel> lista = new List<FuncionariosModel>();
            foreach (DataRow data in registos.Rows)
            {
                FuncionariosModel novo = new FuncionariosModel();
                novo.ID_FUNCIONARIO= int.Parse(data[0].ToString());
                novo.ID_COMERCIO =int.Parse( data[1].ToString());
                novo.NOME_FUNCIONARIO = data[2].ToString();
                novo.EMAIL_FUNCIONARIO = data[3].ToString();
                novo.TELEFONE_FUNCIONARIO = int.Parse(data[4].ToString());
                novo.LOCALIDADE_FUNCIONARIO = data[5].ToString();
                novo.COD_POSTAL_FUNCIONARIO = data[6].ToString();
                lista.Add(novo);
            }
            return lista;
        }
       
    }
    }