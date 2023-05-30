using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrmConsultaEmprestimo
{
       [Table("MvtBIBSecao")]
        public class SecaoModel
        {
            [Key()]
            public string CodSecao { get; set; }
            public string DescricaoSecao { get; set; }
        }
 }

