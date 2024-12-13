using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptTeleport : MonoBehaviour
{
    public Vector3 targetLocation = new Vector3(0, 0, 0);
    public void OnCollisionEnter(Transform camera)
    {
        Debug.Log("Teleporting to next floor");
        camera.position = targetLocation;
    }

}
