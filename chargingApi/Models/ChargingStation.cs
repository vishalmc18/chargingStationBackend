namespace chargingApi.Models
{
    public class ChargingStation
    {
        public int Id { get; set; } 
        public string StationName { get; set; }
        public string LocationAddress { get; set; }
        public string PinCode { get; set; }
        public string ConnectorType { get; set; }
        public string Status { get; set; } 
        public string ImageUrl { get; set; }
        public string LocationLink { get; set; }
    }
}
