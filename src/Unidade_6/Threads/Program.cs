using System;
using System.Threading;
class Program
{
    // Variáveis compartilhadas
    static bool isBackupCompleted = false;
    static bool isServiceRunning = false;
    static bool isLogProcessed = false;

    static void Main()
    {
        // Thread para monitorar o serviço
        Thread serviceThread = new Thread(MonitorService);
        serviceThread.Start();

        // Thread para processar os logs
        Thread logThread = new Thread(ProcessLogs);
        logThread.Start();

        // Thread para realizar o backup
        Thread backupThread = new Thread(PerformBackup);
        backupThread.Start();

        // Aguarda o término de todas as threads
        serviceThread.Join();
        logThread.Join();
        backupThread.Join();

        // Exibe o status final do servidor
        Console.WriteLine("\nMonitoramento Completo!");
        Console.WriteLine($"Serviço está rodando: {isServiceRunning}");
        Console.WriteLine($"Logs processados: {isLogProcessed}");
        Console.WriteLine($"Backup realizado: {isBackupCompleted}");
    }

    // Método para monitorar o serviço
    static void MonitorService()
    {
        Console.WriteLine("Iniciando monitoramento do serviço...");
        Thread.Sleep(5000); // Simula o tempo de monitoramento
        isServiceRunning = true;
        Console.WriteLine("Serviço está rodando corretamente.");
    }

    // Método para processar os logs
    static void ProcessLogs()
    {
        Console.WriteLine("Iniciando processamento de logs...");
        Thread.Sleep(3000); // Simula o tempo de processamento de logs
        isLogProcessed = true;
        Console.WriteLine("Logs processados com sucesso.");
    }

    // Método para realizar o backup
    static void PerformBackup()
    {
        Console.WriteLine("Iniciando backup...");
        Thread.Sleep(7000); // Simula o tempo de backup
        isBackupCompleted = true;
        Console.WriteLine("Backup realizado com sucesso.");
    }
}







// EXEMPLO 2: 

// using System;
// using System.Threading;

// class Program
// {
//     static void Main()
//     {
//         // Variáveis compartilhadas entre threads
//         int sum = 0;  // Soma que será incrementada pela thread
//         bool completed = false; // Flag que indica quando a thread deve parar

//         // Criação da thread que vai executar a soma
//         Thread countingThread = new Thread(new ThreadStart(() =>
//         {
//             // Enquanto a flag 'completed' for falsa, a thread continua incrementando a soma
//             while (!completed)
//             {
//                 sum += 1; // Incrementa a soma
//             }
//         }));

//         // Inicia a execução da thread
//         countingThread.Start();

//         // Faz a thread principal "dormir" por 10 segundos (simulando processamento)
//         Thread.Sleep(10000); 

//         // Após 10 segundos, definimos a flag 'completed' como verdadeira, interrompendo o loop da thread
//         completed = true;

//         // Espera a thread de contagem finalizar antes de exibir o resultado
//         countingThread.Join(); // Aguarda o término da execução da thread countingThread

//         // Exibe o resultado final da soma
//         Console.WriteLine($"A soma total após 10 segundos é: {sum}");
//     }
// }

