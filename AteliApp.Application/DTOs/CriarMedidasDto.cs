namespace AteliApp.Application.DTOs;

public class CriarMedidasDto
{
    public Guid IdCliente { get; }
    public decimal? Altura { get; }
    public decimal? Busto { get; }
    public decimal? Cintura { get; }
    public decimal? Quadril { get; }
    public decimal? Ombro { get; }
    public string? Outros { get; }
    public string? Observacao { get; }

    public CriarMedidasDto(
        Guid idCliente,
        decimal? altura,
        decimal? busto,
        decimal? cintura,
        decimal? quadril,
        decimal? ombro,
        string? outros,
        string? observacao)
    {
        IdCliente = idCliente;
        Altura = altura;
        Busto = busto;
        Cintura = cintura;
        Quadril = quadril;
        Ombro = ombro;
        Outros = outros;
        Observacao = observacao;
    }
}


