using Api.Reports.Repositories.IRepository;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace Api.Reports.Repositories.Repository
{
    public class Service : IService
    {
        public string Get(string url)
        {
            var client = new RestSharp.RestClient("https://localhost:44369/api");
            client.Proxy = new WebProxy();
            var request = new RestRequest(url, Method.GET);
            IRestResponse response = client.Execute(request);
            return response.Content;
        }
    }
}
