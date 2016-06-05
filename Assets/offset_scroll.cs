using UnityEngine;

public class offset_scroll : MonoBehaviour {

	public float scrollSpeed;
	private Vector2 savedOffset;
	
	void Start () {
		savedOffset = GetComponent<Renderer>().sharedMaterial.GetTextureOffset ("_MainTex");
	}
	
	void Update () {
		if (ObstacleManager.instance.speedMod > 0){
			float x = Mathf.Repeat (Time.time * scrollSpeed, 1);
			Vector2 offset = new Vector2 (x, savedOffset.y);
			GetComponent<Renderer>().sharedMaterial.SetTextureOffset ("_MainTex", offset);
		}
	}
	
	void OnDisable () {
		GetComponent<Renderer>().sharedMaterial.SetTextureOffset ("_MainTex", savedOffset);
	}
}
