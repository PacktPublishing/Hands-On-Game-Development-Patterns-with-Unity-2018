public class MechanicalArm : IRobotPart
{
    public void Accept(IRobotPartVisitor robotPartVisitor)
    {
        robotPartVisitor.Visit(this);
    }
}
