namespace AteliApp.Application.DTOs;

public class AtualizarMedidasDto
{
    public int? Altura { get; }
    public int? Busto { get; }
    public int? Cintura { get; }
    public int? Quadril { get; }
    public int? Ombro { get; }
    public string? Outros { get; }
    public string? Observacao { get; }

    public AtualizarMedidasDto(
        int? altura = null,
        int? busto = null,
        int? cintura = null,
        int? quadril = null,
        int? ombro = null,
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