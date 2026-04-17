namespace AteliApp.Application.DTOs;

public class CriarMedidasDto
{
    public Guid IdCliente { get; }
    public int? Altura { get; }
    public int? Busto { get; }
    public int? Cintura { get; }
    public int? Quadril { get; }
    public int? Ombro { get; }
    public string? Outros { get; }
    public string? Observacao { get; }

    public CriarMedidasDto(
        Guid idCliente,
        int? altura,
        int? busto,
        int? cintura,
        int? quadril,
        int? ombro,
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


