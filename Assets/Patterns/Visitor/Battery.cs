public class Battery : IRobotPart
{
    public void Accept(IRobotPartVisitor robotPartVisitor)
    {
        robotPartVisitor.Visit(this);
    }
}
