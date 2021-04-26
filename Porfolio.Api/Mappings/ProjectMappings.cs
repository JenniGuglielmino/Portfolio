using Porfolio.Api.Model;
using Portfolio.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Porfolio.Api.Mappings
{
    public static class ProjectMappings
    {
        public static List<ProjectDto> ToDto(this List<Project> data)
        {
            var list = data.Select(c => c.ToDto()).ToList();
            return list;
        }

        public static List<Project> FromDto(this List<ProjectDto> data)
        {
            var list = data.Select(c => c.FromDto()).ToList();
            return list;
        }

        public static ProjectDto ToDto(this Project data)
        {
            return new ProjectDto
            {
                Id = data.Id,
                Title = data.Title,
                Description = data.Description,
            };
        }

        public static Project FromDto(this ProjectDto data)
        {
            return new Project
            {
                Id = data.Id,
                Title = data.Title,
                Description = data.Description,
            };
        }

        public static void FromDto(this Project originalData, ProjectDto newData)
        {
            originalData.Id = newData.Id;
            originalData.Title = newData.Title;
            originalData.Description = newData.Description;

        }
    }
}
