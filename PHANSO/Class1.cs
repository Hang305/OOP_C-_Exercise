using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PHANSO
{
    class phanso
    {
        protected int Mau, Tu;
        //public PhanSo(int mau, int tu)
        //{
        //    this.Tu = tu;
        //    this.Mau = mau;
        //}


        private int UCLN(int a, int b)
        {

            if (a != 0)
            {
                if (a > 0)
                {
                    while (a != b)
                    {
                        if (a > b) a -= b;
                        else b -= a;
                    }
                    return a;
                }
                else
                {
                    a = -a;
                    while (a != b)
                    {
                        if (a > b) a -= b;
                        else b -= a;
                    }
                    return a;
                }
            }
            else return 0;

        }
        public void rutGon()
        {
            int a = UCLN(this.Tu, this.Mau);

            if (a != 0)
            {
                if (a > 0)
                {
                    this.Tu = this.Tu / a;
                    this.Mau = this.Mau / a;
                }
                else
                {
                    this.Tu = this.Tu / (-a);
                    this.Mau = this.Mau / (a);
                }
            }

        }
    }
}
