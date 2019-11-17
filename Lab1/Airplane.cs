namespace Lab1
{
    public class Airplane
    {
        public string RaceNumber
        {
            get => raceNumber;
            set => raceNumber = value;
        }

        public string AircraftType
        {
            get => aircraftType;
            set => aircraftType = value;
        }

        public string TravelDirection
        {
            get => travelDirection;
            set => travelDirection = value;
        }

        public string DepaturePeriod
        {
            get => depaturePeriod;
            set => depaturePeriod = value;
        }

        private string raceNumber;
        private string aircraftType;
        private string travelDirection;
        private string depaturePeriod;

        public Airplane()
        {
            raceNumber = null;
            aircraftType = null;
            travelDirection = null;
            depaturePeriod = null;
        }

        public Airplane(string raceNumber, string aircraftType, string travelDirection, string depaturePeriod)
        {
            this.raceNumber = raceNumber;
            this.aircraftType = aircraftType;
            this.travelDirection = travelDirection;
            this.depaturePeriod = depaturePeriod;
        }
    }
}