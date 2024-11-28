namespace DesafioProjetoHospedagem.Models
{
    public class Reserva
    {
        public Reserva(int diasReservados)
        {
            DiasReservados = diasReservados > 0
                ? diasReservados
                : throw new ArgumentException("O número de dias reservados deve ser maior que zero.");
        }

        private List<Pessoa> _hospedes = new();
        public IReadOnlyCollection<Pessoa> Hospedes => _hospedes.AsReadOnly();

        public Suite Suite { get; private set; }
        public int DiasReservados { get; private set; }

        public void CadastrarHospedes(IEnumerable<Pessoa> hospedes)
        {
            if (Suite == null)
            {
                throw new InvalidOperationException("Nenhuma suíte foi cadastrada.");
            }

            var listaHospedes = hospedes.ToList();

            if (listaHospedes.Count > Suite.Capacidade)
            {
                throw new InvalidOperationException("A quantidade de hóspedes excede a capacidade da suíte.");
            }

            _hospedes = listaHospedes;
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite ?? throw new ArgumentNullException(nameof(suite), "A suíte não pode ser nula.");
        }

        public int ObterQuantidadeHospedes()
        {
            return _hospedes.Count;
        }

        public decimal CalcularValorDiaria()
        {
            if (Suite == null)
            {
                throw new InvalidOperationException("Nenhuma suíte foi cadastrada.");
            }

            decimal valorTotal = DiasReservados * Suite.ValorDiaria;

            if (DiasReservados >= 10)
            {
                valorTotal *= 0.90m; // Aplica desconto de 10%
            }

            return valorTotal;
        }
    }
}
