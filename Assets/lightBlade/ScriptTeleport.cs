using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptTeleport : MonoBehaviour
{
    public Vector3 targetLocation = new Vector3(0, 0, 0);
    private void OnCollisionEnter(Collision other)
    {
        other.gameObject.transform.position = targetLocation;
    }

}
