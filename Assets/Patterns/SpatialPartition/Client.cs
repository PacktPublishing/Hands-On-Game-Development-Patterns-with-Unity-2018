using UnityEngine;

namespace Pattern.SpatialPartition
{
    public class Client : MonoBehaviour
    {
        private Grid m_Grid;
        private IUnit[] m_Preys;

        void Start()
        {
            m_Grid = new Grid(4, 4, 2);
            Debug.Log("A 4x4 grid was created with cells scaled at 2 units.");
        }

        void Update()
        {
            if (Input.GetKeyDown(KeyCode.P))
            {
                IUnit prey;
                int numberOfPrey = 5;
                m_Preys = new IUnit[numberOfPrey];

                for (int i = 0; i < numberOfPrey; i++)
                {
                    prey = new Prey();
                    m_Grid.AddToRandomnPosition(prey);
                    m_Preys[i] = prey;
                    Debug.Log("A new prey was spawned @ cell number: " + m_Preys[i].GetGridPosition());
                }
            }

            if (Input.GetKeyDown(KeyCode.H))
            {
                IUnit predator;
                predator = new Predator();
                m_Grid.AddToRandomnPosition(predator);
                Debug.Log("A predator was spawned @ cell number: " + predator.GetGridPosition());

                int closest = m_Grid.FindClosest(predator, m_Preys);
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
