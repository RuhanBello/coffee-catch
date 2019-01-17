using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CoffeeBotBehaviour : MonoBehaviour {
    public GameManager gameManager;

    public GameObject gameOverScreen;

    private void OnCollisionEnter(Collision collision) {
        if (collision.gameObject.CompareTag("Player")) {
            TopDownController controller = collision.gameObject.GetComponent<TopDownController>();
            if (controller.coinsAmount >= 5) {
                gameManager.GameOver();
                gameOverScreen.SetActive(true);
            }
        }
    }
}
