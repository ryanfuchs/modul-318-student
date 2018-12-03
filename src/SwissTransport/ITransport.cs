using System;

namespace SwissTransport
{
    public interface ITransport
    {
        Stations GetStations(string query);
        StationBoardRoot GetStationBoard(string id);
        Connections GetConnections(string fromStation, string toStattion, DateTime thisTime, DateTime thisDate);
    }
}