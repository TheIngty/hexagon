using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {

    public float spawnRate = 1f;
    public float nextTimeToSpawn = 0f;

    public GameObject hexagon;
	
	
	void Update () {
		if (Time.time >= nextTimeToSpawn)
        {
            Instantiate(hexagon, Vector3.zero, Quaternion.identity);
            nextTimeToSpawn = Time.time + 1f / spawnRate;
        }
	}
}
