using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

public class GameOverMenu : MonoBehaviour {

	[SerializeField] private Text text;

	private void Start() {
		Hide();
	}

	public void Show() {
		gameObject.SetActive(true);
	}

	public void Retry() {
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
	}

	public void MainMenu() {
		SceneManager.LoadScene("Main Menu");
	}

	public void SetScore(int score) {
		text.text = "Koin : " + score;
	}

	public void Hide() {
		gameObject.SetActive(false);
	}
}
