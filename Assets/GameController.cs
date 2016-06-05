using UnityEngine;

// Контролирует "системные" процессы игры. Например, геймовер.

public class GameController : Singleton<GameController> {

	public GameObject gameOverTxt;

	void Start () {
		GameController.instance = this;
	}

	// Запускает геймовер - останавливает движение всех объектов и выводит текст геймовера
	public void GameOver () {
		gameOverTxt.SetActive(true);
		ObstacleManager.instance.speedMod = 0;
	}
}
