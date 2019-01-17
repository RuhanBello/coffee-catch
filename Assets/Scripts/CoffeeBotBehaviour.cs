using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CoffeeBotBehaviour : MonoBehaviour {
    public GameManager gameManager;

    public GameObject gameOverScreen;

    public GameObject firstCoffeeCup;
    public GameObject secondCoffeeCup;

    private void OnCollisionEnter(Collision collision) {
        if (collision.gameObject.CompareTag("Player")) {
            TopDownController controller = collision.gameObject.GetComponent<TopDownController>();
            if (controller.coinsAmount >= 5) {
                StartCoroutine(MakeCoffee());
            }
        }
    }

    IEnumerator MakeCoffee() {
        gameManager.GameOver();

        yield return new WaitForSeconds(2);

        GetComponent<Animator>().SetTrigger("MakeCoffee");
        firstCoffeeCup.SetActive(true);

        yield return new WaitForSeconds(2);
        firstCoffeeCup.SetActive(false);
        secondCoffeeCup.SetActive(true);

        yield return new WaitForSeconds(1);

        gameOverScreen.SetActive(true);
    }
}
