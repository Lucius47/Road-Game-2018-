using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

	public float speed = 7;
	Collider collider;

	void Start ()
	{
		//rigidBody = GetComponent <Rigidbody> ();
		Mathf.Clamp (transform.position.x, -1f, 1f);		 
	}

	void Update ()
	{
		float inputX = Input.GetAxisRaw ("Horizontal");
		transform.Translate (Vector3.right * inputX * speed * Time.deltaTime);
		if (transform.position.x < -1.4f) {
			transform.position = new Vector3 (-1.4f, 0.25f, -8f);
		}
		if (transform.position.x > 1.4f) {
			transform.position = new Vector3 (1.4f, 0.25f, -8f);
		}



	}

	void OnTriggerEnter (Collider triggerCollider)
	{
		if (triggerCollider.tag == "NPV") {
			Destroy (gameObject);
		}

	}

}
