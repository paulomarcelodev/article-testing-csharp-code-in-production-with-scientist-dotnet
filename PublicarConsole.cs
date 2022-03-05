using GitHub;

public class PublicarConsole : IResultPublisher
{
    public Task Publish<T, TClean>(Result<T, TClean> result)
    {
        Console.ForegroundColor = result.Mismatched ? ConsoleColor.Red : ConsoleColor.Green;

        Console.WriteLine($"Nome do experimento: '{result.ExperimentName}'");
        Console.WriteLine($"Resultado: " +
                          $"'{(result.Matched ? "Controle COINCIDE com candidato" : "Controle NÃO COINCIDE com candidato")}'");
        Console.WriteLine($"Valor do controle: {result.Control.Value}");
        
        Console.ForegroundColor = ConsoleColor.DarkCyan;
        foreach (var candidato in result.Candidates)
        {
            Console.WriteLine($"Nome do candidato: {candidato.Name}");
            Console.WriteLine($"Valor do candidato: {candidato.Value}");
        }

        if (result.Mismatched)
        {
            // savar incompatibilidade do experimento em um log, arquivo, banco de dados para alertar/comparar
        }

        Console.ForegroundColor = ConsoleColor.White;

        return Task.FromResult(0);
    }
}