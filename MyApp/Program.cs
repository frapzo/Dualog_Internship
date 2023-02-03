namespace VesselsNS
{
    class Program
    {
        static void Main(string[] args)
        {
            var vessels = new ArrayList();
            var Random = new Random();

            // add 3 ferries
            for (int i = 0; i < 3; i++){
                vessels.Add(new Ferry("Ferry" + i.ToString(), 
                                        Random.Next(2003,2023), 
                                        Random.Next(10,100), 
                                        Random.Next(100,1000)));
            }

            // add 3 tugboats
            for (int i = 0; i < 3; i++){
                vessels.Add(new Tugboat("Tugboat" + i.ToString(), 
                                        Random.Next(2003,2023), 
                                        Random.Next(10,100), 
                                        Random.Next(100,1000)));
            }

            // add 3 submarines
            for (int i = 0; i < 3; i++){
                vessels.Add(new Submarine("Submarine" + i.ToString(), 
                                        Random.Next(2003,2023), 
                                        Random.Next(10,100), 
                                        Random.Next(100,1000)));
            }

            // print vessel info of all vessels
            foreach (var vessel in vessels){
                switch(vessel.GetType().Name)
                {
                    case "Ferry":
                        Ferry ferry = (Ferry)vessel;
                        Console.WriteLine("VesselInfo: " + ferry.GetVesselInfo());
                        Console.WriteLine("ToString: " + ferry.ToString());
                        Console.WriteLine("");
                        break;
                    case "Tugboat":
                        Tugboat tugboat = (Tugboat)vessel;
                        Console.WriteLine("VesselInfo: " + tugboat.GetVesselInfo());
                        Console.WriteLine("ToString: " + tugboat.ToString());
                        Console.WriteLine("");
                        break;
                    case "Submarine":
                        Submarine submarine = (Submarine)vessel;
                        Console.WriteLine("VesselInfo: " + submarine.GetVesselInfo());
                        Console.WriteLine("ToString: " + submarine.ToString());
                        Console.WriteLine("");
                        break;
                }
            }
        }
    }
}

