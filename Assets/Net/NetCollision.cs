using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NetCollision : MonoBehaviour
{
	public LogicScript logicScript;
	public GameObject netBack;
	// Start is called before the first frame update
	void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

	private void OnTriggerEnter2D(Collider2D collision)
	{
		if (collision.gameObject.tag.Equals("Fish"))
		{
			Destroy(collision.gameObject);
			// give points
			logicScript.addScore(1);
		}
		if (collision.gameObject.tag.Equals("Bomb"))
		{
			Destroy(collision.gameObject);
			// Stop the movement of both net gameobjects
			netBack.GetComponent<NetMovement>().caughtBomb= true;
			gameObject.GetComponent<NetMovement>().caughtBomb = true;
			// set off explosion
			logicScript.playExplosion();
			// gameover
			logicScript.gameOver();
		}

	}
}
