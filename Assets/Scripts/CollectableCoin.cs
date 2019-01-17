using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CollectableCoin : MonoBehaviour {
    public float rotationSpeed;

    public GameObject collectParticles;

    // Update is called once per frame
    void Update() {
        transform.Rotate(Vector3.up * Time.deltaTime * rotationSpeed);
    }

    private void OnTriggerEnter(Collider other) {
        if (other.CompareTag("Player")) {
            other.GetComponent<TopDownController>().CollectCoin();
            Instantiate(collectParticles, transform.position, Quaternion.identity);
            Destroy(this.gameObject);
        }
    }
}
