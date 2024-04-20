using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletManager : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed = 5f; // Adjust the speed as needed
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // if (Input.GetKey(KeyCode.G))
        // {
            transform.Translate(Vector3.up * speed * Time.deltaTime);
        // }
    }
}
