using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Superhero
{
    internal class Program
    {
        static void Main(string[] args)
        {

        }
    }

    public class Superhero
    {

        private string _secretidentity;

        //Encapsulation 
        public string SecretIdentity
        {
            get { return _secretidentity; }
            private set { _secretidentity = value; }
        }

        private string _powerandabilities;

        //Encapsulation 
        public string PowersAndAbilities
        {
            get { return _powerandabilities; }
            private set { _powerandabilities = value; }
        }

        private string _maskandcostume;

        //Encapsulation 
        public string MaskAndCostume
        {
            get { return _maskandcostume; }
            private set { _maskandcostume = value; }
        }

        private string _fightaganistcrime;

        //Encapsulation 
        public string FightAgainstCrime
        {
            get { return _fightaganistcrime; }
            private set { _fightaganistcrime = value; }
        }

        private string _moralcode;

        //Encapsulation 
        public string MoralCode
        {
            get { return _moralcode; }
            private set { _moralcode = value; }
        }

        private string _archenemy;

        //Encapsulation 
        public string Archenemy
        {
            get { return _archenemy; }
            private set { _archenemy = value; }
        }

        private string _innerfear;

        //Encapsulation 
        public string InnerFear
        {
            get { return _innerfear; }
            private set { _innerfear = value; }
        }
    }
}
