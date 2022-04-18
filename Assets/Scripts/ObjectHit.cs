using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectHit : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            GetComponent<MeshRenderer>().material.color = Color.cyan; //Gets the MeshRenderer (it's a method so need ()) and reassign (left becomes the right).
            gameObject.tag = "Hit";
        }
    }
}
