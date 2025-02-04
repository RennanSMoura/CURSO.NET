using System;
using System.Net;
using System.Threading.Tasks;

class Program
{
    private static async Task<bool> CheckProductStockAsync(string product)
    {
        Console.WriteLine($"Verificando a disponibilidade do produto {product}...");

        await Task.Delay(3000);

        bool isAvailable = true;

        if (isAvailable)
        {
            Console.WriteLine($"O produto {product} está disponivel");
        }
        else
        {
            Console.WriteLine($"O produto {product} está indisponivel");
        }

        return isAvailable;
    }

    private static async Task<bool> CheckClientsPaymentAsync(double productValue, double clientBalance)
    {
        Console.WriteLine("Verificando se está tudo certo com o pagamento...");
        await Task.Delay(3000);

        if (clientBalance >= productValue)
        {
            Console.WriteLine("Pagamento aprovado");
            return true;
        }

        Console.WriteLine("Pagamento reprovado");
        return false;
    }

    private static async Task OrderPreparationAsync()
    {
        Console.WriteLine("Iniciando a preparação do pedido...");

        await Task.Delay(3000);

        Console.WriteLine("O pedido está pronto para o envio");
    }

    static async Task Main(string[] args)
    {
        string product = "Galaxy S25";

        Task<bool> stockTask = Task.Run(() => CheckProductStockAsync(product));
        bool stockIsOk = await stockTask;

        //TODO: PESQUISAR O USO DO TASK.WHENALL() E COMO POSSO APLICAR AQUI
        await Task.WhenAll(stockTask);
        Task<bool> paymentTask = Task.Run(() => CheckClientsPaymentAsync(7000, 10000));

        if (stockIsOk)
        {
            await Task.WhenAll(paymentTask);
        }

        bool paymentIsOk = await paymentTask;

        await Task.WhenAll(stockTask, paymentTask);

        if (!stockIsOk || !paymentIsOk)
        {
            Console.WriteLine("O pedido não pode ser processado");
        }
        else
        {
            await OrderPreparationAsync();
        }
    }
}


