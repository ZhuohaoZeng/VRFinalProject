using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
public class IntroSceneText : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(introText());

    }

   

    IEnumerator introText(){
        TextMeshProUGUI endingText = GetComponent<TextMeshProUGUI>();
        endingText.text ="Welcome to the open ocean".ToString();
        // input2.ForceMeshUpdate(true);
        yield return new WaitForSecondsRealtime(5);
        endingText.text = "You are a lowly fisherman who was out fishing for the day when you made a intriguing discovery".ToString();
        // input2.ForceMeshUpdate(true);
        yield return new WaitForSecondsRealtime(5);
        endingText.text = "You've found an underwater facility and since you're fishing buisness has been slow lately. You decide you'll check it out".ToString();
        yield return new WaitForSecondsRealtime(5);
        endingText.text = "Little did you know that would be a grave mistake.".ToString();
        yield return new WaitForSecondsRealtime(5);
        endingText.text = "Can you make it out of the underwater facility and make it back up to safety?".ToString();
        yield return new WaitForSecondsRealtime(5);
        endingText.text = "Well down you go!".ToString();
        yield return new WaitForSecondsRealtime(5);
        SceneManager.LoadScene("ParkScene");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
