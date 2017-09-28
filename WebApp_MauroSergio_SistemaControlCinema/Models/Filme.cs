using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApp_MauroSergio_SistemaControlCinema.Models
{
    public class Filme
    {
        public int FilmeId { get; set; }
        public string Titulo { get; set; }
        public decimal Duracao { get; set; }
        public Ator Atores { get; set; }
        public int AtorId { get; set; }
        public List<Ator> Atores { get; set; }
    }
}