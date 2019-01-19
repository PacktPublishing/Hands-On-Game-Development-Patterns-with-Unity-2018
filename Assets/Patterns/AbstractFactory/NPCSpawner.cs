using UnityEngine;

namespace Pattern.AbstractFactory
{
    public class NPCSpawner : MonoBehaviour
    {
        private IAnimal m_Cat;
        private IAnimal m_Dog;

        private IHuman m_Farmer;
        private IHuman m_Beggar;
        private IHuman m_Shopowner;

        private AbstractFactory factory;

        public void SpawnAnimals()
        {
            factory = FactoryProducer.GetFactory(FactoryType.Animal);

            m_Cat = factory.GetAnimal(AnimalType.Cat);
            m_Dog = factory.GetAnimal(AnimalType.Dog);

            m_Cat.Voice();
            m_Dog.Voice();
        }

        public void SpawnHumans()
        {
            factory = FactoryProducer.GetFactory(FactoryType.Human);

            m_Beggar = factory.GetHuman(HumanType.Beggar);
            m_Farmer = factory.GetHuman(HumanType.Farmer);
            m_Shopowner = factory.GetHuman(HumanType.Shopowner);

            m_Beggar.Speak();
            m_Farmer.Speak();
            m_Shopowner.Speak();
        }
    }
}
