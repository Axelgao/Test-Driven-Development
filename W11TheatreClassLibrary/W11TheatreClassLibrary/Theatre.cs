using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W11TheatreClassLibrary
{
    public class Theatre
    {
        private bool _completelyVacant;
        private int _currentVacantSeats;
        private string _lastBookedSeatDetails;
        private string _theatreAddress;
        private string _theatreName;
        private int _totalSeatsinTheatre;
        private Seat[,] _seats;

        public int CurrentVacantSeats
        {
            get
            {
                return _currentVacantSeats;
            }
        }

        public string DetailsofLastBooking
        {
            get
            {
                return _lastBookedSeatDetails;
            }
        }

        public bool IsCompletelyVacant
        {
            get
            {
                return _completelyVacant;
            }
        }

        public string TheatreAddress
        {
            get
            {
                return _theatreAddress;
            }
        }

        public string TheatreName
        {
            get
            {
                return _theatreName;
            }
        }

        public string PleaseBookSeats(int NumOfSeats)
        {
            if (NumOfSeats > 60)
            {
                return "Sorry, there are only 60 seats";
            }
            else if (_currentVacantSeats == 0)
            {
                return "Sorry, there is no seat left";
            }
            else if (NumOfSeats > _currentVacantSeats)
            {
                return "Sorry, there are not enough seats";
            }
            else
            {
                _currentVacantSeats -= NumOfSeats;
                _lastBookedSeatDetails = "";
                foreach (Seat s in _seats)
                {
                    if (NumOfSeats == 0)
                    {
                        break;
                    }
                    else
                    {
                        if (s.IsVacant == true)
                        {
                            _lastBookedSeatDetails += s.RowNumber.ToString() + s.SeatNumber.ToString() + " booked"+Environment.NewLine;
                            NumOfSeats -= 1;
                            s.IsVacant = false;
                        }
                    }
                }
                _completelyVacant = false;
                return _lastBookedSeatDetails;
            }
        }

        public void ResetAllSeatsForNewShow()
        {
            InitializeSeats();
        }

        public Theatre(string myName, string myAddress)
        {
            _theatreName = myName;
            _theatreAddress = myAddress;
            InitializeSeats();
        }

        private void InitializeSeats()
        {
            _seats = new Seat[,] {
{ new Seat('A', 1), new Seat('A', 2), new Seat('A', 3), new Seat('A', 4), new Seat('A', 5), new Seat('A', 6), new Seat('A', 7), new Seat('A', 8), new Seat('A', 9), new Seat('A', 10)},
{new Seat('B', 1), new Seat('B', 2), new Seat('B', 3), new Seat('B', 4), new Seat('B', 5), new Seat('B', 6), new Seat('B', 7), new Seat('B', 8), new Seat('B', 9), new Seat('B', 10)},
{new Seat('C', 1), new Seat('C', 2), new Seat('C', 3), new Seat('C', 4), new Seat('C', 5), new Seat('C', 6), new Seat('C', 7), new Seat('C', 8), new Seat('C', 9), new Seat('C', 10)},
{new Seat('D', 1), new Seat('D', 2), new Seat('D', 3), new Seat('D', 4), new Seat('D', 5), new Seat('D', 6), new Seat('D', 7), new Seat('D', 8), new Seat('D', 9), new Seat('D', 10)},
{new Seat('E', 1), new Seat('E', 2), new Seat('E', 3), new Seat('E', 4), new Seat('E', 5), new Seat('E', 6), new Seat('E', 7), new Seat('E', 8), new Seat('E', 9), new Seat('E', 10)},
{new Seat('F', 1), new Seat('F', 2), new Seat('F', 3), new Seat('F', 4), new Seat('F', 5), new Seat('F', 6), new Seat('F', 7), new Seat('F', 8), new Seat('F', 9), new Seat('F', 10)}
};
            _currentVacantSeats = 60;
            _totalSeatsinTheatre = 60;
            _completelyVacant = true;
        }
    }
}
