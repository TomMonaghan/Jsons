using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPrefsTest : MonoBehaviour
{
    // Start is called before the first frame update

    public string playerName;
    void Start()
    {
               
        //load a value
        
       

       
       
    }


    public void LoadPlayerPrefs()
    {
        if (PlayerPrefs.HasKey("PlayerName"))
        {
            playerName = PlayerPrefs.GetString("PlayerName");
        }
    }
    
    public void SavePlayerPrefs()
    {
        
            //Save a value
            PlayerPrefs.SetString("PlayerName", playerName);
        

    }
    
    // Update is called once per frame
    void Update()
    {
        
    }
}
