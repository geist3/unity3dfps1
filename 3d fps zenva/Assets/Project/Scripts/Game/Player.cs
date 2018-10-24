using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    private int ammo;
    private int health;

    [Header("Visuals")]
    public Camera playerCamera;
    public GameObject gun;

    [Header("GamePlay")]
    public int initialHealth = 100;
    public int initialAmmo = 10;
    public int Ammo { get { return ammo; } }
    public int Health { get { return health; } }

    // Use this for initialization
    void Start () {
        ammo = initialAmmo;
        health = initialHealth;
	}
	
	// Update is called once per frame
	void Update () {
        if (ammo > 0 && Input.GetMouseButtonDown(0))
        {
            ammo--;
            GameObject bulletObject = ObjectPoolingManager.Instance.GetBullet();
            bulletObject.transform.position = gun.transform.position;
            bulletObject.transform.forward = gun.transform.forward;
        }
	}

    // check for collisions
    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        AmmoCrate ammoCrate = hit.collider.gameObject.GetComponent<AmmoCrate>();
        if (ammoCrate != null)
        {
            ammo += ammoCrate.ammo;
            Destroy(ammoCrate.gameObject);
        }
    }
}
