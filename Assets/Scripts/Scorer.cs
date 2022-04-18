using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scorer : MonoBehaviour
{
    int hits = 0;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag != "Hit") // if the object tag does not equal Hit, then increase hits. You don't need to always define else statements.
        {
            hits++;
            Debug.Log("You've bumped into a thing this many times: " + hits);
        }
        
    }
}
