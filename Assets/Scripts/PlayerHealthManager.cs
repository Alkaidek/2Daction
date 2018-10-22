using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealthManager : MonoBehaviour {
    public int playerMaxHealth;
    public int playerCurrentHealth;
    public GameObject[] respawns;
    public GameOverManager GameOverManager;
    public heartController[] heartController;
    // Use this for initialization
    void Start () {
        playerCurrentHealth = playerMaxHealth;
        heartController = GameObject.FindObjectsOfType(typeof(heartController)) as heartController[];
    }
	
	// Update is called once per frame
	void Update () {
      
        if (playerCurrentHealth <= 0)
        {
            //respawns = GameObject.FindGameObjectsWithTag("gameover");
            //respawns[0].SetActive(true);
            GameOverManager = GameObject.FindObjectOfType(typeof(GameOverManager)) as GameOverManager;
            GameOverManager.ShowElement();
            gameObject.SetActive(false);
        }
	}
    public void HurtPlayer(int damageToGive)
    {   
 
        var tag = ((playerCurrentHealth) / 10);
        if (tag >= 0)
        {
            var loop = heartController.Length;
            for (int i = 0; i < loop; i++)
            {
                heartController[i].HideElement('h' + tag.ToString());
            }
        }
        playerCurrentHealth -= damageToGive;
    }
    public void SetMaxHealth()
    {
        playerCurrentHealth = playerMaxHealth;
    }
}
