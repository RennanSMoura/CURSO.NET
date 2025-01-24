// // Em .NET, uma propriedade encapsula um campo e fornece um mecanismo para acessar ou modificar seu valor. Isso permite controlar a forma como os valores são atribuídos e recuperados, oferecendo flexibilidade e segurança.
// // Aqui estão alguns pontos adicionais que podem complementar sua anotação:
// // Getters e Setters: As propriedades geralmente possuem métodos get e set. O método get é usado para recuperar o valor da propriedade, enquanto o método set é usado para atribuir um novo valor.
// // Propriedades Automáticas: Em muitos casos, você pode usar propriedades automáticas, onde o compilador gera automaticamente o campo subjacente.
// // Propriedades Somente Leitura: Você pode criar propriedades que são apenas de leitura (sem set), garantindo que o valor não possa ser alterado após a inicialização.
// // Validação e Lógica: Propriedades permitem que você adicione lógica de validação e outras operações ao acessar ou modificar o valor.

// using //namespace;

// Pessoa p1 = new Pessoa(nome: "Rennan", sobrenome: "Moura");
// //p1.Nome = "Rennan";
// //p1.Idade = 20;
// //p1.Sobrenome = "Moura";
// p1.Apresentar();

// Pessoa p2 = new Pessoa();
// p2.Nome = "Leticia";
// p2.Sobrenome = "Redondo";


// Curso cursoDeIngles = new Curso();
// cursoDeIngles.Nome = "Ingles";
// cursoDeIngles.ALunos = new List<Pessoa>();

// cursoDeIngles.AdicionarAluno(p1);
// cursoDeIngles.AdicionarAluno(p2);
// cursoDeIngles.ListarAlunos

Pessoa p1 = new Pessoa("Rennan", "Moura"); // Chamando construtor

(string nome, string sobrenome) = p1; // Desconstrutor

