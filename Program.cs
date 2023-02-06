using System;

namespace Superhero
{
    class Superhero
    {
        private string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        private string _heroOutfit;

        public string HeroOutfit
        {
            get { return _heroOutfit; }
            set { _heroOutfit = value; }
        }

        private string _power;

        public string Power
        {
            get { return _power; }
            set { _power = value; }
        }

        private string _archNemesis;

        public string ArchNemesis
        {
            get { return _archNemesis; }
            set { _archNemesis = value; }
        }
    }
}
