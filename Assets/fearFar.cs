using UnityEngine;

public class fearFar : MonoBehaviour {

	void OnTriggerEnter2D(Collider2D other){
		if (other.tag == "Player") {
			PlayerController.instance.fear +=1;
		}
	}
}
