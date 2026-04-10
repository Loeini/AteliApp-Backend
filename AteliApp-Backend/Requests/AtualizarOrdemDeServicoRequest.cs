namespace AteliApp.Requests;

public record AtualizarOrdemDeServicoRequest(
    string? Titulo,
    string? Descricao,
    DateTime? DataEntrega,
    string? Status,
    string? TipoServico,
    decimal? Valor
);