using UnityEngine;

namespace Pattern.AbstractFactory
{
    public class Farmer : INPC
    {
        public void Speak()
        {
            Debug.Log("Farmer: You reap what you sow!");
        }
    }
}
