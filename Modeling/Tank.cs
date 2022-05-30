using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modeling.Blocks;

namespace Modeling
{
    class Tank
    {
        public ComplexBlock Block1;
        public ComplexBlock Block2;

        private GainBlock kx11;
        private GainBlock kx12;
        private GainBlock kx21;
        private GainBlock kx22;
        private GainBlock kx23;

        private LimitBlock xLimit;

        public double y1;
        public double y2;

        private double dt = 0.1;

        public Tank(double dt)
        {
            this.dt = dt;
            kx11 = new GainBlock(2); //3039.1
            kx12 = new GainBlock(0.2); //0.6131
            kx21 = new GainBlock(1); //609.2753
            kx22 = new GainBlock(-0.5); //-262.9795
            kx23 = new GainBlock(0.1); //0.1738

            xLimit = new LimitBlock(0, 100);

            Block1 = new ComplexBlock();
            Block1.Add(new APBlock(dt, 10)); //36.85
            Block1.Add(new NoiseBlock(1));

            Block2 = new ComplexBlock();
            Block2.Add(new APBlock(dt, 10)); //4.64
            Block2.Add(new NoiseBlock(1));        
        }

        public double Calc1(double xIn1)
        {
            xIn1 = xLimit.Calc(xIn1);
            y2 = Block2.Calc(y2);
            var x1 = kx11.Calc(xIn1) + kx12.Calc(y2);
            return Block1.Calc(x1);
        }

        public double Calc2(double xIn2, double xOut1)
        {
            xIn2 = xLimit.Calc(xIn2);
            xOut1 = xLimit.Calc(xOut1);
            y1 = Block1.Calc(y1);
            var x2 = kx21.Calc(xIn2) + kx22.Calc(xOut1) + kx23.Calc(y1);
            return Block2.Calc(x2);
        }
    }
}
