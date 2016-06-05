using UnityEngine;
using System.Collections;

public class ObstacleManager : Singleton<ObstacleManager> {
	public float spawnWait;
	public Transform obstSpawnPlace;
	public GameObject pike;
    public int speedMod;

	private Vector2 spawnPlace;

	void Start () {
		ObstacleManager.instance = this;
		//speedMod = 1;
		//spawnPlace = new Vector2 (578.0f, 105.0f);
		StartCoroutine(SpawnObstacle());	
	}

	IEnumerator SpawnObstacle(){
		for(int i = 0; i<100; i++) {
            Instantiate(pike, new Vector2 (Random.Range(378f, 578.0f), 105.0f), Quaternion.identity);
            Instantiate(pike, new Vector2(Random.Range(778f,978.0f),305.0f), Quaternion.Euler(180F, 0F, 0F));
            // Instantiate(pike, spawnPlace, Quaternion.identity);
            yield return new WaitForSeconds(spawnWait);
            if (ObstacleManager.instance.speedMod == 0) {
				yield break;
			}
		}
	}
}
