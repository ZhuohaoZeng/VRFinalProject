using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.Experimental.AssetDatabaseExperimental.AssetDatabaseCounters;

public class Demo : MonoBehaviour
{
    public float interval = 3.0f;
    private float timer = 0f;
    private int counter = 0;
    public Transform camera;
    public float location = 1f;

    void Update()
    {
        timer += Time.deltaTime;

        // Check if the timer exceeds the interval
        if (timer >= interval)
        {
            counter++; // Increment the counter
            Debug.Log("Counter: " + counter); // Log the counter value
            camera.position = new Vector3(location, location, location);
            location += 1f;
            timer = 0f; // Reset the timer
        }
    }
}
