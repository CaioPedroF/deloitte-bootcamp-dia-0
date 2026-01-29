

using System.Diagnostics;

public class Produto

{
    public  string Nome{get;private set;}
    public int Preco{get;private set;}

 public int Quantidade{get;private set;} 

 public Produto(string nome,int preco, int quantidade)

 {
      if (string.IsNullOrWhiteSpace(nome))
      
      {
            Console.WriteLine("Nome nao pode ser Vazio");
            throw new Exception("Nao pode ser vazio!");
        }
    if (preco<=0)
        {
            Console.WriteLine("Preço deve ser maior que 0 ");
            throw new Exception("Nao pode ser menor ou igual a 0 ");
        }
    if(quantidade<0)
        {
            Console.WriteLine("nao pode ser negativa");
            throw new Exception("nao pode ser nulo");
        }
    
    Nome=nome;
    Preco=preco;
    Quantidade = quantidade;
 }
}



class Programa
{

     static List <Produto> estoque = new List<Produto>();
     static void Main()
        
    {
       while(true)
      
      
       {
            Console.WriteLine("\n1 Adicionar");
            Console.WriteLine("2 Listar");
            Console.WriteLine("3 Remover");
            Console.WriteLine("0 Sair");



            Console.WriteLine("Escolha");
            string op = Console.ReadLine();

            try
            {
                
              switch(op)

                {
                    case "1":
                      AdicionarProduto();
                     break;
                    case "2":
                      Listar();
                    break;
                    case"3":
                      Remover();
                      break;
                    case "0":
                      return;

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error!" + ex.Message);
             }

         } 
      
    }
static void AdicionarProduto()
    {
        Console.Write("Nome:   ");
        string nome = Console.ReadLine();

        Console.Write("Preço: ");
        int preco = int.Parse(Console.ReadLine());

        Console.Write("quantidade: ");
        int qtd = int.Parse(Console.ReadLine());


        Produto p = new Produto(nome,preco,qtd);

        estoque.Add(p);
        Console.WriteLine("Produto adicionado com Sucesso!");
    }
static void Listar()
    {
        Console.WriteLine("\n--- Estoque ---");

        foreach(var p in estoque)

        {
            Console.WriteLine($"{p.Nome} - R${p.Preco}   - qtd{p.Quantidade}");
        }

        }
static void Remover()

        {
            Console.WriteLine("Nome do produto para Remover:   ");
            string nome = Console.ReadLine();


            Produto p = estoque.Find(x => x.Nome == nome);

            if (p == null)
            {
                Console.WriteLine("Produto não encontrado");
                return;

            }
        
            estoque.Remove(p);
            Console.WriteLine("Produto Removido!!");
        
     }
}






