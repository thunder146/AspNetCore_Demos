using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MyFamilyApp.Data;

namespace Demo.ASPCoreNet
{
    public class PersonDetailsModel : PageModel
    {
        private readonly IFamilyService _familyService;

        public Person Person { get; set; }

        public PersonDetailsModel(IFamilyService familyService)
        {
            _familyService = familyService;
        }

        public IActionResult OnGet(int personId)
        {
            Person = _familyService.GetPersonById(personId);

            if (Person == null)
            {
                return RedirectToPage("./NotFound");
            }
            return Page();
        }

    }
}