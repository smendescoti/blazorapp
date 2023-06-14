namespace BlazorApp.Web.Responses
{
    public class CriarUsuarioResponse
    {
        public string? Id { get; set; }
        public string? Nome { get; set; }
        public string? Email { get; set; }
        public DateTime? DataHoraCriacao { get; set; }
        public string? Message { get; set; }
    }
}
