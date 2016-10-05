using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterGen
{
    public class Character
    {
        private double[] _stats; //Holds character stats

        private double _strength;           //Holds individual stats pulled from _stats array.
        private double _dexterity;          //Not necessary, but makes code more readable.
        private double _constitution;       //I.E. _strength is easier to identify at a glance
        private double _intelligence;       //than _stats[0]
        private double _wisdom;
        private double _charisma;

        private List<double> _abilityModifiers; //List contains ability modifiers. Converts to array

        public void UpdateStats(double[] stats)
        {
            _stats = stats;
            _strength = stats[0];
            _dexterity = stats[1];
            _constitution = stats[2];
            _intelligence = stats[3];
            _wisdom = stats[4];
            _charisma = stats[5];

            _abilityModifiers = new List<double>();

            foreach (double item in stats)
            {
                _abilityModifiers.Add(Math.Floor((item - 10) / 2)); //Calculates ability modifiers
            }
        }

        public double StrengthModifier { get { return _abilityModifiers[0]; } }
        public double DexterityModifier { get { return _abilityModifiers[1]; } }
        public double ConstitutionModifier { get { return _abilityModifiers[2]; } }
        public double IntelligenceModifier { get { return _abilityModifiers[3]; } }
        public double WisdomModifier { get { return _abilityModifiers[4]; } }
        public double CharismaModifier { get { return _abilityModifiers[5]; } }
    }
}
