namespace Provas_Online.Dominio.Entidades
{
    public class OpcaoQuestao
    {
        public int Id { get; set; }
        public Questao Questao { get; set; }
        public int IdQuestao { get; set; }
        public string Descricao { get; set; }
        public bool Verdadeira { get; set; }
    }
}