using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPVSpawner : MonoBehaviour
{
	float nextSpawnTime;
	public GameObject incomingV;
	Vector3 spawnPosition;
	Vector2 secondsBetweenSpawnsMinMax;

	void Start ()
	{
		

	}


	void Update ()
	{
		spawnPosition = new Vector3 (Random.Range (-1.3f, 1.3f), 0.125f, 0);
		if (Time.time > nextSpawnTime) {
			float secondsBetweenSpawns = 0.5f;
			nextSpawnTime = Time.time + secondsBetweenSpawns;


			GameObject newBlock = (GameObject)Instantiate (incomingV, spawnPosition, Quaternion.identity);
		}
	}
}
