namespace AteliApp.Requests;

public record AtualizarMedidasRequest(
    int? Altura,
    int? Busto,
    int? Cintura,
    int? Quadril,
    int? Ombro,
    string? Outros,
    string? Observacao
);