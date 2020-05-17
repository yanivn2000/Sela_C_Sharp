using System;
namespace ObjectOriented1
{
    public class Track
    {
        Address _address;
        int _lapLength;
        int _numOfTurns;
        string _courseType;
        int _fansSeats;
        int _lanes;

        public int LapLength() { return _lapLength; }
        public Track(Address address, int lapLength, int numOfTurns, string courseType, int fansSeats, int lanes)
        {
            _address = address;
            _lapLength = lapLength;
            _numOfTurns = numOfTurns;
            _courseType = courseType;
            _fansSeats = fansSeats;
            _lanes = lanes;
        }

        public override string ToString()
        {
            return $"address: {_address}, " +
                $"lapLength: {_lapLength}, " +
                $"numOfTurns: {_numOfTurns}, " +
                $"courseType: {_courseType}, " +
                $"fansSeats: {_fansSeats}, " +
                $"lanes: {_lanes}";
        }
    }
}
