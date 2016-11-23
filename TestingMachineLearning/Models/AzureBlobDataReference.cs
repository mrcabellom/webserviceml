using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingMachineLearning.Models
{
    public class AzureBlobDataReference
    {
        public string ConnectionString { get; set; }

        public string RelativeLocation { get; set; }

        public string BaseLocation { get; set; }

        public string SasBlobToken { get; set; }
    }
}
