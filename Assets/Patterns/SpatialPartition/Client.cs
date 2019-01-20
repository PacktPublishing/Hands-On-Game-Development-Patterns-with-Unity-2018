using UnityEngine;

namespace Pattern.SpatialPartition
{
    public class Client : MonoBehaviour
    {
        private Grid grid;
        private IUnit[] preys;

        void Start()
        {
            grid = new Grid(4, 4, 2);
            Debug.Log("A 4x4 grid was created with cells scaled at 2 units.");
        }

        void Update()
        {
            if (Input.GetKeyDown(KeyCode.P))
            {
                IUnit prey;
                int numberOfPrey = 5;
                preys = new IUnit[numberOfPrey];

                for (int i = 0; i < numberOfPrey; i++)
                {
                    prey = new Prey();
                    grid.AddToRandomnPosition(prey);
                    preys[i] = prey;
                    Debug.Log("A new prey was spawned @ cell number: " + preys[i].GetGridPosition());
                }
            }

            if (Input.GetKeyDown(KeyCode.H))
            {
                IUnit predator;
                predator = new Predator();
                grid.AddToRandomnPosition(predator);
                Debug.Log("A predator was spawned @ cell number: " + predator.GetGridPosition());

                int closest = grid.FindClosest(predator, preys);
                Debug.Log("The closest prey is @ cell number: " + closest);
            }
        }

        void OnGUI()
        {
            GUI.color = Color.black;
            GUI.Label(new Rect(10, 10, 500, 20), "Press P to spawn prey on the grid.");
            GUI.Label(new Rect(10, 30, 500, 20), "Press H to hunt some prey.");
            GUI.Label(new Rect(10, 50, 500, 20), "Monitor the Debug Console to view the output.");
        }
    }
}
