using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GameObject = UnityEngine.GameObject;

public class LogOnHit : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log(collision.gameObject.name + " hit " + gameObject.name);
    }
}
