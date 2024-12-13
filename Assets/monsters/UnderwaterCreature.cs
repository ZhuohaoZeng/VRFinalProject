using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class UnderwaterCreature : MonoBehaviour
{
    public Animator animator;
    public int hp = 3;
    public NavMeshAgent agent;
    public float speed = 5.0f;
    public int frameLag = 0;
    [SerializeField] private AudioClip damageSoundClip;
    private AudioSource audio;


    // Start is called before the first frame update
    void Start() {
        audio = GetComponent<AudioSource>();
    }

    public void Kill() {
        animator.SetTrigger("Death");
    }

    public bool Damage() {
        hp -= 1;
        if (hp == 0) {
            Kill();
            return true;
        }
        return false;
    }

    public void Destroy() {
        Destroy(gameObject);
    }

    public float GetDistance() {
        Vector3 targetPosition = GetTargetPos();
        return Vector3.Distance(targetPosition, this.transform.position);
    }

    public void PlayAudio() {
        audio.clip = damageSoundClip;
        audio.Play();
    }

    public void PathFind() {
        agent.SetDestination(GetTargetPos());
        agent.speed = speed;
    }

    private Vector3 GetTargetPos() {
        return Camera.main.transform.position;
    }
}