//file name: Experiments.cs

using Glovebox.Components.Actuators;
using Glovebox.IO.Components.Sensors;
using Glovebox.IoT;
using System;
using System.Threading;

namespace MakerDen
{
    public class Experiments : IoTServices
    {
        const double LIGHT_THRESHOLD = 60d;
        //HMC5883 magneto = new HMC5883(Timeout.Infinite, "compass");

        public Experiments() :
            base("Replace with your name")
        { }

        public void Main()
        {
            #region paste the code snippet in between the #region and #endregion tags


            while (true)
            {
                Welcome();
            }

            #endregion
        }



    }
}
