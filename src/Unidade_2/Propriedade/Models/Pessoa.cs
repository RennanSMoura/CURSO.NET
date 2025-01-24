public class Pessoa
{

    // <Construtor>
    public Pessoa(string nome,string sobrenome)
    {
        Nome = nome;
        Sobrenome = sobrenome;
    }

    // Por padrao nao tem nenhum tipo de retorno, por convenção recebe o nome da classe;
    public Pessoa()
    {

    }    
    // </Construtor>
    
    public void Deconstruct(out string nome, out string sobrenome)
    {
        nome = Nome;
        sobrenome = sobrenome;
    }

    private string _nome;
    private int _idade;

    public string Nome 
    { 

        get => return _nome.ToUpper();
    
        set
        {
            if(value == "")
            {
            throw new ArgumentException ("O nome nao pode ser vazio");
            }

            _nome = value;
    }
 }

    public int Idade 
    {
        get => _idade; 

        set
        {
            if (value < 0)
            {
                throw new ArgumentException ("O iddade nao pode ser menor que 0");
            }
        } 
    }

    public void Apresentar()
    {
        Console.WriteLine($"{NomeCompleto}, {Idade}")
    }
}

    public string Sobrenome
    {
        get ; set;
    }

    public string NomeCompleto get => $"{Nome} {Sobrenome}";
    
    {
        get ; set;
    }

    public Date DataNascimento {get; set;}
