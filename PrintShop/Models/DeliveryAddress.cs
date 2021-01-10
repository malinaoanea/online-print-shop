using System.ComponentModel.DataAnnotations;

namespace PrintShop.Models
{
    public class DeliveryAddress
    {
        public string Id { get; set; }
       
        public string ClientId { get; set; }
        
        public string PhoneNumber { get; set; }
        
        public string City { get; set; }
        
        public string Address { get; set; }
        
        
        [CountyValidation.CountyValidation(ErrorMessage = "Please select a valid county")]
        public  string County { get; set; }
        
        public  string Country { get; set; }
    }
}