// FishingSystem.cs

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishingSystem : MonoBehaviour
{
    public float castDistance = 20f; // maximum distance the player can cast
    public float waitTime = 5f; // time to wait for fish to bite
    public int catchDifficulty = 50; // scaling difficulty for catching fish

    private bool isFishing = false;
    private float waitTimer;

    public void CastLine()
    {
        if (!isFishing)
        {
            Debug.Log("Casting line...");
            isFishing = true;
            waitTimer = waitTime;
            // Implement casting logic here
        }
    }

    private void Update()
    {
        if (isFishing)
        {
            waitTimer -= Time.deltaTime;
            if (waitTimer <= 0)
            {
                CatchFish();
            }
        }
    }

    private void CatchFish()
    {
        isFishing = false;
        int catchRoll = Random.Range(0, 100);
        if (catchRoll < catchDifficulty)
        {
            Debug.Log("Caught a fish!");
            // Implement logic for adding the fish to the inventory
        }
        else
        {
            Debug.Log("Fish got away!");
        }
    }
}