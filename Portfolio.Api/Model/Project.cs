using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Porfolio.Api.Model
{
    public class Project
    {
        [Key]
        public int Id { get; set; } 
        public string Title { get; set; }
        public string Description { get; set; }
        public string Base64Image { get; set; }
        public string Link { get; set; }
        public string LinkTitle { get; set; }

    }
}
