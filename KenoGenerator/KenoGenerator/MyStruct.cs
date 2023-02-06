using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KenoGenerator
{
    public struct MyStruct : IAsyncDisposable
    {
        public int x;
        public int y;

        public ValueTask DisposeAsync()
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return "Valami jo";
        }
    }
}
