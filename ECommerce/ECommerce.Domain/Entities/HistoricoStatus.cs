using ECommerce.Infra.CrossCutting.DataTransferObject.Enuns;
using System;

namespace ECommerce.Domain.Entities
{
    public class HistoricoStatus
    {
        public int IdPedido { get; set; }
        public virtual Pedido Pedido { get; set; }
        public int IdStatus { get; set; }
        public virtual StatusPedido Status { get; set; }
        public DateTime DataStatus { get; set; }
        public StatusAtraso StatusDoAtraso => VerificarAtraso();

        private StatusAtraso VerificarAtraso()
        {
            Func<DateTime?, StatusAtraso> calculaTempo = tempo =>
                (!tempo.HasValue || tempo <= Pedido.DataPrevisaoEntrega) ? StatusAtraso.NoPrazo : StatusAtraso.Atrasado;

            switch (IdStatus)
            {
                case 1:
                    return calculaTempo(DataStatus.AddMinutes(1));
                case 2:
                    return calculaTempo(DataStatus.AddMinutes(10));
                case 3:
                    return calculaTempo(DataStatus.AddHours(2));
                case 4:
                    return calculaTempo(DataStatus.AddDays(3));
                case 5:
                    return calculaTempo(DataStatus.AddDays(2));
                case 6:
                    return calculaTempo(DataStatus.AddDays(2));
                case 7:
                    return calculaTempo(null);
                case 8:
                    return calculaTempo(null);
            }
            return StatusAtraso.Atrasado;
        }
    }
}
