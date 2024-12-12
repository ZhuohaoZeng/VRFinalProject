using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.ProBuilder.Shapes;

public class MonsterSpawner : MonoBehaviour
{
    public UnderwaterCreature monster;
    public int totalMonstersRemaining = 10;

    public void SpawnMonsters() {
        Debug.Log("Floor2 monsters spawning");
        for (int i = 0; i < totalMonstersRemaining; i++) {
            Vector3 pos = new Vector3(Random.value * 10.0f, 0.0f, Random.value*25.0f);
            pos = transform.TransformPoint(pos);
            UnderwaterCreature newMonster = Instantiate(monster, pos, Quaternion.identity, transform);
            newMonster.willAttack = true;
        }
    }
}