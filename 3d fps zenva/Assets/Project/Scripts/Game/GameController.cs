using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour {

    [Header("Game")]
    public Player player;

    [Header("UI")]
    public Text ammoText;

    private string oldText = "";

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (oldText != ammoText.text)
        {
            ammoText.text = "Ammo: " + player.Ammo;
        }
	}
}
