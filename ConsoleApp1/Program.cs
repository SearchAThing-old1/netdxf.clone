using netDxf;
using netDxf.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            netDxf.DxfDocument dxf = new netDxf.DxfDocument();

            dxf.AddEntity(new Line(new Vector3(0, 0, 0), new Vector3(100, 50, 0)));

            dxf.Save("test.dxf", isBinary: true);
        }
    }
}
