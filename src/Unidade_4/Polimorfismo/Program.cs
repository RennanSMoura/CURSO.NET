// O conceito de polimorfismo é de sobrescrever métodos de classes herdadas, fazendo com que seja possível reutilizar um determinado método, mas sobrescrevendo a classe anterior
using Polimorfismo.Models;

Aluno a1 = new Aluno();

a1.Nome = "Rennan";
a1.Idade = 20;
a1.Nota = 10;
a1.Apresentar();

Professor p1 = new Professor();
p1.Nome = "Leonardo";
p1.Idade = 30;
p1.Salario = 1000;
p1.Apresentar();
