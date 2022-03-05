public class ImportadorPessoasV1Servico
{
    public bool EhCPFValido(string cpf)
    {
        return cpf.Length == 11;
    }

    public void ImportarPessoa(string nome, string cpf)
    {
        Console.WriteLine($"\tNome: {nome} - CPF: {cpf}");
        Thread.Sleep(200);
    }
}

namespace ScientistDotnetDemo
{
    public class ImportadorPessoasV1Servico
    {
        public bool EhCPFValido(string cpf)
        {
            return cpf.Length == 11;
        }

        public void ImportarPessoa(string nome, string cpf)
        {
            Console.WriteLine($"\tNome: {nome} - CPF: {cpf}");
            Thread.Sleep(200);
        }
    }
}