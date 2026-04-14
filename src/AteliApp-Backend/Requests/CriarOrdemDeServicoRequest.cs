namespace AteliApp.Requests;

public record CriarOrdemDeServicoRequest(
    Guid ClienteId,
    string Titulo,
    string Descricao,
    DateTime? DataEntrega,
    string Status,
    string TipoServico,
    decimal Valor,
    Guid? MedidasId
);