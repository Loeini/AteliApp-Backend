namespace AteliApp.Requests;

public record AtualizarClienteRequest(
    string? Cpf,
    string? Nome,
    string? Telefone,
    string? Email,
    string? Endereco
);