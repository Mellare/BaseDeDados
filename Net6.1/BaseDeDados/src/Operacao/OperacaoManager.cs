namespace BaseDeDados.Operacao;

public class OperacaoManager
{
    public class OperacaoManager
{
Stack<string> pilha = new Stack<string>();
    public void AdicionarNovaOperacao()
    {
        Console.WriteLine("Digite a operação");
        var operacao = Console.ReadLine();
        pilha.Push(operacao);
        Console.WriteLine("Operação adicionada com sucesso!");
        Console.ReadLine();
    }

    public void DesfazerUltimaOperacao()
    {
        if(pilha.Count <= 0){
            Console.WriteLine("Nenhuma operação para ser desfeita");
            Console.ReadLine();
        }
        else{
            Console.WriteLine($"Ultima operação desfeita: {pilha.Pop()}");
            Console.ReadLine();
        }
    }

    public void RealizarTodasAsOperacaos()
    {
         if(pilha.Count <= 0){
            Console.WriteLine("Nenhuma operação para ser realizada");
        }
        else{
            while(pilha.Count() != 0)
            {
                Console.WriteLine($"{pilha.Pop()} realizada");
            }
        }
        Console.ReadLine();
    }
}
