using UnityEngine;

namespace Pattern.AbstractFactory
{
    public class Cat : IAnimal
    {
        public void Voice()
        {
            Debug.Log("Cat: Meow!");
        }
    }
}
