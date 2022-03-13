using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class freez : pickup
{
    public int freezTime;
    public override void Picked()
    {
        GameManager.instance.Freezze(freezTime);
        base.Picked();
    }


}
