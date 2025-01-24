// Exercício 1: Crie uma classe Carro com os seguintes atributos: marca, modelo e ano. Implemente um construtor que inicialize esses atributos. Crie um objeto Carro e exiba seus detalhes no console.
using Construtor.Models;


Carro carro = new Carro("Ford", "Fusion", 2012);

Console.WriteLine($"Marca: {carro.Marca}, Modelo: {carro.Modelo}, Ano: {carro.Ano}");

// Saída esperada : Marca: Ford, Modelo: Fusion, Ano: 2012
