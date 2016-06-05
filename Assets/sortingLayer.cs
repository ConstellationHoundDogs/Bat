using UnityEngine;

public class sortingLayer : MonoBehaviour {
	public string sorting;

	void Start () {
		GetComponent<Renderer>().sortingLayerName = sorting;
	}
}