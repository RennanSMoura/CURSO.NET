using System;
using System.Threading.Tasks;

class Program
{
    // Método que simula a verificação de pagamento de um pedido
    private static bool VerifyPayment(int orderId, double orderAmount)
    {
        if (orderAmount <= 0)
        {
            Console.WriteLine($"Erro: O valor do pedido {orderId} é inválido (deve ser maior que zero).");
            return false;
        }

        Console.WriteLine($"Verificando pagamento do pedido {orderId}...");
        Task.Delay(2000).Wait(); // Simula o tempo de verificação
        return true; // Simulando que o pagamento foi aprovado
    }

    // Método que simula a preparação do produto
    private static string PrepareProduct(int orderId, int quantity)
    {
        if (quantity <= 0)
        {
            return $"Erro: A quantidade do pedido {orderId} é inválida (deve ser maior que zero).";
        }

        Console.WriteLine($"Preparando produto para o pedido {orderId}...");
        Task.Delay(3000).Wait(); // Simula o tempo de preparação
        return "Produto preparado e pronto para envio!";
    }

    // Método que simula o envio do produto
    private static string ShipProduct(int orderId, string shippingAddress)
    {
        if (string.IsNullOrEmpty(shippingAddress))
        {
            return $"Erro: O endereço de envio do pedido {orderId} é inválido (não pode ser vazio).";
        }

        Console.WriteLine($"Enviando produto do pedido {orderId}...");
        Task.Delay(1500).Wait(); // Simula o tempo de envio
        return "Produto enviado com sucesso!";
    }

    static async Task Main(string[] args)
    {
        int orderId = 12345; // Simulação de um pedido específico
        double orderAmount = 100.50; // Valor do pedido
        int quantity = 3; // Quantidade de itens no pedido
        string shippingAddress = "Rua Exemplo, 123"; // Endereço de envio

        // ------------------ Fase 1: Verificação de Pagamento ------------------

        // Criando e iniciando a tarefa para verificação de pagamento
        Task<bool> paymentTask = Task.Run(() => VerifyPayment(orderId, orderAmount));

        // Fase 2: Preparação do Produto (simulando um processo paralelo ao pagamento)
        Task<string> prepareTask = Task.Run(() => PrepareProduct(orderId, quantity));

        // Fase 3: Envio do Produto (simulando um processo paralelo ao pagamento e preparação)
        Task<string> shipTask = Task.Run(() => ShipProduct(orderId, shippingAddress));

        // Espera a conclusão das tarefas e obtém os resultados
        bool isPaymentVerified = await paymentTask;
        string preparationStatus = await prepareTask;
        string shippingStatus = await shipTask;

        // Exibe os resultados
        Console.WriteLine($"Status do pagamento: {(isPaymentVerified ? "Aprovado" : "Rejeitado")}");
        Console.WriteLine($"Status da preparação: {preparationStatus}");
        Console.WriteLine($"Status do envio: {shippingStatus}");

        if (isPaymentVerified && preparationStatus.Contains("pronto") && !shippingStatus.Contains("Erro"))
        {
            Console.WriteLine($"Processamento do pedido {orderId} concluído com sucesso!");
        }
        else
        {
            Console.WriteLine($"Falha no processamento do pedido {orderId}. Por favor, verifique os detalhes.");
        }
    }
}

// using System;
// using System.Threading.Tasks;

// class Program
// {
//     // Método que simula o trabalho a ser executado de forma assíncrona
//     private static void DoJob()
//     {
//         // Simulando um processo que realiza alguma tarefa (imprime números)
//         for (int i = 0; i < 100; i++)
//         {
//             Console.WriteLine(i);
//         }
//     }

//     private static double DoubleOfANumber(double numero)
//     {
//         return numero * 2;
//     }

//     static void Main(string[] args)
//     {
//         /*
//         //TASK SEM RETORNO
//         //Criando uma nova tarefa que executará o método DoJob
//         Task newTask = new Task(DoJob);

//         //Iniciando a execução da tarefa
//         newTask.Start();

//         //Espera a tarefa terminar antes de seguir com o restante do código
//         newTask.Wait();

//         //Mensagem após a execução da tarefa
//         Console.WriteLine("A tarefa foi concluída.");
//         */

//         // TASK COM RETORNO
//         Task<double> numeroDobrado = new Task<double>(() => DoubleOfANumber(5));
//         // Iniciando a execução da tarefa
//         numeroDobrado.Start();

//         // Espera a tarefa terminar e pega o resultado
//         numeroDobrado.Wait();

//         Console.WriteLine($"O retorno de 5 é: {numeroDobrado.Result}");
//     }
// }
