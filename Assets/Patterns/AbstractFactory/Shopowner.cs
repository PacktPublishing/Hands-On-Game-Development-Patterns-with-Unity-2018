using UnityEngine;

namespace Pattern.AbstractFactory
{
    public class Shopowner : INPC
    {
        public void Speak()
        {
            Debug.Log("Shopowner: Do you wish to purchase something?");
        }
    }
}