using UnityEngine;

public class PlayerController : Singleton<PlayerController> {

	public Animator animator;
	public Animator contAnim;
	public Animator camAnim;
	public GameObject parentCont;
	public int fear;
	private bool live;

	// На старте говорим, что игрок живой
	void Start () {
		PlayerController.instance = this;
		fear = 0;
		live = true;
	}

	// Каждый кадр проверяем, нажата ли кнопка пробела можем ли мы взлететь сейчас
	void Update () {
		if(Input.GetKeyDown("space") && parentCont.transform.position.y <= 130 && live == true) {
			animator.Play("FlyUp");
			contAnim.Play("contFlyUp");
		}
	}

	// Трагично умираем
	public void Death(){
		live = false;
		animator.Play ("death");
		camAnim.Play ("cameraDeath");
	}
}
