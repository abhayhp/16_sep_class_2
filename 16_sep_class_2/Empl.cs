using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_sep_class_2
{
    public class Empl
    {
        protected int id;
        public string name;
        public double bs, hra, da, pf, pt, total, netpaid;

        public Empl(string name, double bs, double pt)
        {
            this.name = name;
            this.bs = bs;
            this.pt = pt;
        }

        public virtual void CalculateSalary()
        {
            hra = bs * 0.40;
            da = bs * 0.20;
            pf = bs * 0.12;
            total = bs + hra + da ;
            netpaid = total - (pf + pt);

        }

        public override string ToString()
        {
            return $"Employee name {name} , total salary {total} & Net paid {netpaid}";
        }


    }

    public class Manager:  Empl
    {
        private double ta;
        public Manager( string name, double bs, double pt, double ta) : base(name, bs, pt)
        {
            this.ta = ta;   
        }

        public override void CalculateSalary()
        {
            hra = bs * 0.40;
            da = bs * 0.20;
            pf = bs * 0.12;
            total = bs + hra + da + ta;
            netpaid = total - (pf + pt);

        }

        public override string ToString()
        {
            return $"Manager name {name} , total salary {total} & Net paid {netpaid}";
        }





    }

    public class SalesManager : Empl
    {
        private double comm, bonus;

        public SalesManager(string name, double bs, double pt, double comm, double bonus) : base(name, bs, pt)
        {
            this.comm = comm;
            this.bonus = bonus;
        }

        public override void CalculateSalary()
        {
            hra = bs * 0.40;
            da = bs * 0.20;
            pf = bs * 0.12;
            total = bs + hra + da + bonus + comm;
            netpaid = total - (pf + pt);

        }

        public override string ToString()
        {
            return $"SalesManager name {name} , total salary {total} & Net paid {netpaid}";
        }




    }
}
