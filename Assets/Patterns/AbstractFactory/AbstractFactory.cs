namespace Pattern.AbstractFactory
{
    public abstract class AbstractFactory
    {
        public abstract IHuman GetHuman(HumanType humanType);
        public abstract IAnimal GetAnimal(AnimalType animalType);
    }
}