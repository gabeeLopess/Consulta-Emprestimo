using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrmConsultaEmprestimo
{

    public class ConsultaEmprestimoModel { 
 
    public string TipoItem { get; set; }
    public string CodLeitor { get; set; }
    public string NomeLeitor { get; set; }
    public string Situacao { get; set; }
    public string CodItem { get; set; }
    public string  NomeItem { get; set; }
    public string StatusItem { get; set; }
    public string DataInicio { get; set; }
    public string DataFim { get; set; }
    public string NomeAutor { get; set; }
    public string Local { get; set; }
    public string DescricaoSecao { get; set; }
    public string NomeEditora { get; set; }


        
    }
}
