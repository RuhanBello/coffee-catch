using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TopDownController : MonoBehaviour {
    public float speed;

    private Rigidbody myRigidbody;

    // Use this for initialization
    void Start() {
        myRigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update() {
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");

        Vector3 movementVector = (Vector3.right * horizontal + Vector3.forward * vertical);
        movementVector.Normalize();
        movementVector *= speed;

        myRigidbody.velocity = movementVector;
    }
}
