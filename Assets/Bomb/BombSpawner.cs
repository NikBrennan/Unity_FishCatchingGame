using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombSpawner : MonoBehaviour
{
	public GameObject bomb;
	public float spawnRate = 3;
	private float timer = 0;
	public float deadZone = -6;
	// Start is called before the first frame update
	void Start()
    {
        
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
			spawnBomb();
			timer = 0;
		}

		if (transform.position.y < deadZone)
		{
			Destroy(gameObject);
		}
	}

	void spawnBomb()
	{
		Instantiate(bomb, new Vector3(Random.Range(-8, 8), transform.position.y, transform.position.z), transform.rotation);
	}
}
