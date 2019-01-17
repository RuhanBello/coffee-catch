using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gate : MonoBehaviour {
    public GameObject lasers;

    // Use this for initialization
    private void Start() {
        StartCoroutine(LasersCoroutine());
    }

    IEnumerator LasersCoroutine() {
        while (true) {
            lasers.SetActive(true);
            yield return new WaitForSeconds(2);
            lasers.SetActive(false);
            yield return new WaitForSeconds(2);
        }
    }
}
