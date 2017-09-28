using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApp_MauroSergio_SistemaControlCinema.Models
{
    public class Sala
    {
        public int SalaId { get; set; }
        public int Numero { get; set; }
        public int Capacidade { get; set; }
        public string Descricao { get; set; }
        public int SessaoId { get; set; }
        public Sessao Sessaos { get; set; }
        public Ingresso Ingresso { get; set; }
    }
}