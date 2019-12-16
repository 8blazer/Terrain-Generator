using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Numbers : MonoBehaviour
{
    public int level = 5;
    public int health = 100;
    public Text healthText;
    public Text levelText;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("w"))
        {
            health++;
        }
        if (Input.GetKeyDown("s"))
        {
            health--;
        }
        if (Input.GetKeyDown("up"))
        {
            level++;
        }
        if (Input.GetKeyDown("down"))
        {
            level--;
        }
        healthText.text = "Health: " + health;
        levelText.text = "Level: " + level;
    }

    public void SavePlayer()
    {
        SaveSystem.SavePlayer(this);
    }
    public void LoadPlayer()
    {
        PlayerData data = SaveSystem.LoadPlayer();
        level = data.level;
        health = data.health;
    }
}
