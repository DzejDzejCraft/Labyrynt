using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pickup : MonoBehaviour
{
public virtual void Picked()
    {
        Destroy(this.gameObject);
    }
}
