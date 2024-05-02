using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace URProject.Classes
{
    [Serializable]
    public class UniversalRobot_Outputs
    {
        // public double io_current; // check the fields name in the RTDE guide : MUST be the same with the same type
        public double[] actual_q = new double[6]; // array creation must be done here to give the size
        public double[] actual_TCP_pose = new double[6];
        public UInt32 robot_status_bits;
        public double tool_analog_input0;
        // public int robot_mode;

        // free private & protected attributs are allows
        // all properties and methods also (even public)

    }
}
