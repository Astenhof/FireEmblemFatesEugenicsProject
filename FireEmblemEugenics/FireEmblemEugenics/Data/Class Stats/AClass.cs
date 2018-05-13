using FireEmblemEugenics.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FireEmblemEugenics.Data.Class_Stats
{
    public abstract class AClass : ABaseModel, IClass
    {
        #region Values
        private string _className;

        private double _hpClassGrowth;
        private double _strengthClassGrowth;
        private double _magicClassGrowth;
        private double _skillClassGrowth;
        private double _speedClassGrowth;
        private double _luckClassGrowth;
        private double _defenseClassGrowth;
        private double _resistanceClassGrowth;
        #endregion

        #region Properties

        #region ClassGrowth Rates
        public string ClassName
        {
            get { return _className; }
            set { _className = value; OnPropertyChanged(); }
        }

        public double HPClassGrowth
        {
            get { return _hpClassGrowth; }
            set { _hpClassGrowth = value; OnPropertyChanged(); }
        }

        public double StrengthClassGrowth
        {
            get { return _strengthClassGrowth; }
            set { _strengthClassGrowth = value; OnPropertyChanged(); }
        }

        public double MagicClassGrowth
        {
            get { return _magicClassGrowth; }
            set { _magicClassGrowth = value; OnPropertyChanged(); }
        }

        public double SkillClassGrowth
        {
            get { return _skillClassGrowth; }
            set { _skillClassGrowth = value; OnPropertyChanged(); }
        }

        public double SpeedClassGrowth
        {
            get { return _speedClassGrowth; }
            set { _speedClassGrowth = value; OnPropertyChanged(); }
        }

        public double LuckClassGrowth
        {
            get { return _luckClassGrowth; }
            set { _luckClassGrowth = value; OnPropertyChanged(); }
        }

        public double DefenseClassGrowth
        {
            get { return _defenseClassGrowth; }
            set { _defenseClassGrowth = value; OnPropertyChanged(); }
        }

        public double ResistanceClassGrowth
        {
            get { return _resistanceClassGrowth; }
            set { _resistanceClassGrowth = value; OnPropertyChanged(); }
        }


        #endregion

        #endregion

    }
}
