using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solar
{
    public class Planets : IDisposable
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double M { get; set; }
        public double R { get; set; }
        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
