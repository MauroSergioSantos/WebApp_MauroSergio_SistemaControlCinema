using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApp_MauroSergio_SistemaControlCinema.Models
{
    public class Ator
    {
        public int AtorId { get; set; }
        public string Nome { get; set; }
        public int FilmeId { get; set; }
        public Filme Filme { get; set; }
        public List<Filme> Filmes { get; set; }
    }
}