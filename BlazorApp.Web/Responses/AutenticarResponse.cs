namespace BlazorApp.Web.Responses
{
    public class AutenticarResponse
    {
        public string? Id { get; set; }
        public string? Nome { get; set; }
        public string? Email { get; set; }
        public string? AccessToken { get; set; }
        public DateTime DataHoraExpiracao { get; set; }
        public string? Message { get; set; }
    }

}
