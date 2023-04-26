using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KenoGenerator
{
    public interface ISorsolasok
    {
        Dictionary<DateTime, int[]> ReadSorsolas(DateTime startDate, DateTime endDate);
    }
}
