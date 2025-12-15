using System;
using System.Collections.Generic;
using System.Text;

namespace Test_Enum_Traffic_Light
{
    internal class TrafficLight
    {
        public enum LightColor
        {
            RED,
            YELLOW,
            GREEN
        }

        public string action;

        public TrafficLight(string action)
        {
            this.action = action;
        }

        public string getAction()
        {
            return action;
        }

        public LightColor getColor()
        {
            switch (action)
            {
                case "Stop":
                    return LightColor.RED;
                case "Wait":
                    return LightColor.YELLOW;
                case "Go":
                    return LightColor.GREEN;
                default:
                    return LightColor.RED;
            }
        }
    }
}
