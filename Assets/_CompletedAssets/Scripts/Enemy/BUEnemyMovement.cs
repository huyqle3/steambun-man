using UnityEngine;
using System.Collections;

namespace CompleteProject
{
	public class BUEnemyMovement : MonoBehaviour
	{
		Transform player;               // Reference to the player's position.
		PlayerHealth playerHealth;      // Reference to the player's health.
		BUEnemyHealth enemyHealth;        // Reference to this enemy's health.
		NavMeshAgent nav;               // Reference to the nav mesh agent.
		
		// public Vector3 currentPlayerPos;

		void Awake ()
		{
			// Set up the references.
			player = GameObject.FindGameObjectWithTag ("Player").transform;
			playerHealth = player.GetComponent <PlayerHealth> ();
			enemyHealth = GetComponent <BUEnemyHealth> ();
			nav = GetComponent <NavMeshAgent> ();
			// nav.SetDestination (currentPlayerPos);
		}
		
		
		void Update ()
		{
			// If the enemy and the player have health left...

			// "SetDestination" can only be called on an active agent that has been placed on a NavMesh.

			if (enemyHealth.currentHealth > 0 && playerHealth.currentHealth > 0) {
				// ... set the destination of the nav mesh agent to the player.
				nav.SetDestination (player.position);
				// currentPlayerPos = player.position;

			} else {
				nav.enabled = false;
			}
		}
	}
}