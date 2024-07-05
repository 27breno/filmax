
using Trabalho_Paulo;

class Program
{
    static void Main()
    {
        Estacionamento estacionamento = new Estacionamento(10); // Exemplo com 10 vagas
        InterfaceUsuario interfaceUsuario = new InterfaceUsuario(estacionamento);
        interfaceUsuario.Iniciar();
    }
}




