using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApp_MauroSergio_SistemaControlCinema.Models
{
    public class Ingresso
    {
        public int IngressoId { get; set; }
        public int Tipo { get; set; }
        public int SessaoId { get; set; }
        public Sala Sala { get; set; }
        public List<Sessao> Sessaos { get; set; }
    }
}