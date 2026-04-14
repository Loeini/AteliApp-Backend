namespace AteliApp.Application.DTOs;

public class CriarClienteDto
{
    public string Cpf { get; }
    public string Nome { get; }
    public string? Telefone { get; }
    public string? Email { get; }
    public string? Endereco { get; }

    public CriarClienteDto(
        string cpf,
        string nome,
        string? telefone,
        string? email,
        string? endereco)
    {
        Cpf = cpf;
        Nome = nome;
        Telefone = telefone;
        Email = email;
        Endereco = endereco;
    }
}