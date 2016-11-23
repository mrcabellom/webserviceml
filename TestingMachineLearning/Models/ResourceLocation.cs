using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Azure.Management.DataFactories.Models;
using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Blob;
using Microsoft.Azure.Management.DataFactories.Runtime;

namespace TestingMachineLearning.Models
{
    public class ResourceLocation
    {
        public string Name { get; set; }
        public AzureBlobDataReference Location { get; set; }
    }
}
