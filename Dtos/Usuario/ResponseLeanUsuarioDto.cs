namespace gs_server.Dtos.Usuarios;

public class ResponseLeanUsuarioDto
{
  public int Id { get; init; }
  public required string Email { get; set; }
  public required string Nome { get; set; }
}