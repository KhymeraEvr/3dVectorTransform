using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    namespace _3DVectorTransform
    {
        class TransformMatrix
        {
            public double[,] mat { get; set; }

            public TransformMatrix()
            {

            }

            public void Reset()
            {
                mat = new double[4, 4];
                for (int i = 0; i < 4; i++)
                {
                    mat[i, i] = 1;
                }
            }

            public void Translation(double tX, double tY, double tZ)
            {
                Reset();
                mat[3, 0] = tX;
                mat[3, 1] = tX;
                mat[3, 2] = tX;
            }

            public void Translation(double val)
            {
                Translation(val, val, val);
            }

            public void Scaling(double tX, double tY, double tZ)
            {
                Reset();
                mat[0, 0] = tX;
                mat[1, 1] = tY;
                mat[2, 2] = tZ;
            }

            public void XTurn(double angle)
            {
                angle = angle * Math.PI / 180;
                Reset();
                mat[1, 1] = Math.Cos(angle);
                mat[2, 2] = Math.Cos(angle);
                mat[2, 1] = -Math.Sin(angle);
                mat[1, 2] = Math.Sin(angle);
            }

            public void YTurn(double angle)
            {
                angle = angle * Math.PI / 180;
                Reset();
                mat[0, 0] = Math.Cos(angle);
                mat[2, 2] = Math.Cos(angle);
                mat[0, 2] = -Math.Sin(angle);
                mat[2, 0] = Math.Sin(angle);
            }

            public void ZTurn(double angle)
            {
                angle = angle * Math.PI / 180;
                Reset();
                mat[0, 0] = Math.Cos(angle);
                mat[1, 1] = Math.Cos(angle);
                mat[1, 0] = -Math.Sin(angle);
                mat[0, 1] = Math.Sin(angle);
            }
            public void Scaling(double val)
            {
                Scaling(val, val, val);
            }

            public void ZoYMirror()
            {
                Reset();
                mat[0, 0] = -1;
            }
            public void YoXMirror()
            {
                Reset();
                mat[2, 2] = -1;
            }
            public void XoZMirror()
            {
                Reset();
                mat[1, 1] = -1;
            }

            public void Transform(ref _3DVector item)
            {
                for (int i = 0; i < 4; i++)
                {
                    double sum = 0;
                    for (int j = 0; j < 4; j++)
                    {
                        sum += item.Cors[j] * mat[j, i];
                    }

                    item.Cors[i] = sum;
                }
            }
        }
    }

}
