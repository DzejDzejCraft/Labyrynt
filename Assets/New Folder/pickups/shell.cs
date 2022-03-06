using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shell : pickup
{
    public int points = 5;
    public override void Picked()
    {
        GameManager.instance.AddPoints(points);
        Debug.Log("shell picked");
        base.Picked();
    }
}
