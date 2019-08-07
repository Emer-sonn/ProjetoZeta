using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace blog.Models
{
    public class Comentario
    {
        public int ComentarioId { get; set; }
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public DateTime DataComentario { get; set; }
        public string Autor { get; set; }

        public Mensagem mensagem { get; set; }
    }
}
