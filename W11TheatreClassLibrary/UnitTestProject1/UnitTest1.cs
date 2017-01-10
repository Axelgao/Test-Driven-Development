using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using W11TheatreClassLibrary;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        Theatre theatre;
        
        [TestInitialize]
        public void MyTestInitialize()
        {
            theatre = new Theatre("Massey", "NorthShore");
        }

        [TestMethod]
        public void TestInitialEmptySeats()
        {
            int expected = 60;
            int actual = theatre.CurrentVacantSeats;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestResetAllSeatsForNewShow()
        {
            theatre.ResetAllSeatsForNewShow();
            int expected = 60;
            int actual = theatre.CurrentVacantSeats;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestBookingOfMoreThan60SeatsMessage()
        {
            string expected= "Sorry, there are only 60 seats";
            string actual = theatre.PleaseBookSeats(61);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestCompletelyVacantIsTrueithIncorrectFirstBooking()
        {
            string incorrectBooking = theatre.PleaseBookSeats(61);
            bool expected = true;
            bool actual = theatre.IsCompletelyVacant;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestBookingOf5Seats()
        {
            string correctBooking = theatre.PleaseBookSeats(5);
            int expected = 55;
            int actual = theatre.CurrentVacantSeats;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestBookingDetailsOf3Seats()
        {
            string correctBooking1 = theatre.PleaseBookSeats(1);
            string actual = theatre.PleaseBookSeats(3);
            string expected = "A2 booked" + Environment.NewLine + "A3 booked" + Environment.NewLine + "A4 booked" + Environment.NewLine;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestCompletelyVacantIsFalseWithCorrectFirstBooking()
        {
            string correctBooking = theatre.PleaseBookSeats(3);
            bool expected = false;
            bool actual = theatre.IsCompletelyVacant;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestBookingMoreSeatsAfterAllSeatsHaveBeenBookedMessage()
        {
            string correctBooking = theatre.PleaseBookSeats(60);
            string expected = "Sorry, there is no seat left";
            string actual = theatre.PleaseBookSeats(3);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestBookingMoreSeatsWhenFewerSeatsAreRemainingMessage()
        {
            string correctBooking = theatre.PleaseBookSeats(59);
            string expected = "Sorry, there are not enough seats";
            string actual = theatre.PleaseBookSeats(3);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestVacantSeatsAfterAllSeatsBooked()
        {
            string correctBooking = theatre.PleaseBookSeats(60);
            int expected = 0;
            int actual = theatre.CurrentVacantSeats;
            Assert.AreEqual(expected, actual);
        }
    }
}
