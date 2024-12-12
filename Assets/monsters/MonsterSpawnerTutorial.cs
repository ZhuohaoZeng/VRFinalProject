using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.ProBuilder.Shapes;

public class MonsterSpawnerTutorial : MonoBehaviour
{
    public GameObject monster;
    public int totalMonstersRemaining = 5;


    // Start is called before the first frame update
    void Start() {
        for (int i = 0; i < totalMonstersRemaining; i++) {
            Vector3 pos = new Vector3(Random.value * 10.0f, 0.0f, Random.value*10.0f);
            pos = transform.TransformPoint(pos);
            Instantiate(monster, pos, Quaternion.identity, transform);
        }
    }
}