using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spinner : MonoBehaviour
{
    [SerializeField] float rotateX = 0; // If you don't give these a value they default to 0.
    [SerializeField] float rotateY = 0;
    [SerializeField] float rotateZ = 0;

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(rotateX, rotateY, rotateZ * Time.deltaTime); // People made comments without Delta Time it made a huge difference.
    }
}
