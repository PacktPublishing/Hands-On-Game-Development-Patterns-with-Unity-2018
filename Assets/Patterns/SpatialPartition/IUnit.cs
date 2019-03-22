public interface IUnit
{
    // The Unit can add itself to the grid
    void AddToGrid(int cell);

    // The Unit can return is current grid position
    int GetGridPosition();
}