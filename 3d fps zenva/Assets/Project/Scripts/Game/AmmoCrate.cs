using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmmoCrate : MonoBehaviour {

    [Header("visuals")]
    public GameObject container;
    public float rotationSpeed = 180f;

    [Header("Gameplay")]
    public int ammo = 10;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        container.transform.Rotate(Vector3.up * rotationSpeed * Time.deltaTime);
	}
}
