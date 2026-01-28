

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
            return;
        }
    if (preco<=0)
        {
            Console.WriteLine("Preço deve ser maior que 0 ");
            return;
        }
    if(quantidade<0)
        {
            Console.WriteLine("nao pode ser negativa");
            return;
        }
    
    Nome=nome;
    Preco=preco;
    Quantidade = quantidade;
 }
}



class Programa
{
    static void Main()

    {
        List<Produto> estoque = new List<Produto>();

        Produto p1 = new Produto("Teclado",200,5);
        Produto p2 = new Produto("",75,1);
        Produto p3 = new Produto("Mouse",-34,12);

        if (!string.IsNullOrEmpty(p1.Nome))
        estoque.Add(p1);
        if(!string.IsNullOrEmpty(p2.Nome))
        estoque.Add(p2);
        if(!string.IsNullOrEmpty(p3.Nome))
        estoque.Add(p3);

        Console.WriteLine("Produtos cadastrados");
        foreach(var produto in estoque)
        {
            Console.WriteLine($"{produto.Nome} - R${produto.Preco} - qtd{produto.Quantidade}");
        }
    



    }
}






