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

        private double _strength;
        private double _dexterity;
        private double _constitution;
        private double _intelligence;
        private double _wisdom;
        private double _charisma;

        //List to be converted to array
        private List<double> AbilityModifiers;

        //Converted from AbilityModifiers list
        private double[] _abilityModifiers;

        public void UpdateStats(double[] stats)
        {
            _stats = stats;
            _strength = stats[0];
            _dexterity = stats[1];
            _constitution = stats[2];
            _intelligence = stats[3];
            _wisdom = stats[4];
            _charisma = stats[5];
            _abilityModifiers = new double[6];
            AbilityModifiers = new List<double>();

            //Calculates ability modifiers
            foreach (double item in stats)
            {
                AbilityModifiers.Add(Math.Floor((item - 10) / 2));
            }
            //Converts list to array
            _abilityModifiers = AbilityModifiers.ToArray();
        }

        public void UpdateSkills(double AbilityModifier)
        {

        }

        public double StrengthModifier
        {
            get
            {
                return _abilityModifiers[0];
            }
        }
        public double DexterityModifier
        {
            get
            {
                return _abilityModifiers[1];
            }
        }
        public double ConstitutionModifier
        {
            get
            {
                return _abilityModifiers[2];
            }
        }
        public double IntelligenceModifier
        {
            get
            {
                return _abilityModifiers[3];
            }
        }
        public double WisdomModifier
        {
            get
            {
                return _abilityModifiers[4];
            }
        }
        public double CharismaModifier
        {
            get
            {
                return _abilityModifiers[5];
            }
        }
    }
}
