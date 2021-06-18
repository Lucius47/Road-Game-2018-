using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPV : MonoBehaviour
{

	public float speed = 6;

	void Start ()
	{
		
	}

	void Update ()
	{
		transform.Translate (Vector3.back * speed * Time.deltaTime);
		if (transform.position.z < -10) {
			Destroy (gameObject);
		}
	}
}
