using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MyFamilyApp.Data;

namespace Demo.ASPCoreNet
{
    public class FamilyDetailsModel : PageModel
    {
        private readonly IFamilyService _familyService;

        public Family Family { get; set; }
        public List<Person> People { get; set; } = new List<Person>();

        public FamilyDetailsModel(IFamilyService familyService)
        {
            _familyService = familyService;
        }

        public IActionResult OnGet(int familyId)
        {
            Family = _familyService.GetFamilyById(familyId);

            People = _familyService.GetAllFamilyMembers(familyId);

            if (Family == null)
            {
                return RedirectToPage("./NotFound");
            }
            return Page();
        }
    }
}