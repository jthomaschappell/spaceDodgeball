using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class SpaceshipManager : MonoBehaviour
{
    public float speed = 5f; // Adjust the speed as needed

    void Update()
    {
        // Move up when the "W" key is pressed
        if (Input.GetKey(KeyCode.W))
        {
            transform.rotation = Quaternion.Euler(0f, 0f, 0f);
            transform.Translate(Vector3.up * speed * Time.deltaTime);
        }

        // Move down when the "D" key is pressed
        if (Input.GetKey(KeyCode.S))
        {
            transform.rotation = Quaternion.Euler(0f, 0f, 180f);
            transform.Translate(Vector3.up * speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.rotation = Quaternion.Euler(0f, 0f, 90f);
            transform.Translate(Vector3.up * speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.rotation = Quaternion.Euler(0f, 0f, 270f);
            transform.Translate(Vector3.up * speed * Time.deltaTime);
        }
    }
}

