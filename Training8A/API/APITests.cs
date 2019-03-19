using System;
using System.IO;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json.Linq;
using RestSharp;

namespace Training8A.API
{
    [TestClass]
    public class APITests
    {
        [TestMethod]
        public void APITestMethod1()
        {
            var client = new RestClient("http://petstore.swagger.io/v2/pet/10");
            var request = new RestRequest(Method.GET);
            request.AddHeader("Postman-Token", "8f7ecc95-630c-4425-bd69-77ae6b63d350");
            request.AddHeader("cache-control", "no-cache");
            request.AddHeader("Content-Type", "application/json");
            IRestResponse response = client.Execute(request);

            string status = response.StatusCode.ToString();
           // string errorMessage = response.ErrorMessage.ToString();
            string isSuccessful = response.IsSuccessful.ToString();

            Assert.AreEqual("OK", status);
           // errorMessage.Should().BeNull();
            isSuccessful.Should().Be("True");
        }
        
    }
}
