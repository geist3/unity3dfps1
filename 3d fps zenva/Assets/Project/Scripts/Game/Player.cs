using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {


    [Header("Visuals")]
    public Camera playerCamera;

    [Header("GamePlay")]
    public int initialAmmo = 10;
    public int Ammo { get { return ammo; } }
    private int ammo;

    // Use this for initialization
    void Start () {
        ammo = initialAmmo;
	}
	
	// Update is called once per frame
	void Update () {
        if (ammo > 0 && Input.GetMouseButtonDown(0))
        {
            ammo--;
            GameObject bulletObject = ObjectPoolingManager.Instance.GetBullet();
            bulletObject.transform.position = playerCamera.transform.position;
            bulletObject.transform.forward = playerCamera.transform.forward;
        }
	}
}
