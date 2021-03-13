using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerController : MonoBehaviour {

    public GameObject knife;

    private float min_Y = -8f;
    private float max_Y = 0f;

	// Use this for initialization
	void Start () {
        StartCoroutine(StartSpawning());
	}
	
    IEnumerator StartSpawning() {
        yield return new WaitForSeconds(Random.Range(1f, 2f));

        GameObject knifeClone = Instantiate(knife);

        float y = Random.Range(min_Y, max_Y);

        knifeClone.transform.position = new Vector2(transform.position.x, y);

        // the coroutine will call it self
        StartCoroutine(StartSpawning());

    }
	
} // class
