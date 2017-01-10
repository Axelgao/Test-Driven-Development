using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace W11TheatreClassLibrary
{
    public class Seat
    {
        private bool _isVacant;
        private char _rowNumber;
        private int _seatNumber;

        public Seat(char myRowNumber, int mySeatNumber)
        {
            _rowNumber = myRowNumber;
            _seatNumber = mySeatNumber;
            _isVacant = true;
        }

        public bool IsVacant
        {
            get
            {
                return _isVacant;
            }

            set
            {
                _isVacant = value;
            }
        }

        public char RowNumber
        {
            get
            {
                return _rowNumber;
            }

            set
            {
                _rowNumber = value;
            }
        }

        public int SeatNumber
        {
            get
            {
                return _seatNumber;
            }

            set
            {
                _seatNumber = value;
            }
        }
    }
}