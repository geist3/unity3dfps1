using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {

    public float speed = 8f;
    public float lifeDuration = 2f;

    private float lifeTimer;

	// Use this for initialization
	void OnEnable () {
        lifeTimer = lifeDuration;
	}
	
	// Update is called once per frame
	void Update () {
        transform.position += transform.forward * speed * Time.deltaTime;

        lifeTimer -= Time.deltaTime;
        if(lifeTimer <= 0f)
        {
            gameObject.SetActive(false);
        }
	}
}
