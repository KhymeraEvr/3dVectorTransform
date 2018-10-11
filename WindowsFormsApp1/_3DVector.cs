using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    struct _3DVector
    {

        public _3DVector(double x, double y, double z, double h = 1)
        {
            Cors = new double[4];
            _x = Cors[0] = x;
            _y = Cors[1] = y;
            _z = Cors[2] = z;
            _h = Cors[3] = h;
        }

        public double X
        {
            get => Cors[0];
            set
            {
                _x = value;
                Cors[0] = value;
            }
        }
        public double Y
        {
            get => Cors[1];
            set
            {
                _y = value;
                Cors[1] = value;
            }
        }
        public double Z
        {
            get => Cors[2];
            set
            {
                _z = value;
                Cors[2] = value;
            }
        }
        public double H
        {
            get => Cors[3];
            set
            {
                _h = value;
                Cors[3] = value;
            }
        }
        private double _x;
        private double _y;
        private double _z;
        private double _h;
        public double[] Cors { get; set; }
        public override string ToString()
        {
            return $"[{X} {Y} {Z} {H}]";
        }
    }
}
