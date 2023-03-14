using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LogicScript : MonoBehaviour
{
    public int playerScore;
    public Text scoreText;
    public GameObject explosionPrefab;
    public GameObject gameOverScreen;
	public GameObject fishSpawner;
	public GameObject bombSpawner;

	public void addScore(int val)
    {
        playerScore++;
        scoreText.text = playerScore.ToString();
    }

    public void playExplosion()
    {
		Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
		mousePosition.z += Camera.main.nearClipPlane;
		Instantiate(explosionPrefab, mousePosition, transform.rotation);
    }

    public void restartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void gameOver()
    {
        fishSpawner.GetComponent<FishSpawner>().enabled = false;
		bombSpawner.GetComponent<BombSpawner>().enabled = false;
		gameOverScreen.SetActive(true);
    }
}
