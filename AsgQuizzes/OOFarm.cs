using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AsgQuizzes
{
    /// <summary>
    /// HINT: You are expected to write classes that implement this interface
    /// </summary>
    public interface IAnimal
    {
        string SaySomething();
        int NumberOfLegs{ get;}
        bool CanFly { get; }
    }

    public class OOFarm
    {
        public OOFarm(int cats,int dogs, int ducks)
        {
        }

        public string IntroduceEverybody()
        {
            throw new NotImplementedException();
        }
    }
}
