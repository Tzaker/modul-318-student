namespace SwissTransport
{
    public interface ITransport
    {
        Stations GetStations(string query);
        StationBoardRoot GetStationBoard(string station, string datetime);
        Connections GetConnections(string fromStation, string toStattion, string date, string time);
    }
}