namespace BaseDeDados.Usuario;

public class UsuarioManager
{
      List<Usuario> listaUsuarios = new List<Usuario>();
    public void AdicionarUsuarioNaBase()
    {
       var user = new Usuario();
       Console.WriteLine("Nome: ");
       user.Nome = Console.ReadLine();
       Console.WriteLine("CPF: ");
       user.CPF = int.Parse(Console.ReadLine());
       Console.WriteLine("RA: ");
       user.RA = int.Parse(Console.ReadLine());
       Console.WriteLine("Email: ");
       user.Email = Console.ReadLine();
       Console.WriteLine("Data de Nascimento: ");
       user.DataDeNascimento = DateTime.Parse(Console.ReadLine());
       
       listaUsuarios.Add(user);
       Console.WriteLine("Usuário Adicionado!");

    }

    public void RemoverUsuarioDaBase()
    {
       var nomeParaRemover = Console.ReadLine();
       listaUsuarios.Remove(x => x.Nome == nomeParaRemover);
    }

    public void AlterarUsuarioNaBase()
    {
        Console.WriteLine("Opicional");
    }

    public void PesquisarUsuarioNaBase()
    {
        var nomeParaEncontrar = Console.ReadLine();
        listaUsuarios.Find(nomeParaEncontrar);
        Console.WriteLine(nomeParaEncontrar);
    }

    public void ListarTodosOsUsuariosDaBase()
    {
        foreach (var i in listaUsuarios){
            Console.WriteLine(i);
        }
    }
}
