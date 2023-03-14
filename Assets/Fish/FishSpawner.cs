using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishSpawner : MonoBehaviour
{
	public GameObject fish;
	public float spawnRate = 3;
	private float timer = 0;
	// Start is called before the first frame update
	void Start()
    {
		transform.Rotate(0, 0, 90);
	}

	// Update is called once per frame
	void Update()
	{
		if (timer < spawnRate)
		{
			timer = timer + Time.deltaTime;
		}
		else
		{
			spawnFish();
			timer = 0;
		}
	}

	void spawnFish()
	{
		Instantiate(fish, new Vector3(Random.Range(-8, 8), transform.position.y, transform.position.z), transform.rotation);
	}
}
