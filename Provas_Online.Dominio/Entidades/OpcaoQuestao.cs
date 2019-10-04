using Provas_Online.Dominio.Entidades.Base;

namespace Provas_Online.Dominio.Entidades
{
    public class OpcaoQuestao : EntidadeBase
    {
        public Questao Questao { get; set; }
        public int IdQuestao { get; set; }
        public string Descricao { get; set; }
        public bool Verdadeira { get; set; }
    }
}