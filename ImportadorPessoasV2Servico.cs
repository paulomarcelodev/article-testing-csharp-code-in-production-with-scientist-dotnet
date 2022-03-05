public class ImportadorPessoasV2Servico
{
    public async Task<bool> EhCPFValidoNaInternet(string cpf)
    {
        // valida em algum lugar da internet
        await Task.Delay(250);
        return cpf.EndsWith("9");
    }

    public void ImportarPessoa(string nome, string cpf)
    {
        Console.WriteLine($"\tNome: {nome} - CPF: {cpf}");
        Thread.Sleep(600);
    }
}