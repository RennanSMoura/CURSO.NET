// // Exercício 1: Crie uma fila (Queue) para simular o atendimento em um banco. Adicione pelo menos 5 clientes à fila e exiba o nome do próximo cliente a ser atendido.

 Queue<string> clienteFila = new Queue<string>();

 clienteFila.Enqueue("Rennan");
 clienteFila.Enqueue("Paulo");
 clienteFila.Enqueue("João");
 clienteFila.Enqueue("Pedro");
 clienteFila.Enqueue("Marcos");

 while(clienteFila.Count > 0)
 {
     string clienteAtendido = clienteFila.Dequeue();
     Console.WriteLine($"O próximo cliente a ser atendido será o {clienteAtendido}")
 }

