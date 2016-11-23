using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingMachineLearning
{
    public class ScoreRequest
    {
        public object ColumnsParameters { get; private set; }

        public ScoreRequest()
        {
            ColumnsParameters = new
            {
                Inputs = new Dictionary<string, List<Dictionary<string, string>>>() {
                        {
                            "input1",
                            new List<Dictionary<string, string>>(){new Dictionary<string, string>(){
                                    {
                                        "symboling", "3"
                                    },
                                    {
                                        "normalized-losses", "1"
                                    },
                                    {
                                        "make", "alfa-romeo"
                                    },
                                    {
                                        "fuel-type", "gas"
                                    },
                                    {
                                        "aspiration", "std"
                                    },
                                    {
                                        "num-of-doors", "two"
                                    },
                                    {
                                        "body-style", "convertible"
                                    },
                                    {
                                        "drive-wheels", "rwd"
                                    },
                                    {
                                        "engine-location", "front"
                                    },
                                    {
                                        "wheel-base", "88.6"
                                    },
                                    {
                                        "length", "168.8"
                                    },
                                    {
                                        "width", "64.1"
                                    },
                                    {
                                        "height", "48.8"
                                    },
                                    {
                                        "curb-weight", "2548"
                                    },
                                    {
                                        "engine-type", "dohc"
                                    },
                                    {
                                        "num-of-cylinders", "four"
                                    },
                                    {
                                        "engine-size", "130"
                                    },
                                    {
                                        "fuel-system", "mpfi"
                                    },
                                    {
                                        "bore", "3.47"
                                    },
                                    {
                                        "stroke", "2.68"
                                    },
                                    {
                                        "compression-ratio", "9"
                                    },
                                    {
                                        "horsepower", "111"
                                    },
                                    {
                                        "peak-rpm", "5000"
                                    },
                                    {
                                        "city-mpg", "21"
                                    },
                                    {
                                        "highway-mpg", "27"
                                    },
                                    {
                                        "price", "1"
                                    }
                                }
                            }
                        },
                    },
                GlobalParameters = new Dictionary<string, string>()
                {
                }
            };
        }
    }
}