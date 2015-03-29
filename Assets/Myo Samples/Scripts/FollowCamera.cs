using UnityEngine;
using System.Collections;

// [AddComponentMenu("Camera-Control/Smooth Look At CS")]
public class FollowCamera : MonoBehaviour {
	public Transform target;
	public float damping = 6.0f;	
	public bool smooth = true;
	public float minDistance = 10.0f;
	public string property = "";
	
	private Color color;
	private float alpha = 1.0f;
	private Transform _myTransform;
	
	void Awake() {
		_myTransform = transform;
	}

	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void LateUpdate() {
		if(target) {
			if(smooth) {

				Quaternion rotation = Quaternion.LookRotation(target.position - _myTransform.position);
				_myTransform.rotation = Quaternion.Slerp(_myTransform.rotation, rotation, Time.deltaTime * damping);
			}
			else {
				_myTransform.rotation = Quaternion.FromToRotation(-Vector3.forward, (new Vector3(target.position.x, target.position.y, target.position.z) - _myTransform.position).normalized);
				
				float distance = Vector3.Distance(target.position, _myTransform.position);
				
				if(distance < minDistance) {
					alpha = Mathf.Lerp(alpha, 0.0f, Time.deltaTime * 2.0f);
				}
				else {
					alpha = Mathf.Lerp(alpha, 1.0f, Time.deltaTime * 2.0f);
					
				}
			}
		}
	}
}