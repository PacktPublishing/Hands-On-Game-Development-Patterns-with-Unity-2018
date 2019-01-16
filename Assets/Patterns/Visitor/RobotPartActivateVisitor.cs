using UnityEngine;

public class RobotPartActivateVisitor : IRobotPartVisitor
{
    public void Visit(Robot robot)
    {
        Debug.Log("Robot waking up.");
    }

    public void Visit(Battery battery)
    {
        Debug.Log("Battery is charged up.");
    }

    public void Visit(MechanicalArm mechanicalArm)
    {
        Debug.Log("The mechanical arm is actiaved.");
    }

    public void Visit(ThermalImager thermalImager)
    {
        Debug.Log("The thermal imager is turned on.");
    }
}
