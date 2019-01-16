using UnityEngine;

public class Robot : IRobotPart
{
    private IRobotPart[] robotParts;

    public Robot()
    {
        robotParts = new IRobotPart[] { new MechanicalArm(), new ThermalImager(), new Battery() };
    }

    public void Accept(IRobotPartVisitor robotPartVisitor)
    {
        for (int i = 0; i < robotParts.Length; i++)
        {
            robotParts[i].Accept(robotPartVisitor);
        }
        robotPartVisitor.Visit(this);
    }
}
