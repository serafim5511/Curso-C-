using System;
using System.Collections.Generic;
using System.Text;

namespace ServiçoPagamento.Services
{
    interface OnlinePaymentsService
    {
            
        double PaymentFee(double amount);
        double Interest(double amount, int months);


    }
}
