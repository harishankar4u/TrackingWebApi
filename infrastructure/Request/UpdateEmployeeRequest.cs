namespace TrackingApi.infrastructure.Request
{
    public class UpdateEmployeeRequest
    {
        public int id { get; set; }
        public string name { get; set; }
        public int age { get; set; }
        public string department { get; set; }
    }
}
