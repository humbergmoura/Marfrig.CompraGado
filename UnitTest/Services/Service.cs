using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Configuration;
using System.Text;

namespace UnitTest.Services;

public class Service<TEntity> where TEntity : class
{
    public async Task<bool> Connect(string url)
    {
        Uri URI = new Uri(url);
        using (var client = new HttpClient())
        {
            using (var response = await client.GetAsync(URI))
            {
                return response.IsSuccessStatusCode;
            }
            throw new Exception();
        }
    }

    public async Task<TEntity> GetAll(string url)
    {
        Uri URI = new Uri(url);

        using (var client = new HttpClient())
        {
            using (var response = await client.GetAsync(URI))
            {
                var jsonString = await response.Content.ReadAsStringAsync();
                dynamic stringJson = JObject.Parse(jsonString);

                if (stringJson == null)
                {
                    return null;
                }

                var listEntity = JsonConvert.DeserializeObject<TEntity>(stringJson.ToString());
                return listEntity;
            }
        }
    }

    public async Task<TEntity> GetById(string url)
    {
        Uri URI = new Uri(url);
        using (var client = new HttpClient())
        {
            using (var response = await client.GetAsync(URI))
            {
                dynamic jsonString = await response.Content.ReadAsStringAsync();
                var entity = JsonConvert.DeserializeObject<TEntity>(jsonString);
                return entity;
            }
        }
    }

    public async Task Save(TEntity entity, string url)
    {
        Uri URI = new Uri(url);
        using (var client = new HttpClient())
        {
            var serialized = JsonConvert.SerializeObject(entity);
            dynamic stringJson = JObject.Parse(serialized);
            var values = (JArray)stringJson["Data"];
            var value = values[0];

            var dataSerialized = JsonConvert.SerializeObject(value);

            var content = new StringContent(dataSerialized, Encoding.UTF8, "application/json");
            var result = await client.PostAsync(URI, content);

            if (!result.IsSuccessStatusCode)
                throw new Exception(result.ReasonPhrase);
        }
    }

    public async Task Delete(string url)
    {
        Uri URI = new Uri(url);
        using (var client = new HttpClient())
        {
            using (var response = await client.DeleteAsync(URI))
            {
                if (!response.IsSuccessStatusCode)
                {
                }
            }
        }
    }
}
