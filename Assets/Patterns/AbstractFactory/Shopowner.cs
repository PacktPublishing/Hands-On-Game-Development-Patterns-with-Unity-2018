using UnityEngine;

namespace Pattern.AbstractFactory
{
    public class Shopowner : IHuman
    {
        public void Speak()
        {
            Debug.Log("Shopowner: Do you wish to purchase something?");
        }
    }
}