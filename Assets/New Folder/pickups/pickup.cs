using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class pickup : MonoBehaviour
{
public virtual void Picked()
    {
        Destroy(this.gameObject);
    }
}
