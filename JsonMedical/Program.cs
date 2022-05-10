using System.Diagnostics;
using System.IO;
using Newtonsoft.Json;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var response = WebResponseMocked();

            Debug.WriteLine($"    Status: {response.Status}");
            Debug.WriteLine($"Assessment: {response.Assessment}");

            foreach (var medicalEvent in response.Assessment.MedicalEvent)
            {
                
                Debug.WriteLine($"\tEvent date: {medicalEvent.EventDate}");

                foreach (var service in medicalEvent.Service)
                {
                    Debug.WriteLine($"\t\tassessmentCode: {service.AssessmentCode,-30}{service.Amount,-10}{service.Number,-5}{service.id}");
                    
                    Debug.WriteLine($"\t\t\tCode:{service.ErrorItem.Code,-5}, Reason: {service.ErrorItem.Reason}");
                }

                Debug.WriteLine("");
            }

        }

        private static PCIResponse WebResponseMocked()
        {
            var response = JsonConvert.DeserializeObject<PCIResponse>(File.ReadAllText("response.json"));
            return response;
        }
    }

    public class PCIResponse
    {
        [JsonProperty("claimAssessment")]
        public Claimassessment Assessment { get; set; }
        [JsonProperty("status")]
        public string Status { get; set; }
    }

    public class Claimassessment
    {
        [JsonProperty("medicalEvent")]
        public Medicalevent[] MedicalEvent { get; set; }
        public string claimId { get; set; }
    }

    
    public class Medicalevent
    {
        [JsonProperty("service")]
        public Service[] Service { get; set; }
        [JsonProperty("eventDate")]
        public string EventDate { get; set; }
        public string id { get; set; }
    }

    public class Service
    {
        [JsonProperty("error")]
        public Error ErrorItem { get; set; }
        public string id { get; set; }
        [JsonProperty("assessmentCode")]
        public string AssessmentCode { get; set; }
        [JsonProperty("chargeAmount")]
        public string Amount { get; set; }
        [JsonProperty("itemNumber")]
        public string Number { get; set; }
    }

    public class Error
    {
        [JsonProperty("code")]
        public int Code { get; set; }
        [JsonProperty("text")]
        public string Reason { get; set; }
    }
}
