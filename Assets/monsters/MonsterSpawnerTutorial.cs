using System.Collections;
using System.Collections.Generic;
using Meta.WitAi;
using UnityEngine;
using UnityEngine.ProBuilder.Shapes;

public class MonsterSpawnerTutorial : MonoBehaviour
{
    public UnderwaterCreature monster;
    public int totalMonstersRemaining = 5;
    private UnderwaterCreature[] monsters;
    public DamageAddition health;
    public float damageAmount = 0.0f;


    // Start is called before the first frame update
    void Start() {
        monsters = new UnderwaterCreature[totalMonstersRemaining];
        for (int i = 0; i < totalMonstersRemaining; i++) {
            Vector3 pos = new Vector3(Random.value * 10.0f, 0.0f, Random.value*10.0f);
            pos = transform.TransformPoint(pos);
            UnderwaterCreature mstr = Instantiate(monster, pos, Quaternion.identity, transform);
            monsters[i] = mstr;
        }
    }

    void Update() {
        for (int i = 0; i < totalMonstersRemaining; i++) {
            if (monsters[i] != null) {
                float distance = monsters[i].GetDistance();

                if (distance <= 3.0) {
                    monsters[i].frameLag --;
                    if (monsters[i].frameLag <= 0) {
                        monsters[i].PlayAudio();
                        monsters[i].frameLag = 90;
                        health.dealDamage(damageAmount);
                    }
                }
                else {
                    monsters[i].PathFind();
                }
            }
        }
    }
}