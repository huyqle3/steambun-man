using UnityEngine;
using System.Collections;

public class WeaponBunMovement : MonoBehaviour {


	void Awake ()
	{
		// startTime = Time.time;
	}
	
	
	void Update ()
	{

		this.gameObject.transform.position +=  this.gameObject.transform.forward;
			
	}

	// void OnCollisionEnter(Collision collision) {
	//	Destroy (this.gameObject);
	//}
}
