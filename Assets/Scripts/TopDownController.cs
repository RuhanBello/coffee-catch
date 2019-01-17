using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TopDownController : MonoBehaviour {
    public float speed;

    public int coinsAmount;
    public Text coinsText;

    private Rigidbody myRigidbody;
    private Animator animator;

    // Use this for initialization
    void Start() {
        myRigidbody = GetComponent<Rigidbody>();
        animator = GetComponentInChildren<Animator>();
    }

    // Update is called once per frame
    void Update() {
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");

        Vector3 movementVector = (Vector3.right * horizontal + Vector3.forward * vertical);
        movementVector.Normalize();
        movementVector *= speed;

        myRigidbody.velocity = movementVector;

        transform.LookAt(transform.position + movementVector);

        if (horizontal != 0 || vertical != 0) {
            animator.SetFloat("Speed", 1);
        } else {
            animator.SetFloat("Speed", 0);
        }
    }

    public void CollectCoin() {
        coinsAmount++;
        coinsText.text = "Moedas: " + coinsAmount.ToString();
    }
}
