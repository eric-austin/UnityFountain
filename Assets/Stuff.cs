using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//make sure anything attached to script has a rigid body
[RequireComponent(typeof(Rigidbody))]

public class Stuff : MonoBehaviour
{
    public Rigidbody body;

    void Awake() {
        //grab the rigid body component of whatever we are attched to and put in body variable
        body = GetComponent<Rigidbody>();
    }


}
