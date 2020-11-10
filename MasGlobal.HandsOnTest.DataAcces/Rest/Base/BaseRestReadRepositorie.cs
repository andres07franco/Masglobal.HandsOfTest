namespace MasGlobal.HandsOnTest.DataAcces.Rest.Base
{
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;
    using System.Net.Http;

    public class BaseRestReadRepositorie<TEntity> 
    {
        private readonly HttpClient client;
        private readonly string resourceEndpoint;
        public BaseRestReadRepositorie(string resourceEndpoint)
        {
            this.client = new HttpClient();
            this.resourceEndpoint = resourceEndpoint;
        }

        public List<TEntity> GetList()
        {
            try
            {

                HttpResponseMessage response = client.GetAsync(resourceEndpoint).Result;
                response.EnsureSuccessStatusCode();
                string responseBody = response.Content.ReadAsStringAsync().Result;
                return  JsonConvert.DeserializeObject<List<TEntity>>(responseBody);
            }
            catch (HttpRequestException ex)
            {
                throw ex;
            }
        }


    }
}
