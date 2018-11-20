public class SideWinder : Missile
{
    void Awake()
    {
        seekBehavior = new SeekWithHeat();
    }
}
