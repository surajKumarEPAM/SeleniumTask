using Newtonsoft.Json;
using RestSharp;
using System.Collections.Immutable;
using System.Net;
using System.Security.Cryptography.X509Certificates;

namespace PracticingAPIRequestMethods
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void GetRequest()
        {
            RestClient restClient= new RestClient("http://localhost:3000");
            RestRequest restRequest = new RestRequest("Student", Method.Get);
            restRequest.AddQueryParameter("id", 11);
            restRequest.AddHeader("Accept", "*/*");
            RestResponse response = new RestResponse();
            response=restClient.Execute(restRequest);
            string content=response.Content;
            var inJsonForm = JsonConvert.DeserializeObject<DataFormate[]>(content);
            Assert.AreEqual("Ankesh", inJsonForm[0].FirstName);

        }
        [Test]
        public void PostData()
        {
            RestClient restClient = new RestClient("http://localhost:3000");
            RestRequest restRequest = new RestRequest("Student",Method.Post);
            restRequest.AddQueryParameter("id", 117);
            restRequest.AddHeader("Accept", "*/*");
            string data = SetData(22, "Ritesh", "Raushan", 32);
;           restRequest.AddJsonBody(data);
            RestResponse restResponse= new RestResponse();  
            restResponse=restClient.Execute(restRequest);
            string content=restResponse.Content;
            Assert.AreEqual(HttpStatusCode.Created, restResponse.StatusCode);
            var inJsonFormate = JsonConvert.DeserializeObject<DataFormate>(content);
            Assert.AreEqual("Ritesh", inJsonFormate.FirstName);


            
        }
        public string SetData(int id, string firstName, string lastName, int age)
        {
            DataFormate data = new DataFormate();
            data.FirstName = firstName;
            data.LastName = lastName;
            data.Age = age;
            data.id = id;
            string str=JsonConvert.SerializeObject(data);
            return str;
        }
        public string SetAnother(string firstName)
        {
            SecondDemoCLass c= new SecondDemoCLass();   
            c.FirstName = firstName;
            string str=JsonConvert.SerializeObject(c);
            return str;
        }
        [Test]
        public void Putdata()
        {
            RestClient restClient = new RestClient("http://localhost:3000");
            RestRequest restRequest = new RestRequest("Student/22", Method.Put);
            //restRequest.AddQueryParameter("id", 100);
          
            restRequest.AddHeader("Accept", "*/*");
            //string data = SetData(101, "Harsh", "Shwarn", 34);
            // SecondDemoCLass sc=new SecondDemoCLass();
            //sc.FirstName = "RadhaRam";
            string data = SetAnother("RadhaRam");
            
             restRequest.AddJsonBody(data);
            RestResponse restResponse = new RestResponse();
            restResponse = restClient.Execute(restRequest);
            string content = restResponse.Content;
            Assert.AreEqual(HttpStatusCode.OK, restResponse.StatusCode);
            var inJsonFormate = JsonConvert.DeserializeObject<SecondDemoCLass>(content);
            Assert.AreEqual("RadhaRam", inJsonFormate.FirstName);
        }
        [Test]
        public void Patchdata()
        {
            RestClient restClient = new RestClient("http://localhost:3000");
            RestRequest restRequest = new RestRequest("Student/41", Method.Patch);
            //restRequest.AddQueryParameter("id", 100);
            restRequest.AddHeader("Accept", "*/*");
            //string data = SetData(101, "Harsh", "Shwarn", 34);
            string data = SetAnother("Salman");
            restRequest.AddJsonBody(data);
            RestResponse restResponse = new RestResponse();
            restResponse = restClient.Execute(restRequest);
            string content = restResponse.Content;
            Assert.AreEqual(HttpStatusCode.OK, restResponse.StatusCode);
            var inJsonFormate = JsonConvert.DeserializeObject<SecondDemoCLass>(content);
            Assert.AreEqual("Salman", inJsonFormate.FirstName);
        }
        [Test]
        public void Deletedata()
        {
            RestClient restClient = new RestClient("http://localhost:3000");
            RestRequest restRequest = new RestRequest("Student/41", Method.Delete);
            //restRequest.AddQueryParameter("id", 100);
            RestResponse restResponse = new RestResponse();
            restResponse = restClient.Execute(restRequest);
            string content = restResponse.Content;
            Assert.AreEqual(HttpStatusCode.OK, restResponse.StatusCode);
            
        }
    }
}