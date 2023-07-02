using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamagerBehaviour : MonoBehaviour
{
    public float damage;

    public virtual void OnCollisionEnter(Collision collision)
    {
        collision.gameObject.SendMessageUpwards("OnHit", damage, SendMessageOptions.DontRequireReceiver);
    }
}
