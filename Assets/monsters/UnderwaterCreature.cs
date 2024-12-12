using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class UnderwaterCreature : MonoBehaviour
{
    public Animator animator;
    public int hp = 3;
    public NavMeshAgent agent;
    public float speed = 1.0f;
    private int frameLag = 0;
    public bool willAttack = false;
    [SerializeField] private AudioClip damageSoundClip;
    private AudioSource audio;
    public int damageAmount = 10;


    // Start is called before the first frame update
    void Start() {
        audio = GetComponent<AudioSource>();
    }

    void Update () {
        // pathfind and deal 10 damage every 60 frames
        Vector3 targetPosition = Camera.main.transform.position;
        agent.SetDestination(targetPosition);
        agent.speed = speed;
        float distance = Vector3.Distance(targetPosition, this.transform.position);
        if (willAttack && distance <= 1.0) {
            frameLag --;
            if (frameLag <= 0) {
                audio.clip = damageSoundClip;
                audio.Play();
                // dealDamage(damageAmount);
                frameLag = 90;
            }
        }
    }

    public void Kill() {
        animator.SetTrigger("Death");
    }

    public void Damage() {
        hp --;
        if (hp == 0) {
            Kill();
        }
    }

    public void Destroy() {
        Destroy(gameObject);
    }
}