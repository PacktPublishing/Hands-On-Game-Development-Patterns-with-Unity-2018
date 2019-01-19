using UnityEngine;

namespace Pattern.AbstractFactory
{
    public class Dog : IAnimal
    {
        public void Voice()
        {
            Debug.Log("Dog: Woof!");
        }
    }
}
