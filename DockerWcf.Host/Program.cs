using System;
using System.ServiceModel;
using System.Threading;

namespace DockerWcf.Host
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create the ServiceHost.
            using (ServiceHost host = new ServiceHost(typeof(StringService)))
            {

                host.Open();

                Console.WriteLine("The service is ready at {0}", host.BaseAddresses[0]);
                while (true)
                {

                    // Just hang around until the container destroys the service
                    Thread.Sleep(1000);
                }
            }
        }
    }
}
