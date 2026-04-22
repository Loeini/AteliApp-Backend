namespace AteliApp.Requests;

public record CriarMedidasRequest(
    Guid IdCliente,
    decimal? Altura,
    decimal? Busto,
    decimal? Cintura,
    decimal? Quadril,
    decimal? Ombro,
    string? Outros,
    string? Observacao
);