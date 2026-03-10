using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApplication2.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        public string? env_deploy { get; set; }

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;

            string? valeur = Environment.GetEnvironmentVariable("ENVIRONMENT_DEPLOYEMENT");
            env_deploy = valeur;
        }

        public void OnGet()
        {
        }
    }
}
