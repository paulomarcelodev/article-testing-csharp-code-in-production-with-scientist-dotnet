public class PessoaRepositorio
{
    public IEnumerable<Pessoa> PegaTodas()
    {
        yield return new Pessoa()
        {
            Nome = "Paulo",
            CPF = "12345678909"
        };
        yield return new Pessoa()
        {
            Nome = "Vitor",
            CPF = "12345678908"
        };
        yield return new Pessoa()
        {
            Nome = "Igor",
            CPF = "1234567890"
        };
    }
}

namespace ScientistDotnetDemo
{
    public class PessoaRepositorio
    {
        public IEnumerable<Pessoa> PegaTodas()
        {
            yield return new Pessoa()
            {
                Nome = "Paulo",
                CPF = "12345678909"
            };
            yield return new Pessoa()
            {
                Nome = "Vitor",
                CPF = "12345678908"
            };
            yield return new Pessoa()
            {
                Nome = "Igor",
                CPF = "1234567890"
            };
        }
    }
}