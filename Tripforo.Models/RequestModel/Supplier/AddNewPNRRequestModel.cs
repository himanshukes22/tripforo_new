namespace Tripforo.Models.RequestModel.Supplier
{
    public class AddNewPNRRequestModel
    {

        // selecting trip type ONE WAY or ROUND TRIP
        public string Triptype { get; set; }
        public string OrgDestFrom { get; set; }
        public string OrgDestTo { get; set; }
        public string AirLineName { get; set; }
        public string FlightNo { get; set; }
        public string DepartureDate { get; set; }
        public string ArrivalDate { get; set; }
        public string DepartureTime { get; set; }
        public string ArrivalTime { get; set; }
        public string DepartureTerminal { get; set; }
        public string ArrivalTerminal { get; set; }
        public string FareBasis { get; set; }
        public string FareDet { get; set; }
        public string BagInfo { get; set; }
        public string ClassType { get; set; }
        public string FareRule { get; set; }

        //Round Trip Model

        public string RtAirLineName { get; set; }
        public string RtFlightNo { get; set; }
        public string RtDepartureDate { get; set; }
        public string RtDepartureTime { get; set; }
        public string RtArrivalDate { get; set; }
        public string RtArrivalTime { get; set; }
        public string RtDepartureTerminal { get; set; }
        public string RtArrivalTerminal { get; set; }
        public string RtRbd { get; set; }
        public string RtFareBasis { get; set; }
        public string RtClassType { get; set; }

    }
}
