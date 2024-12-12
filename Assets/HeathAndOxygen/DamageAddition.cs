using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DamageAddition : MonoBehaviour
{
    //Add this script to any monster and set how much damage you want it to do
    //add the fill component of the HPBAR which is found under LeftEyeAnchor in the camera object.
    //You should be able to call dealDamage which will reduce health based on preset
    //Starting HP is 100 so scale damage based on that.
    private float startingHP = 100f;
    public float damageToTarget;
    public Image healthBarFill;
    private float currentHP;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        healthBarFill.fillAmount = Mathf.Clamp01(
        Mathf.InverseLerp(0, 100, currentHP));
        //TODO add something for player death. Will work on that after a small break
    }

    public void dealDamage(){
        currentHP = startingHP-damageToTarget;  
    }
}