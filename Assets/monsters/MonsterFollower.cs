using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class MonsterFollower : MonoBehaviour
{
    public NavMeshAgent nav;
    public Transform target;



    // Update is called once per frame
    void Update()
    {
        this.nav.SetDestination(this.target.position);
    }
}
