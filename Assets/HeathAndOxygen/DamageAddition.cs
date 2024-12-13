using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class DamageAddition : MonoBehaviour
{
    private float startingHP = 100f;
    public float damageToTarget;
    public Slider healthBar;
    private float currentHP;
    // Start is called before the first frame update
    void Start()
    {
        currentHP = startingHP;
    }

    // Update is called once per frame
    void Update()
    {
       healthBar.value = currentHP;
       Debug.Log("Current HP: " + currentHP.ToString());
       if(currentHP <=0){
        SceneManager.LoadScene("DeathScene");
       }
    }

    public void dealDamage(float damageAmount){
        currentHP = currentHP - damageAmount;
    }
    public void resetHealth(){
        currentHP = startingHP;
    }
}
