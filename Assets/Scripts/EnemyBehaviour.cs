using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.AI;

public class EnemyBehaviour : MonoBehaviour {
    private Transform playerTransform;
    private Animator animator;
    private NavMeshAgent navMeshAgent;

    private void Start() {
        playerTransform = GameObject.Find("Player").transform;

        animator = GetComponent<Animator>();
        animator.SetFloat("Speed", 1);

        navMeshAgent = GetComponent<NavMeshAgent>();
    }

    private void Update() {
        navMeshAgent.SetDestination(playerTransform.position);
    }

    private void OnCollisionEnter(Collision col) {
        if (col.gameObject.CompareTag("Player")) {
            SceneManager.LoadScene(0);
        }
    }
}
