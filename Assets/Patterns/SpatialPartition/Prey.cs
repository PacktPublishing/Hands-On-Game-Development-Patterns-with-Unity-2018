public class Prey : IUnit
{
    private int m_Cell;

    public void AddToGrid(int cell)
    {
        m_Cell = cell;
    }

    public int GetGridPosition()
    {
        return m_Cell;
    }
}
