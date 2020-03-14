using System;
using System.Collections.Generic;
using System.Text;
using ServiçoPagamento.Entities;

namespace ServiçoPagamento.Services
{
    class ContractService
    {

        private OnlinePaymentsService _onlinePaymentService;

        public ContractService(OnlinePaymentsService onlinePaymentService)
        {
            _onlinePaymentService = onlinePaymentService;
        }

        public void processContract(Contract contract,int months ){

            double basicQuota = contract.TotalValue / months;

            for (int i = 0; i <= months ; i++)
            {
                DateTime date = contract.Date.AddMonths(i);
                double updatedQuota = basicQuota + _onlinePaymentService.Interest(basicQuota, i);
                double fullQuota = updatedQuota + _onlinePaymentService.PaymentFee(updatedQuota);
                contract.AddInstallment(new Installment(date, fullQuota));
            }
        }

          
    }
}
