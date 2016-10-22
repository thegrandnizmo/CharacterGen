using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterGen
{
    public class Character
    {
        private string _name;

        private int[] _stats; //Holds character stats

        private double _strength;           //Holds individual stats pulled from _stats array.
        private double _dexterity;          //Not necessary, but makes code more readable.
        private double _constitution;       //I.E. _strength is easier to identify at a glance
        private double _intelligence;       //than _stats[0]
        private double _wisdom;
        private double _charisma;

        private List<double> _abilityModifiers;

        private double _athletics; //Skills
        private double _acrobatics;
        private double _sleightOfHand;
        private double _stealth;
        private double _arcana;
        private double _history;
        private double _investigation;
        private double _nature;
        private double _religion;
        private double _animalHandling;
        private double _insight;
        private double _medicine;
        private double _perception;
        private double _survival;
        private double _deception;
        private double _intimidation;
        private double _performance;
        private double _persuasion;

        public void UpdateStats(int[] stats)
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

            _athletics = _abilityModifiers[0]; //Set Skills
            _acrobatics = _abilityModifiers[1];
            _sleightOfHand = _abilityModifiers[1];
            _stealth = _abilityModifiers[1];
            _arcana = _abilityModifiers[3];
            _history = _abilityModifiers[3];
            _investigation = _abilityModifiers[3];
            _nature = _abilityModifiers[3];
            _religion = _abilityModifiers[3];
            _animalHandling = _abilityModifiers[4];
            _insight = _abilityModifiers[4];
            _medicine = _abilityModifiers[4];
            _perception = _abilityModifiers[4];
            _survival = _abilityModifiers[4];
            _deception = _abilityModifiers[5];
            _intimidation = _abilityModifiers[5];
            _performance = _abilityModifiers[5];
            _persuasion = _abilityModifiers[5];
        }

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    bool ValidName = false;
                    while (ValidName == false)
                    {
                        Console.WriteLine("Name cannot be empty. Please enter a valid name:");
                        value = Console.ReadLine();
                        if (!string.IsNullOrEmpty(value))
                        {
                            ValidName = true;
                        }
                    }
                }
                _name = value;
            }
        }
        
        //Stats
        public double StrengthModifier { get { return _abilityModifiers[0]; } }
        public double DexterityModifier { get { return _abilityModifiers[1]; } }
        public double ConstitutionModifier { get { return _abilityModifiers[2]; } }
        public double IntelligenceModifier { get { return _abilityModifiers[3]; } }
        public double WisdomModifier { get { return _abilityModifiers[4]; } }
        public double CharismaModifier { get { return _abilityModifiers[5]; } }

        //Skills
        public double SkillAthletics { get { return _athletics; } }
        public double SkillAcrobatics { get { return _acrobatics; } }
        public double SkillSleightOfHand { get { return _sleightOfHand; } }
        public double SkillStealth { get { return _stealth; } }
        public double SkillArcana { get { return _arcana; } }
        public double SkillHistory { get { return _history; } }
        public double SkillInvestigation { get { return _investigation; } }
        public double SkillNature { get { return _nature; } }
        public double SkillReligion { get { return _religion; } }
        public double SkillAnimalHandling { get { return _animalHandling; } }
        public double SkillInsight { get { return _insight; } }
        public double SkillMedicine { get { return _medicine; } }
        public double SkillPerception { get { return _perception; } }
        public double SkillSurvival { get { return _survival; } }
        public double SkillDeception { get { return _deception; } }
        public double SkillIntimidation { get { return _intimidation; } }
        public double SkillPerformance { get { return _performance; } }
        public double SkillPersuasion { get { return _persuasion; } }
    }
}
