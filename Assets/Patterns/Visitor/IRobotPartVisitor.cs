public interface IRobotPartVisitor
{
    public void visit(Robot robot);
    public void visit(Battery battery);
    public void visit(MechanicalArm mechanicalArm);
    public void visit(ThermalImager thermalImager);
}