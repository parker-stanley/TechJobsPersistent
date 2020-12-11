using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.Rendering;
using TechJobsPersistent.Models;


namespace TechJobsPersistent.ViewModels
{
    public class AddJobViewModel
    {

        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; }

        public int EmployerId { get; set; }

        [Required(ErrorMessage = "Employer is required")]
        public Employer Employer { get; set; }

        public List<SelectListItem> Employers { get; set; }

        public AddJobViewModel(List<Employer> employers)
        {
            Employers = new List<SelectListItem>();

            foreach (Employer employer in employers)
            {
                Employers.Add(new SelectListItem
                {
                    Value = employer.Id.ToString(),
                    Text = employer.Name
                });

                //Employers.Add(new SelectListItem(employer.Name.ToString(), ((int)employer.Id).ToString()));
            }
        }

        public Skill Skill { get; set; }

        public List<SelectListItem> Skills { get; set; }

        public AddJobViewModel(List<Skill> skills)
        {
            Skills = new List<SelectListItem>();

            foreach (var skill in skills)
            {
                Employers.Add(new SelectListItem
                {
                    Value = skill.Id.ToString(),
                    Text = skill.Name
                });
            }
        }

        public AddJobViewModel() { }

    }
}
