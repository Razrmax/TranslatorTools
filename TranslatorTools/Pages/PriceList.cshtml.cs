using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;

namespace TranslatorTools.Pages
{
    public class PriceListModel : PageModel
    {
        private readonly IConfiguration _configuration;
        public string Message { get; private set; }
        public void OnGet()
        {
            Message = _configuration["Message"];
        }

        public PriceListModel(IConfiguration configuration)
        {
            _configuration = configuration;
        }
    }
}
