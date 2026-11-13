namespace MauiAppHotel.Models
{
    internal class Hospedagem
    {
        public Quarto suite { get; set; }
        public int QntAdultos { get; set; }
        public int QntCrianca { get; set; }
        public DateTime DataCheckIn { get; set; }

        public DateTime DataCheckOut { get; set; }

        public int Estadia 
        {
            get => DataCheckOut.Subtract(DataCheckIn).Days;
        }

        public double ValorTotal
        {
            get
            {
                double valor_adultos = QntAdultos * suite.ValorDiariaAdulto;
                double valor_crianca = QntCrianca * suite.ValorDiariaCrianca;

                double total = (valor_adultos + valor_crianca) * Estadia;

                return total;
            }
        }
    }
}
