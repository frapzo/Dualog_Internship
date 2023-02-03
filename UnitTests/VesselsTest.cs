using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace VesselsNS{
    public class UnitTest1
    {
        [Fact]
        public void Test_Vessel_is_set_up_correctly()
        {   
            // generate random attributes
            var Random = new Random();
            string Name = "Vessel" + Random.Next(0,10).ToString();
            int YearBuilt = Random.Next(2003,2023);
            double MaxSpeed = Random.Next(10,100);

            // construct ferry
            Vessel vessel = new Vessel(Name, YearBuilt, MaxSpeed);

            // assert 
            Debug.Assert(vessel.GetName() == Name);
            Debug.Assert(vessel.GetMaxSpeed() == MaxSpeed);
            Debug.Assert(vessel.GetYearBuilt() == YearBuilt);
        }

        [Fact]
        public void Test_access_to_passengers()
        {
            Ferry ferry = new Ferry("Ferry", 2005, 10, 1000);
            Debug.Assert(ferry.passengers == 1000);
        }
    }

    [TestClass]
    public class ExceptionTests
    {
        [TestMethod]
        [ExpectedException(typeof(OldShipException))]
        public void Test_Invalid_YearBuilt_on_Vessel()
        {
            Ferry ferry = new Ferry("The Viking", 2002, 10, 1000);
        }

        [TestMethod]
        [ExpectedException(typeof(NameException))]
        public void Test_Invalid_Vessel_Name()
        {
            Tugboat tugboat = new Tugboat("NULL", 2004, 10, 1000);
        }

        [TestMethod]
        [ExpectedException(typeof(FormatException))]
        public void Test_Invalid_Speed_Format()
        {
            Submarine submarine = new Submarine("The Ocean Tiger", 2020, 10, 1000);
            submarine.GetMaxSpeed("MPH");

        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void Test_Invalid_MaxSpeed()
        {
            Vessel submarine = new Vessel("Sailship", 2010, -10);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void Test_Invalid_MaxForce()
        {
            Tugboat tugboat = new Tugboat("Tugboat", 2008, 10, -1000);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void Test_Invalid_maxDepth()
        {
            Submarine submarine = new Submarine("Submarine", 2005, 10, -1000);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void Test_Invalid_Passenger_num()
        {
            Ferry ferry = new Ferry("Ferry", 2005, 10, -1000);
        }
    }
}