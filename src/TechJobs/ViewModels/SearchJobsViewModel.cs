using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using TechJobs.Models;

namespace TechJobs.ViewModels
{
    public class SearchJobsViewModel : BaseViewModel 
    {
        // TODO #7.1 - Extract members common to JobFieldsViewModel
        // to BaseViewModel

        // The search results
        public List<Job> Jobs { get; set; }

        // The search value
        private string inputValue = "";
        [Display(Name = "Keyword:")]
        public string Value
        {
            get { return inputValue; }
            set
            {
                if (value != null) { inputValue = value; }
            }
        }

        //public SearchJobsViewModel() 
        //{

        //}
    }
}
