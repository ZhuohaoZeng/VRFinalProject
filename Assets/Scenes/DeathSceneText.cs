using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TextAddition : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(deathText());

    }

   

    IEnumerator deathText(){
        TextMeshProUGUI endingText = GetComponent<TextMeshProUGUI>();
        endingText.text = "Well,here you are stuck at the bottom of the ocean".ToString();
        // input2.ForceMeshUpdate(true);
        yield return new WaitForSecondsRealtime(6);
        endingText.text = "With plenty of time to think about your mistakes".ToString();
        // input2.ForceMeshUpdate(true);
        yield return new WaitForSecondsRealtime(6);
        endingText.text = "Maybe if you never found that underwater facility you wouldn't be here right now".ToString();
        yield return new WaitForSecondsRealtime(6);
        endingText.text = "You could have been watching TV or having a nice meal with your family".ToString();
        yield return new WaitForSecondsRealtime(6);
        endingText.text = "Well at least you'll have a lot of time to think about everything you could have done differently".ToString();
        yield return new WaitForSecondsRealtime(6);
        endingText.text = "Enjoy your time down here because we both know you'll be down here for a long time.".ToString();
        yield return new WaitForSecondsRealtime(6);
        endingText.text = "You have become another victim of the silent sea";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
