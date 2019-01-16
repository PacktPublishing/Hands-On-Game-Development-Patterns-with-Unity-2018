public interface IRobotPart
{
    void Accept(IRobotPartVisitor robotPartVisitor);
}