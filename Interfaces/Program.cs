using System;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            var build = new DbBuilder("csn_dba", new FileLogger());
            build.Create();
        }
    }
}
