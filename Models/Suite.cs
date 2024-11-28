namespace DesafioProjetoHospedagem.Models
{
    public class Suite
    {
        public Suite(string tipoSuite, int capacidade, decimal valorDiaria)
        {
            TipoSuite = tipoSuite;
            Capacidade = capacidade;
            ValorDiaria = valorDiaria;
        }

        public string TipoSuite { get; private set; }
        public int Capacidade { get; private set; }
        public decimal ValorDiaria { get; private set; }
    }
}
