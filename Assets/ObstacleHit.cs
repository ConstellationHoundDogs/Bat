using UnityEngine;

public class ObstacleHit : MonoBehaviour {

	// Если этот объект столкнулся с игроком, то нужно вызвать геймовер, анимацию смерти игрока и остановить движение объекта
	void OnTriggerEnter2D(Collider2D other){
		if (other.tag == "Player") {
			GameController.instance.GameOver ();
			PlayerController.instance.Death ();
			this.GetComponent<Rigidbody2D>().velocity = transform.right * 0;
		}
	}
}
