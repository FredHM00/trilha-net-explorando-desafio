namespace DesafioProjetoHospedagem.Models
{
    public class Pessoa
    {
        public Pessoa(string nome, string sobrenome = "")
        {
            Nome = nome;
            Sobrenome = sobrenome;
        }

        public string Nome { get; private set; }
        public string Sobrenome { get; private set; }
        public string NomeCompleto => $"{Nome} {Sobrenome}".Trim().ToUpper();
    }
}
