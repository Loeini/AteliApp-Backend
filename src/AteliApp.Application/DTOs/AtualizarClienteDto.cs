namespace AteliApp.Application.DTOs;

public class AtualizarClienteDto
{
    public string? Cpf { get; }
    public string? Nome { get; }
    public string? Telefone { get; }
    public string? Email { get; }
    public string? Endereco { get; }

    public AtualizarClienteDto(
        string? cpf = null,
        string? nome = null,
        string? telefone = null,
        string? email = null,
        string? endereco = null)
    {
        Cpf = cpf;
        Nome = nome;
        Telefone = telefone;
        Email = email;
        Endereco = endereco;
    }
}