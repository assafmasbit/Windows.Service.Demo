using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algomizer.Common.Logging
{
    public interface ILogManager
    {
        ILogger Get(string name);
    }
}
