using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clock : pickup
{
    public int timeToAdd;
    public override void Picked()
    {
        Destroy(this.gameObject);
        GameManager.instance.addTime(timeToAdd);
    }
}
