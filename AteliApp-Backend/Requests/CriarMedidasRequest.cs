namespace AteliApp.Requests;

public record CriarMedidasRequest(
    Guid IdCliente,
    int? Altura,
    int? Busto,
    int? Cintura,
    int? Quadril,
    int? Ombro,
    string? Outros,
    string? Observacao
);