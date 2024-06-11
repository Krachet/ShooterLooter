using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Nameplates : Singleton<Nameplates>
{
    public GameObject getCanvas()
    {
        return gameObject;
    }
}
