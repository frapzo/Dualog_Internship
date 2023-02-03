using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace VesselsNS{
    public class UnitTest1
    {
        [Fact]
        public void Test_Ferry_is_set_up_correctly()
        {   
            // generate random attributes
            var Random = new Random();
            string Name = "Ferry" + Random.Next(0,10).ToString();
            int YearBuilt = Random.Next(2003,2023);
            double MaxSpeed = Random.Next(10,100);
            int Passengers = Random.Next(500,5000); 

            // construct ferry
            Ferry ferry = new Ferry(Name, YearBuilt, MaxSpeed, Passengers);

            // assert 
            Debug.Assert(ferry.GetName() == Name);
            Debug.Assert(ferry.GetMaxSpeed() == MaxSpeed);
            Debug.Assert(ferry.GetYearBuilt() == YearBuilt);
        }
    }

    [TestClass]
    public class UnitTesting
    {
        [TestMethod]
        [ExpectedException(typeof(OldShipException))]
        public void Test_Invalid_YearBuilt_of_Vessel()
        {
            Ferry ferry = new Ferry("Ferry", 2002, 10, 1000);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void Test_Invalid_Vessel_Name()
        {
            Ferry ferry = new Ferry("NULL", 2004, 10, 1000);
        }
    }
}