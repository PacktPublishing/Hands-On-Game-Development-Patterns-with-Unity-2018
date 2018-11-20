using UnityEngine;
using System.Collections;

/**
 * An interface is like a contract, any object that want to expose the ability to copy itself needs to implement this interface.
 * In this example, all types of drones will have to implement the body of the Copy() function.
 * */

public interface iCopyable // I'm using copyable instead of clonable to avoid confusion with native C# clonable interface.
{
    iCopyable Copy();
}
