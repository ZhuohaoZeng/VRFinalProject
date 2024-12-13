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
        endingText.text ="Hold any button for the next 4 seconds to skip the tutorial.".ToString();
        yield return new WaitForSecondsRealtime(5);
        if(!OVRInput.Get(OVRInput.Button.Any)){
            endingText.text ="To shoot press the trigger on the right hand.".ToString();
            yield return new WaitForSecondsRealtime(4);
            endingText.text ="You will interact with all puzzles and monsters using the laser gun ".ToString();
            yield return new WaitForSecondsRealtime(4);
            endingText.text ="The game has 3 floors each floors has a teleporter that will open when all monsters are killed.".ToString();
            yield return new WaitForSecondsRealtime(4);            
            endingText.text ="You can move by teleporting to different places by moving the any stick forward and letting go.".ToString();
            yield return new WaitForSecondsRealtime(4);            
            endingText.text ="The red bar shows your health and your health will reset for each floor ".ToString();
            yield return new WaitForSecondsRealtime(4);            
            endingText.text ="The blue bar is your oxygen which will continuously deplete, if you aren't able to finish before it runs out you lose the game.".ToString();
            yield return new WaitForSecondsRealtime(4);            
            endingText.text ="Good Luck And Have Fun!".ToString();
            yield return new WaitForSecondsRealtime(2);            
        }
        else{
            endingText.text = "Skipping Tutorial".ToString();
            yield return new WaitForSecondsRealtime(3);
        }
        
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
