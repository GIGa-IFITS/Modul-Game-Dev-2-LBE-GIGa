using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class Obstacle : MonoBehaviour {

	private void OnTriggerEnter(Collider other) {
		Player player = other.GetComponent<Player>();
		if(player != null) {
			GameOverMenu gameOverMenu = FindObjectOfType<GameOverMenu>();
			gameOverMenu.SetScore(player.Coin);
			gameOverMenu.Show();
			Destroy(player.gameObject);
		}
	}

}
