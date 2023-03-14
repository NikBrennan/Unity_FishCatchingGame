using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Animator))]
public class BombDespawn : MonoBehaviour
{
	public float deadZone = -6;
	// Start is called before the first frame update
	void Start()
	{

	}

	// Update is called once per frame
	void Update()
	{
		if (transform.position.y < deadZone)
		{
			Destroy(gameObject);
		}
	}
}
