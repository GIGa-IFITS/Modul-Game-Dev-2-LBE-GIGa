using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class HUDCoin : MonoBehaviour {

	private Player player;
	private Text text;

	void Start() {
		text = GetComponent<Text>();
		player = FindObjectOfType<Player>();
	}
	
	void Update() {
		text.text = "Koin : " + player.Coin;
	}
}
