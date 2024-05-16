using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : character
{
    static public player instance;
    void Start()
    {
        instance = this; 
    }
}
