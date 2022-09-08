using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Configuration;
using System.Net;
using System.Text;

namespace UnitTest.Services;

public class Service<TEntity> where TEntity : class
{
    public HttpStatusCode Connect(string url)
    {
        Uri URI = new Uri(url);
        using (var client = new HttpClient())
        {
            using (var response = client.GetAsync(URI))
            {
                try
                {
                    return response.Result.StatusCode;
                }
                catch (Exception)
                {
                    return HttpStatusCode.NotFound;
                }
            }
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

    public async Task<HttpStatusCode> Save(TEntity entity, string url)
    {
        Uri URI = new Uri(url);
        using (var client = new HttpClient())
        {
            var serialized = JsonConvert.SerializeObject(entity);
            dynamic stringJson = JObject.Parse(serialized);
            //var values = (JArray)stringJson["Data"];
            //var value = values[0];

            var dataSerialized = JsonConvert.SerializeObject(stringJson);

            var content = new StringContent(dataSerialized, Encoding.UTF8, "application/json");
            var result = await client.PostAsync(URI, content);

            return result.StatusCode;
        }
    }

    public async Task<HttpStatusCode> Update(TEntity entity, string url)
    {
        Uri URI = new Uri(url);
        using (var client = new HttpClient())
        {
            var serialized = JsonConvert.SerializeObject(entity);
            dynamic stringJson = JObject.Parse(serialized);
            //var values = (JArray)stringJson["Data"];
            //var value = values[0];

            var dataSerialized = JsonConvert.SerializeObject(stringJson);

            var content = new StringContent(dataSerialized, Encoding.UTF8, "application/json");
            var result = await client.PutAsync(URI, content);

            return result.StatusCode;
        }
    }

    public async Task<HttpStatusCode> Delete(string url)
    {
        Uri URI = new Uri(url);
        using (var client = new HttpClient())
        {
            using (var response = await client.DeleteAsync(URI))
            {
                var result = await client.DeleteAsync(URI);

                return result.StatusCode;
            }
        }
    }
}
