using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
public class WinSceneText : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(winText());

    }

   

    IEnumerator winText(){
        TextMeshProUGUI endingText = GetComponent<TextMeshProUGUI>();
        endingText.text ="Congratulations You made it out!".ToString();
        // input2.ForceMeshUpdate(true);
        yield return new WaitForSecondsRealtime(5);
        endingText.text = "It seems the facility has teleported you and your boat back to your home island".ToString();
        // input2.ForceMeshUpdate(true);
        yield return new WaitForSecondsRealtime(5);
        endingText.text = "You can't wait to go back home and relax and you tell yourself you'll stick to fishing from now on!".ToString();
        yield return new WaitForSecondsRealtime(5);
        endingText.text = "Congratulations on Winning the Game. We hope you had Fun!".ToString();
        yield return new WaitForSecondsRealtime(5);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
