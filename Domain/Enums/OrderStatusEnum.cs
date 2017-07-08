using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Enums
{
    public enum OrderStatusEnum
    {
        AGUARDANDO_PAGAMENTO = 1,
        EM_ANALISE = 2,
        PAGA = 3,
        DISPONÍVEL = 4,
        EM_DISPUTA = 5,
        DEVOLVIDA = 6,
        CANCELADA = 7,
        CHARGEBACK_DEBITADO = 8,
        EM_CONTESTACAO = 9,
    }
}
