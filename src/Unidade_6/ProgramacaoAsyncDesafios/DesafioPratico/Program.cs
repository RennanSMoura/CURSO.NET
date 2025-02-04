using System;
using System.Net;
using System.Net.Sockets;
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

    public static async Task<bool> CheckIsValidAdress(string address)
    {
        Console.WriteLine("Verificando o endereço de entrega");

        string keyWord = "Rua";
        
        await Task.Delay(2000);
        
        bool isValidAddress = address.Contains(keyWord); 

        if(isValidAddress)
        {
            Console.WriteLine("O endereço de entrega é válido");
            return isValidAddress;
        }
        Console.WriteLine("O endereço de entrega é inválido");
        return isValidAddress;
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
        bool stockIsOk = false;
        bool paymentIsOk = false;
        bool addressIsOk = false;

        stockIsOk = await CheckProductStockAsync(product);
        addressIsOk = await CheckIsValidAdress("Rua Dotz");

        if (stockIsOk && addressIsOk)
        {
            paymentIsOk = await CheckClientsPaymentAsync(7000, 10000);
        }

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


