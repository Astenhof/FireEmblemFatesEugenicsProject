using FireEmblemEugenics.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FireEmblemEugenics.Data
{
    public abstract class ACharacter : ABaseModel, IBaseStats, IGrowthRates
    {
        #region Values
        private string _name;
        private double _hp;
        private double _strength;
        private double _magic;
        private double _skill;
        private double _speed;
        private double _luck;
        private double _defense;
        private double _resistance;

        private double _hpGrowth;
        private double _strengthGrowth;
        private double _magicGrowth;
        private double _skillGrowth;
        private double _speedGrowth;
        private double _luckGrowth;
        private double _defenseGrowth;
        private double _resistanceGrowth;
        #endregion

        #region Properties
        #region Base Stats
        public string Name
        {
            get { return _name; }
            set { _name = value; OnPropertyChanged(); }
        }

        public double HP
        {
            get { return _hp; }
            set { _hp = value; OnPropertyChanged(); }
        }

        public double Strength
        {
            get { return _strength; }
            set { _strength = value; OnPropertyChanged(); }
        }

        public double Magic
        {
            get { return _magic; }
            set { _magic = value; OnPropertyChanged(); }
        }

        public double Skill
        {
            get { return _skill; }
            set { _skill = value; OnPropertyChanged(); }
        }

        public double Speed
        {
            get { return _speed; }
            set { _speed = value; OnPropertyChanged(); }
        }

        public double Luck
        {
            get { return _luck; }
            set { _luck = value; OnPropertyChanged(); }
        }

        public double Defense
        {
            get { return _defense; }
            set { _defense = value; OnPropertyChanged(); }
        }

        public double Resistance
        {
            get { return _resistance; }
            set { _resistance = value; OnPropertyChanged(); }
        }
        #endregion

        #region Growth Rates
        public double HPGrowth
        {
            get { return _hpGrowth; }
            set { _hpGrowth = value; OnPropertyChanged(); }
        }

        public double StrengthGrowth
        {
            get { return _strengthGrowth; }
            set { _strengthGrowth = value; OnPropertyChanged(); }
        }

        public double MagicGrowth
        {
            get { return _magicGrowth; }
            set { _magicGrowth = value; OnPropertyChanged(); }
        }

        public double SkillGrowth
        {
            get { return _skillGrowth; }
            set { _skillGrowth = value; OnPropertyChanged(); }
        }

        public double SpeedGrowth
        {
            get { return _speedGrowth; }
            set { _speedGrowth = value; OnPropertyChanged(); }
        }

        public double LuckGrowth
        {
            get { return _luckGrowth; }
            set { _luckGrowth = value; OnPropertyChanged(); }
        }

        public double DefenseGrowth
        {
            get { return _defenseGrowth; }
            set { _defenseGrowth = value; OnPropertyChanged(); }
        }

        public double ResistanceGrowth
        {
            get { return _resistanceGrowth; }
            set { _resistanceGrowth = value; OnPropertyChanged(); }
        }

        
        #endregion

        #endregion

    }
}
