public class Tomahawk : Missile
{
    void Awake()
    {
        seekBehavior = new SeekWithGPS();
    }
}