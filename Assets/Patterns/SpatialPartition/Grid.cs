using System;
using System.Linq;
using UnityEngine;

public class Grid: MonoBehaviour
{
    private int m_SquareSize;
    private int m_NumberOfSquares;

    public Grid(int squareSize, int numberOfSquares)
    {
        // The size can represent anything (meters, km)
        m_SquareSize = squareSize;

        // Squares permits to subdivide the grid granulary
        m_NumberOfSquares = numberOfSquares;
    }

    public void AddToRandomnPosition(IUnit unit)
    {
        unit.AddToGrid(UnityEngine.Random.Range(0, m_NumberOfSquares));
    }

    public int FindClosest(IUnit referenceUnit, IUnit[] list)
    {
        if (list != null)
        {
            var points = list.Select(a => a.GetGridPosition()).ToList();
            var nearest = points.OrderBy(x => Math.Abs(x - referenceUnit.GetGridPosition())).First();
            return nearest;
        }
        else
        {
            throw new ArgumentException("Parameters cannot be null", "list");
        }
    }
}
