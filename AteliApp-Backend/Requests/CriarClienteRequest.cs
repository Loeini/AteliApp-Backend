namespace AteliApp.Requests;

public record CriarClienteRequest(
    string Cpf,
    string Nome,
    string? Telefone,
    string? Email,
    string Endereco
);