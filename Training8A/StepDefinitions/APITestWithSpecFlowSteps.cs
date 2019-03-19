using FluentAssertions;
using NUnit.Framework;
using RestSharp;
using System;
using TechTalk.SpecFlow;

namespace Training8A.StepDefinitions
{
    [Binding]
    public class APITestWithSpecFlowSteps
    {
        RestClient client;
        RestRequest request;
        IRestResponse response;

        [Given(@"I have my EndPoint")]
        public void GivenIHaveMyEndPoint()
        {
            client = new RestClient("http://petstore.swagger.io/v2/pet/1");
        }
        
        [Given(@"I sent a ""(.*)""")]
        public void GivenISentA(string p0)
        {
             request = new RestRequest(Method.GET);

        }

        [When(@"I execute the reponse")]
        public void WhenIExecuteTheReponse()
        {
            request.AddHeader("Postman-Token", "50ae8bd4-b118-4db8-90b0-bc304b3b3644");
            request.AddHeader("cache-control", "no-cache");
            request.AddHeader("Content-Type", "application/json");
            response = client.Execute(request);
        }
        
        [Then(@"the response is successful")]
        public void ThenTheResponseIsSuccessful()
        {
            string status = response.StatusCode.ToString();
            // string errorMessage = response.ErrorMessage.ToString();
            string isSuccessful = response.IsSuccessful.ToString();

            Assert.AreEqual("OK", status);
            // errorMessage.Should().BeNull();
            isSuccessful.Should().Be("True");
        }
    }
}
