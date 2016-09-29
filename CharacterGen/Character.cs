using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterGen
{
    public class Character
    {
        private double[] _stats;

        private double _str;
        private double _dex;
        private double _con;
        private double _int;
        private double _wis;
        private double _cha;

        //List used to be converted to array
        private List<double> mods;

        //Converted from mods list
        private double[] _mods;

        public void UpdateStats(double[] stats)
        {
            _stats = stats;
            _str = stats[0];
            _dex = stats[1];
            _con = stats[2];
            _int = stats[3];
            _wis = stats[4];
            _cha = stats[5];
            _mods = new double[6];
            mods = new List<double>();

            //Calculates ability modifiers
            foreach (double item in stats)
            {
                mods.Add(Math.Floor((item - 10) / 2));
            }
            //Converts list to array
            _mods = mods.ToArray();
        }

        public double StrMod
        {
            get
            {
                return _mods[0];
            }
            set
            {

            }
        }
    }
}
