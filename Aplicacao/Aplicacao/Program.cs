using Aplicacao.Entities;
using Aplicacao.Entities.Enums;
using System;
using System.Globalization;

namespace Aplicacao
{
    class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order
            {
                Id = 1080,
                Moment = DateTime.Now,
                Status = OrderStatus.PendingPayment
            };

            Console.WriteLine(order);

        }
    }
}