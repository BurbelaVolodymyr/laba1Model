using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modeling.Blocks;

namespace Modeling
{
    public class ControlSystem
    {
        private PIDBlock PID;
        private double dt;
        private Tank Tank;

        public double Time { get; set; } = 0;

        private LimitBlock xLimit = new LimitBlock(0, 100);
        private LimitBlock levelLimit = new LimitBlock(0, 500);

        private double input1;
        private double input2;
        private double output1;
        private double setPoint;

        public double Input1 { get { return input1; } set { input1 = xLimit.Calc(value); } }
        public double Input2 { get { return input2; } set { input2 = xLimit.Calc(value); } }
        public double Output1 { get { return output1; } set { output1 = xLimit.Calc(value); } }
        public double y1 { get; set; }
        public double y2 { get; set; }
        public double SetPoint { get { return setPoint; } set { setPoint = levelLimit.Calc(value); } }


        public double K { get { return PID.K; } set { PID.K = value; } }
        public double Ti { get { return PID.Ti; } set { PID.Ti = value; } }
        public double Td { get { return PID.Td; } set { PID.Td = value; } }

        public bool ManualMode { get { return PID.ManualMode; } set { PID.ManualMode = value; } }
        public double U { get { return PID.U; } set { PID.U = value; } }

        public ControlSystem(double dt)
        {
            this.dt = dt;
            PID = new PIDBlock(dt);
            Tank = new Tank(dt);
        }

        public void Calc()
        {
            Time += dt;

            y1 = Tank.Calc1(Input1);
            y2 = Tank.Calc2(Input2, Output1);
            var e = SetPoint - y2;
            var u = PID.Calc(e);
            if (!ManualMode)
            {
                Input1 = u;
            }
            else
            {
                PID.Umanual = Input1;
            }
        }

    }
}
