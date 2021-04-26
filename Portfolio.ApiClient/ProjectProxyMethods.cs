using Newtonsoft.Json;
using Portfolio.Dto;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Portfolio.ApiClient
{
    public static class ProjectProxyMethods
    {
        public static string JsonMediaType { get; } = "application/json";

        public static StringContent ConvertToContent<T>(T data)
        {
            var content = new StringContent(JsonConvert.SerializeObject(data), Encoding.UTF8, JsonMediaType);
            return content;
        }

        public static async Task<List<ProjectDto>> Get()
        {
            using (var client = PortfolioApiClient.Get())
            {
                var response = await client.GetAsync("Project");
                var json = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<List<ProjectDto>>(json);
            }
        }

        public static async Task<List<ProjectDto>> GetById(int Id)
        {
            using (var client = PortfolioApiClient.Get())
            {
                var response = await client.GetAsync("Project/" + Id);
                var json = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<List<ProjectDto>>(json);
            }
        }

        public static async Task<HttpResponseMessage> Add(ProjectDto data)
        {
            using (var client = PortfolioApiClient.Get())
            {
                return await client.PostAsync("Project", ConvertToContent(data));
            }
        }

        public static async Task<HttpResponseMessage> Update(ProjectDto data)
        {
            using (var client = PortfolioApiClient.Get())
            {
                return await client.PutAsync("Project", ConvertToContent(data));
            }
        }

        public static async Task<HttpResponseMessage> Delete(int id)
        {
            using (var client = PortfolioApiClient.Get())
            {
                return await client.DeleteAsync("Project/" + id);
            }
        }
    }
}
