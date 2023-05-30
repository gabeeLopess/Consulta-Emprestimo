using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrmConsultaEmprestimo
{
    [Table("mvtBibReserva")]
    public class ConsultaEmprestimoModel
    {
        [Key()]

    public string TipoItem { get; set; }
    public string CodLeitor { get; set; }
    public string NomeLeitor { get; set; }
    public string Situacao { get; set; }
    public string CodItem { get; set; }
    public string  NomeItem { get; set; }
    public string DataInicio { get; set; }
    public string DataFim { get; set; }

        [ForeignKey("mvtBiibAutor")]
        [Column("codAutor")]
        public string CodAutor { get; set; }
        public virtual AutorModel AutorModel { get; set; }

        [ForeignKey("MvtBIBLocal")]
        [Column("codLocal")]
        public string CodLocal { get; set; }
        public virtual LocalModel LocalModel { get; set; }

        [ForeignKey("MvtBIBSecao")]
        [Column("codSecao")]
        public string CodSecao { get; set; }
        public virtual SecaoModel SecaoModel { get; set; }

        [ForeignKey("mvtBiibEditora")]
        [Column("codEditora")]
        public string CodEditora { get; set; }
        public virtual EditoraModel EditoraModel { get; set; }
        public object Local { get; internal set; }
    }
}
