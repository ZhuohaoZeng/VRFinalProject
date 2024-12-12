using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OxygenDeplete : MonoBehaviour
{

    float oxygenLevel = 100f;
    public Slider o2Slider;
    public float depletionPerSecond = 1f;
    private int interval = 1; 
    private float nextTime = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(oxygenLevel == 0){
            Debug.Log("No Oxygen");
        }
        if (Time.time >= nextTime) {
            oxygenLevel = oxygenLevel-depletionPerSecond;
            o2Slider.value = oxygenLevel;
            nextTime += interval; 
        }
        
    }
}
