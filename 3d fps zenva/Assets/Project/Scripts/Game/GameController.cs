using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour {

    [Header("Game")]
    public Player player;

    [Header("UI")]
    public Text healthText;
    public Text ammoText;

    private string oldAmmoText = "";
    private string oldHealthText = "";

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (oldAmmoText != ammoText.text)
        {
            ammoText.text = "Ammo: " + player.Ammo;
        }
        if (oldHealthText != healthText.text)
        {
            healthText.text = "Health: " + player.Health;
        }
    }
}
