using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Container : MonoBehaviour
{
    public List<GameObject> ballsList;
    private int maxCount = 4;

    public List<string> correctTags;

    private void OnTriggerEnter(Collider other)
    {
        if(ballsList.Count < maxCount)
        {
            //if (other.tag == "yellow" || other.tag == "red")
            //if (correctTags.Contains(other.tag) == true)
            if (other.GetComponent<Ball>() != null)
            {
                ballsList.Add(other.gameObject);
            }

            if (ballsList.Count == maxCount)
            {
                CountSpheres();
            }
        }
        else
        {
            Debug.Log("Full");
        }
    }

    private void OnTriggerExit(Collider other)
    {
        ballsList.Remove(other.gameObject);
    }

    public void CountSpheres()
    {
        int red = 0;
        int yellow = 0;
        foreach (GameObject ball in ballsList)
        {
            if (ball.tag == "yellow")
            {
                yellow++;
            }
            else if (ball.tag == "red")
            {
                red++;
            }
        }
        if (yellow == maxCount)
        {
            Debug.Log("Container is full of yellow");
        }
        else if (red == maxCount)
        {
            Debug.Log("Container is full of red");
        }
    }
}
