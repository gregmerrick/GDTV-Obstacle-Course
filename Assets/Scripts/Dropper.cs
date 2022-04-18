using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropper : MonoBehaviour
{
    MeshRenderer renderer;
    Rigidbody rigidbody;

    [SerializeField] float timeToWait = 3f; // Always use variables when something isn't 0 or 1 (0 or 1 values usually don't change).

    // Start is called before the first frame update
    void Start()
    {
        renderer = GetComponent<MeshRenderer>(); // This is how you cache an object. Assign the component to a variable to not repeat yourself and use it everywhere.
        rigidbody = GetComponent<Rigidbody>();

        renderer.enabled = false;
        rigidbody.useGravity = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > timeToWait)
        {
            renderer.enabled = true;
            rigidbody.useGravity = true;
        }
    }
}
