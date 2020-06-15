using ConsoleApp_testAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;



namespace ConsoleApp_testAPI
{
    class Program
    {
        //test webapplication_server
        static void Main(string[] args)
        {
            Demo7();
            Console.ReadLine();
        }

        static void Demo1()
        {
            var demoApiModel = new DemoApiModel();
            HttpResponseMessage responseMessage = demoApiModel.Demo1().Result;
            Console.WriteLine("Status code " + responseMessage.StatusCode.ToString());
            Console.WriteLine("IsSuccessStatusCode: " + responseMessage.IsSuccessStatusCode);
            var result = responseMessage.Content.ReadAsStringAsync().Result;
            Console.WriteLine(result);
        }

        static void Demo2()
        {
            var demoApiModel = new DemoApiModel();
            HttpResponseMessage responseMessage = demoApiModel.Demo2().Result;
            Console.WriteLine("Status code " + responseMessage.StatusCode.ToString());
            Console.WriteLine("IsSuccessStatusCode: " + responseMessage.IsSuccessStatusCode);
            var result = responseMessage.Content.ReadAsStringAsync().Result;
            Console.WriteLine(result);
        }

        static void Demo3()
        {
            var demoApiModel = new DemoApiModel();
            HttpResponseMessage responseMessage = demoApiModel.Demo3("dasda").Result;
            Console.WriteLine("Status code " + responseMessage.StatusCode.ToString());
            Console.WriteLine("IsSuccessStatusCode: " + responseMessage.IsSuccessStatusCode);
            var result = responseMessage.Content.ReadAsStringAsync().Result;
            Console.WriteLine(result);
        }

        static void Demo4()
        {
            var demoApiModel = new DemoApiModel();
            HttpResponseMessage responseMessage = demoApiModel.Demo4().Result;
            Console.WriteLine("Status code " + responseMessage.StatusCode.ToString());
            Console.WriteLine("IsSuccessStatusCode: " + responseMessage.IsSuccessStatusCode);
            var result = responseMessage.Content.ReadAsAsync<Product>().Result;
            Console.WriteLine("Product Info " );
            Console.WriteLine("Id " + result.Id);
            Console.WriteLine("name " + result.Name);
        }

        static void Demo5()
        {
            var demoApiModel = new DemoApiModel();
            HttpResponseMessage responseMessage = demoApiModel.Demo5().Result;
            Console.WriteLine("Status code " + responseMessage.StatusCode.ToString());
            Console.WriteLine("IsSuccessStatusCode: " + responseMessage.IsSuccessStatusCode);
            var results = responseMessage.Content.ReadAsAsync<List<Product>>().Result;
            foreach (var result in results)
            {
                Console.WriteLine("Product Info ");
                Console.WriteLine("Id " + result.Id);
                Console.WriteLine("name " + result.Name);
            }

        }

        static void Demo6()
        {
            var demoApiModel = new DemoApiModel();
            HttpResponseMessage responseMessage = demoApiModel.Demo6().Result;
            Console.WriteLine("Status code " + responseMessage.StatusCode.ToString());
            Console.WriteLine("IsSuccessStatusCode: " + responseMessage.IsSuccessStatusCode);
            var results = responseMessage.Content.ReadAsAsync<List<Product>>().Result;
            foreach (var result in results)
            {
                Console.WriteLine("Product Info ");
                Console.WriteLine("Id " + result.Id);
                Console.WriteLine("name " + result.Name);
            }
        }

        static void Demo7()
        {
            var product = new Product
            {
                Id = "asd",
                Name = "asda",
                Price = 9999,
                Status = false,
                Quantity = 100,
            };

            var demoApiModel = new DemoApiModel();
            HttpResponseMessage responseMessage = demoApiModel.Demo7(product).Result;
            Console.WriteLine("Status code " + responseMessage.StatusCode.ToString());
            Console.WriteLine("IsSuccessStatusCode: " + responseMessage.IsSuccessStatusCode);
            var newProduct = responseMessage.Content.ReadAsAsync<Product>().Result;
            Console.WriteLine("Product Info ");
            Console.WriteLine("Id " + newProduct.Id);
            Console.WriteLine("name " + newProduct.Name);
        }
    }
}
