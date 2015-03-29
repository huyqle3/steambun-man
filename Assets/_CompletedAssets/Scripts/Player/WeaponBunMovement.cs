using UnityEngine;
using System.Collections;

namespace CompleteProject
{
	public class WeaponBunMovement : MonoBehaviour
	{
		Transform player;               // Reference to the player's position.
		BUEnemyHealth enemyHealth;        // Reference to this enemy's health.
		NavMeshAgent nav;               // Reference to the nav mesh agent.

		
		// public Vector3 currentPlayerPos;
		
		void Awake ()
		{
			// Set up the references.
			player = GameObject.FindGameObjectWithTag ("Player").transform;
			enemyHealth = GetComponent <BUEnemyHealth> ();
			nav = GetComponent <NavMeshAgent> ();
			// nav.SetDestination (currentPlayerPos);
		}
		
		
		void Update ()
		{
			// If the enemy and the player have health left...
			
			// "SetDestination" can only be called on an active agent that has been placed on a NavMesh.
			

		}
	}
}