using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Configuration;
using System.Text;
using System.Text.Json.Nodes;

namespace UI.Services.Base;

public abstract class ServicesBase<TEntity> where TEntity : class
{
    private string _urlAPI = ConfigurationManager.AppSettings["UrlAPI"].ToString();

    public async Task<TEntity> GetAll(string url, string message)
    {
        Uri URI = new Uri(_urlAPI + url);

        using (var client = new HttpClient())
        {
            using (var response = await client.GetAsync(URI))
            {
                if (response.IsSuccessStatusCode)
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
                else
                {
                    MessageBox.Show(message + response.StatusCode);
                }
                return null;
            }
        }
    }

    public async Task<TEntity> GetById(long id, string url, string message)
    {
        Uri URI = new Uri(_urlAPI + url + id);
        using (var client = new HttpClient())
        {
            using (var response = await client.GetAsync(URI))
            {
                if (response.IsSuccessStatusCode)
                {
                    dynamic jsonString = await response.Content.ReadAsStringAsync();
                    var entity = JsonConvert.DeserializeObject<TEntity>(jsonString);
                    return entity;
                }
                else
                {
                    MessageBox.Show(message + response.StatusCode);
                }
                return null;
            }
        }
    }

    public async Task Save(TEntity entity, string url, string message)
    {
        Uri URI = new Uri(_urlAPI + url);
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
                throw new Exception(message + result.ReasonPhrase);
        }
    }

    public async Task Delete(int id, string url, string message)
    {
        Uri URI = new Uri(_urlAPI + url + id);
        using (var client = new HttpClient())
        {
            using (var response = await client.DeleteAsync(URI))
            {
                if (!response.IsSuccessStatusCode)
                {
                    MessageBox.Show(message + response.StatusCode);
                }
            }
        }
    }
}
