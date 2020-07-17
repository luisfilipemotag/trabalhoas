using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Data.SqlClient;


namespace trabalhoas.Models
{
    public class ComprasModel
    {
        [Key]
        public int ID_COMPRA { get; set; }

        public int ID_CARTAO     { get; set; }

        public string DATA_COMPRA { get; set; }

    
    }
    public class ComprasBD
    {
      
        public List<ComprasModel> lista()
        {
            string sql = "SELECT * FROM COMPRA";
            DataTable registos = BD.Instance.devolveConsulta(sql);
            List<ComprasModel> lista = new List<ComprasModel>();
            foreach (DataRow data in registos.Rows)
            {
                ComprasModel novo = new ComprasModel();
                novo.ID_COMPRA = int.Parse(data[0].ToString());
                novo.ID_CARTAO = int.Parse(data[1].ToString());
                novo.DATA_COMPRA = data[2].ToString();
                lista.Add(novo);
            }
            return lista;
        }
       

    }
    }