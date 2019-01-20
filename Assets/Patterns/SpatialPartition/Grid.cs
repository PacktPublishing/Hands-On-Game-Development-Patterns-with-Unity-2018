using System;
using System.Linq;

public class Grid
{
    private int m_NumberOfCells;

    public Grid(int mapWidth, int mapLenght, int cellSize)
    {
        int gridSize = mapWidth * mapLenght;
        m_NumberOfCells = gridSize / cellSize;
    }

    public void AddToRandomnPosition(IUnit unit)
    {
        unit.AddToGrid(UnityEngine.Random.Range(0, m_NumberOfCells));
    }

    public int FindClosest(IUnit referenceUnit, IUnit[] list)
    {
        if (list != null)
        {
            int reference = referenceUnit.GetGridPosition();

            int[] points = new int[list.Length];
            for (int i = 0; i < list.Length; i++)
            {
                points[i] = list[i].GetGridPosition();
            }

            var nearest = points.OrderBy(x => Math.Abs(x - reference)).First();
            return nearest;
        }
        else
        {
            throw new ArgumentException("Parameters cannot be null", "list");
        }
    }
}
