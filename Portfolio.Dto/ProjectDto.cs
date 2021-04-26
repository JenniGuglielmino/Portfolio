using System;

namespace Portfolio.Dto
{
    public class ProjectDto
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Base64Image { get; set; }
        public string Link { get; set; }
    }
}
