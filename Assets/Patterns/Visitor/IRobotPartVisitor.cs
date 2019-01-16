public interface IRobotPartVisitor
{
    void Visit(Robot robot);
    void Visit(Battery battery);
    void Visit(MechanicalArm mechanicalArm);
    void Visit(ThermalImager thermalImager);
}