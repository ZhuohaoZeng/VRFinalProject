using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class RayGun : MonoBehaviour
{
    public OVRInput.RawButton shootingButton;
    public LineRenderer linePrefab;
    public Transform shootingPoint;
    public float maxLineDistance = 10;
    public float lineShowTimer = 0.3f;
    public AudioSource source;
    public AudioClip shootingAudioClip;
    public GameObject rayImpactPrefab;
    public LayerMask layerMask;
    // public GameObject key;
    // public Player playerScript;
    public CodePanel codePanel;
    public int totalMonstersRemainingFloor1 = 5;
    public int totalMonstersRemainingFloor2 = 10;

    //zz GameObject to get gate in different.
    public GameObject gateFLoor1;
    public GameObject gateFLoor2;
    public GameObject gateFLoor3;

    private bool codePanelFloor1Satisfied = false;
    private bool codePanelFloor2Satisfied = false;
    private bool finalBossIsDead = false;

    private bool onFloor1 = true;
    // public MonsterSpawner monsterSpawner;
    // public MonsterSpawnerTutorial monsterSpawnerTutorial;
    private float timer = 0f;
    private bool onFloor3 = false;

    // Update is called once per frame

    void Update()
    {
        if (OVRInput.GetDown(shootingButton)) {
            Shoot();
        }
        
    }
    public void Shoot() {
        source.PlayOneShot(shootingAudioClip);

        Ray ray = new Ray(shootingPoint.position, shootingPoint.forward);
        bool hasHit = Physics.Raycast(ray, out RaycastHit hit, maxLineDistance, layerMask);

        Vector3 endpoint = Vector3.zero;

        if (hasHit) {
            endpoint = hit.point;
            // UnderwaterCreature monster = hit.transform.GetComponentInParent<UnderwaterCreature>();
            CodePanel panel = hit.transform.GetComponentInParent<CodePanel>();
            
            if (hit.collider.tag == "Monster") {
                hit.collider.enabled = false;
                UnderwaterCreature monster = hit.collider.GetComponent<UnderwaterCreature>();
                bool killed = monster.Damage();

                // remove monsters from monster count if they have been destroyed
                // We can use this value to check success condition of the room
                if (killed) {
                    if (totalMonstersRemainingFloor1 > 0) {
                        totalMonstersRemainingFloor1 --;
                        if (totalMonstersRemainingFloor1 == 0) {
                            Debug.Log("Monsters killed successfully");
                        }
                    } else if (totalMonstersRemainingFloor2 == 0) {
                        finalBossIsDead = true;
                    } else {
                        totalMonstersRemainingFloor2 --;
                    }
                }
            } else if (panel){
                bool result = codePanel.HandleSquareHit(hit.transform.gameObject);
                if (onFloor1) {
                    codePanelFloor1Satisfied = result;
                } else {
                    codePanelFloor2Satisfied = result;

                }
                
            } else if(hit.collider.tag == "UpButton" || hit.collider.tag == "DownButton"){
                    Button thisButton = hit.collider.GetComponent<Button>();
                    thisButton.onClick.Invoke();
            } else if (hit.collider.tag == "teleporter") {
                Debug.Log("teleporting.");
                if(onFloor3){
                    SceneManager.LoadScene("WinScene");
                }
                ScriptTeleport teleporter = hit.collider.GetComponent<ScriptTeleport>();
                teleporter.teleportTo(Camera.main.transform);
            }
            else {
                GameObject rayImpact = Instantiate(rayImpactPrefab, hit.point, Quaternion.LookRotation(-hit.normal));
                Destroy(rayImpact, 1);
            }
            Debug.Log(onFloor1.ToString() + codePanelFloor1Satisfied.ToString() + totalMonstersRemainingFloor1.ToString());
            if (onFloor1 && codePanelFloor1Satisfied && totalMonstersRemainingFloor1 == 0) {
                // enable gate to floor 2
                gateFLoor1.SetActive(true);
            }
            if (!onFloor1 && codePanelFloor1Satisfied && totalMonstersRemainingFloor2 == 0) {
                // enable gate to floor 3
                onFloor3 = true;
                gateFLoor2.SetActive(true);
            }

        } else {
            endpoint = shootingPoint.position + shootingPoint.forward * maxLineDistance;
        }

        LineRenderer line = Instantiate(linePrefab);
        line.positionCount = 2;
        line.SetPosition(0, shootingPoint.position);
        line.SetPosition(1, endpoint);

        Destroy(line.gameObject, lineShowTimer);
    }
}
