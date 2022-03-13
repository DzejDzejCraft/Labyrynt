using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : pickup

{
    public KeyColor color;
    public override void Picked()
    {
        GameManager.instance.Addkey(color);
        base.Picked();
    }

}
