using System;
using System.Collections.Generic;
using System.Linq;

namespace TripJetLagApp
{
    public interface IFileHelper
    {
        string GetLocalFilePath(string filename);
    }
}
