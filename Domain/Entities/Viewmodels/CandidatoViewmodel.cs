using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.Viewmodels
{
    public class CandidatoViewmodel
    {
        public int Id { get; set; }

            [Display(Name = "Nome")]
            public string Nome { get; set; }

            [Required]
            [Display(Name = "Competencias")]
            public string Competencias { get; set; }

            public IEnumerable<SelectListItem> Vagas { get; set; }
    }
}
