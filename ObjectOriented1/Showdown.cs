using System;
namespace ObjectOriented1
{
    public class Showdown
    {
        Track _track;
        int _prize;
        int _laps;
        int _numOfCompetiros;
        Vehicle[] _vehicles;
        float[] _results;

        public Showdown(Track track, int prize, int laps, Vehicle[] vehicles)
        {
            _track = track;
            _prize = prize;
            _laps = laps;
            _numOfCompetiros = vehicles.Length;
            _vehicles = vehicles;
        }

        public override string ToString()
        {
            string vehicles_str = "";
            foreach (var vehicle in _vehicles)
            {
                vehicles_str += $"Formula Car: {vehicle}\n";
            }
            return $"track: {_track}, prize: {_prize}, laps: {_laps}, num of competitors {_numOfCompetiros}\n" +
                $"vehicles:\n" + vehicles_str;

        }

        public void StartRace()
        {
            //showdown length
            int length = _track.LapLength() * _laps;

            _results = new float[_numOfCompetiros];
            //ties replacments time

            //Time!
            Random rand = new Random();
            int index = 0;
            foreach (var vehicle in _vehicles)
            {
                int maxSpeed = vehicle.MaxSpeed();
                int avgSpeed = rand.Next((int)(maxSpeed * 0.7), maxSpeed);
                _results[index++] = length / avgSpeed;
            }

        }

        public void PrintResults()
        {

            for (int i = 0; i < _vehicles.Length; i++)
            {
                Console.WriteLine($"Vehicles: {_vehicles[i]}, Result: {_results[i]}");
            }
        }
    }
}
