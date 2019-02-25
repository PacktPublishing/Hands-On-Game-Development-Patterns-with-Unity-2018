using UnityEngine;

namespace Pattern.AbstractFactory
{
    public class FactoryProducer : MonoBehaviour
    {
        public static AbstractFactory GetFactory(FactoryType factoryType)
        {
            switch (factoryType)
            {
                case FactoryType.Human:
                    AbstractFactory humanFactory = new HumanFactory();
                    return humanFactory;
                case FactoryType.Animal:
                    AbstractFactory animalFactory = new AnimalFactory();
                    return animalFactory;
            }

            return null;
    
        }
    }
}
