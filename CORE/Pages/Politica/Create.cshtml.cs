using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CORE.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CORE.Pages.Politica
{
    public class CreateModel : PageModel
    {
        [BindProperty]
        public PoliticaModel descripcion { get; set; }
        public void OnGet()
        {

        }
    }
}