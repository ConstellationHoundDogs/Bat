using UnityEngine;

public class obstacle_move : MonoBehaviour {

	public float speed;
	private Vector2 startPosition;
	private Rigidbody2D rb;

	// Когда объект появляется, он начинает двигаться с заданной скоростью
	void Start ()
	{
		rb = GetComponent<Rigidbody2D>();
		rb.velocity = transform.right * speed;
	}
}
