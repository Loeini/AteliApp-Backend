namespace AteliApp.Application.DTOs;

public class AtualizarMedidasDto
{
    public decimal? Altura { get; }
    public decimal? Busto { get; }
    public decimal? Cintura { get; }
    public decimal? Quadril { get; }
    public decimal? Ombro { get; }
    public string? Outros { get; }
    public string? Observacao { get; }

    public AtualizarMedidasDto(
        decimal? altura = null,
        decimal? busto = null,
        decimal? cintura = null,
        decimal? quadril = null,
        decimal? ombro = null,
        string? outros = null,
        string? observacao = null)
    {
        Altura = altura;
        Busto = busto;
        Cintura = cintura;
        Quadril = quadril;
        Ombro = ombro;
        Outros = outros;
        Observacao = observacao;
    }
}