using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrmConsultaEmprestimo
{
    [Table("mvtBiibEditora")]
    public class EditoraModel
    {
       [Key()]
     public string CodEditora { get; set; }
     public string NomeEditora { get; set; }
    }
}
