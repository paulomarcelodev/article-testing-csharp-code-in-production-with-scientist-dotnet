using GitHub;

var repositorio = new PessoaRepositorio();
var importadorDePessoas = new ImportadorPessoasV1Servico();
var importadorDePessoas2 = new ImportadorPessoasV2Servico();
Scientist.ResultPublisher = new PublicarConsole();

var pessoasParaImportar = repositorio.PegaTodas();

Console.WriteLine("Importando pessoas");
foreach (var pessoa in pessoasParaImportar)
{
    bool ehCPFValido;

    ehCPFValido = await Scientist.ScienceAsync<bool>("importador-pessoas-v2", experiment =>
    {
        experiment.Use(() => Task.FromResult(importadorDePessoas.EhCPFValido(pessoa.CPF)));
        experiment.Try( async () => await importadorDePessoas2.EhCPFValidoNaInternet(pessoa.CPF));
    });
    
   if (ehCPFValido)
   {
       importadorDePessoas.ImportarPessoa(pessoa.Nome, pessoa.CPF);
   }
   else
   {
       Console.WriteLine($"\tNão consigo importar o {pessoa.Nome}, cpf {pessoa.CPF} é inválido.");
   }
} 
Console.ReadLine();