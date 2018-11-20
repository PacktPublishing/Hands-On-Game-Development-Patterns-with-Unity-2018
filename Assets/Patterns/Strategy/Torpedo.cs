public class Torpedo : Missile
{
    void Awake()
    {
        seekBehavior = new SeekWithSonar();
    }
}
