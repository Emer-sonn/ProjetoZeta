using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace blog.Models
{
    public class Mensagem
    {
        public int MensagemId { get; set; }
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public DateTime? DataMensagem { get; set; }
        
        public List<Categoria> Categoria { get; set; }

    }
}
