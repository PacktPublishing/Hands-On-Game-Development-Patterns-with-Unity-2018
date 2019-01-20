using UnityEngine;

public class Predator : IUnit
{
    private int m_Cell;

    public void AddToGrid(int cell)
    {
        m_Cell = cell;
        Debug.Log("Hunter added to cell number: " + cell);
    }

    public int GetGridPosition()
    {
        return m_Cell;
    }
}
