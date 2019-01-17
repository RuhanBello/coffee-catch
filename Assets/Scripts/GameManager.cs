using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class GameManager : MonoBehaviour {
    public TopDownController characterController;
    public Animator playerAnimator;

    public NavMeshAgent enemyNavMeshAgent;
    public Animator enemyAnimator;

    public void GameOver() {
        characterController.enabled = false;
        characterController.StopMoving();
        playerAnimator.SetFloat("Speed", 0);

        enemyNavMeshAgent.enabled = false;
        enemyAnimator.SetFloat("Speed", 0);
    }
}
