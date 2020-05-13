using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MyFamilyApp.Data;

namespace Demo.ASPCoreNet
{
    public class FamiliesSummaryModel : PageModel
    {
        private readonly IFamilyService _familyService;

        public IEnumerable<Family> Families { get; private set; }

        public FamiliesSummaryModel(IFamilyService familyService)
        {
            _familyService = familyService;
        }

        public void OnGet()
        {
            Families = _familyService.GetFamilies();
        }
    }
}