using Provas_Online.Dominio.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Provas_Online.Dominio.Entidades
{
    public class Questao
    {
        public int Id { get; set; }
        public int Tipo { get; set; }
        public string Enunciado { get; set; }
        public TipoQuestaoEnum TipoQuestaoEnum { get; set; }
        public Avaliacao Avaliacao { get; set; }
        public int IdAvaliacao { get; set; }
        public List<OpcaoQuestao> OpcaoQuestao { get; set; }
    }
}
