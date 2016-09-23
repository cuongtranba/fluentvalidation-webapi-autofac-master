namespace Sample.Web.Models
{
    public class ErrorModel
    {
        public bool success { get; set; }
        public string error_code { get; set; }
        public string message { get; set; }

        public ErrorModel()
        {
            
        }
    }



}