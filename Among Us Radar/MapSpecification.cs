using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Among_Us_Radar
{
    public class MapSpecification
    {

        public MapSpecification(int xx, int yy, string pathh)
        {
            X = xx;
            Y = yy;
            path = pathh;
        }
        public int X { get; set; }
        public int Y { get; set; }
        public string path { get; set; }
        public Image ImageLoad()
        {
            string pathRecalculate = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), path);
            Image image = Image.FromFile(pathRecalculate);
            return image;
        }

    }
}
