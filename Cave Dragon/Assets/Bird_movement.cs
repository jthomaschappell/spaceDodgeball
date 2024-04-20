using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird_movement : MonoBehaviour
{
    public Rigidbody2D myRigidbody;
    // Start is called before the first frame update
    void Start()
    {
        gameObject.name = "The Cave Bird"; 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}


// Rigidbody2D that is in this component that we know about. 

// on the update --- include commands 

// code changes while game is going. 

// update is like an event listener. 

// spawner that spawns pipe prefab

// camera scale with screen size. 

// have a Game object titled Logic Manager with script that keeps
// track of high level things like score etc. 


// so write code for DURING in the update sections of different scripts. 




/*
- character moves in 
- spawned in new objects on timer
- flow movement
*/