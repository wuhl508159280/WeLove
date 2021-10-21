using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WeLove.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        public List<string> ShowData;
        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
        public List<string> list = new List<string>();
        public void OnGetSendData(int id)
        {
            ShowData = new List<string>();
            for (int i = 0; i < 5; i++)
            {
                ShowData.Add("" + i);
            }
            list= ShowData;
        }
    }
}
