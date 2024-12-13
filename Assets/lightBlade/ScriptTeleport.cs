using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptTeleport : MonoBehaviour
{
    public Vector3 targetLocation;// = new Vector3(0, 0, 0);
    private Transform mainCameraTrans;

    void Awake()
    {
        GameObject camera = GameObject.Find("[BuildingBlock] Camera Rig");
        mainCameraTrans = camera.transform;
    }
    public void teleportTo(Transform camera)
    {
        mainCameraTrans.position = targetLocation;
    }


}
