using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Headers;

namespace ConsoleApp_testAPI.Models
{
    class DemoApiModel
    {
        private string BASE_URL = "http://localhost:63385/api/demo/";

        public Task<HttpResponseMessage> Demo1()
        {
            try
            {
                HttpClient httpClient = new HttpClient();
                httpClient.BaseAddress = new Uri(BASE_URL);
                httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("text/plain"));
                return httpClient.GetAsync("demo1");
            }
            catch (Exception)
            {

                return null;
            }
        }

        public Task<HttpResponseMessage> Demo2()
        {
            try
            {
                HttpClient httpClient = new HttpClient();
                httpClient.BaseAddress = new Uri(BASE_URL);
                httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("text/html"));
                return httpClient.GetAsync("demo2");
            }
            catch (Exception)
            {

                return null;
            }
        }

        public Task<HttpResponseMessage> Demo3(string fullname)
        {
            try
            {
                HttpClient httpClient = new HttpClient();
                httpClient.BaseAddress = new Uri(BASE_URL);
                httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("text/plain"));
                return httpClient.GetAsync("demo3/" + fullname);
            }
            catch (Exception)
            {

                return null;
            }
        }

        public Task<HttpResponseMessage> Demo4()
        {
            try
            {
                HttpClient httpClient = new HttpClient();
                httpClient.BaseAddress = new Uri(BASE_URL);
                httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                return httpClient.GetAsync("demo4");
            }
            catch (Exception)
            {

                return null;
            }
        }

        public Task<HttpResponseMessage> Demo5()
        {
            try
            {
                HttpClient httpClient = new HttpClient();
                httpClient.BaseAddress = new Uri(BASE_URL);
                httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                return httpClient.GetAsync("demo5");
            }
            catch (Exception)
            {

                return null;
            }
        }

        public Task<HttpResponseMessage> Demo6()
        {
            try
            {
                HttpClient httpClient = new HttpClient();
                httpClient.BaseAddress = new Uri(BASE_URL);
                httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                return httpClient.GetAsync("demo6");
            }
            catch (Exception)
            {

                return null;
            }
        }

        public Task<HttpResponseMessage> Demo7(Product product)
        {
            try
            {
                HttpClient httpClient = new HttpClient();
                httpClient.BaseAddress = new Uri(BASE_URL);
                httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                return httpClient.PostAsJsonAsync("demo7", product);
            }
            catch (Exception)
            {

                return null;
            }
        }
    }
}
