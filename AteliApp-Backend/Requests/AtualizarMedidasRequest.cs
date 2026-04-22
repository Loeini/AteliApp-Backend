namespace AteliApp.Requests;

public record AtualizarMedidasRequest(
    decimal? Altura,
    decimal? Busto,
    decimal? Cintura,
    decimal? Quadril,
    decimal? Ombro,
    string? Outros,
    string? Observacao
);