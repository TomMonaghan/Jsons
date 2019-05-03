using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPrefsJSON : MonoBehaviour
{

    public Profiles profiles;

    private string json;
    // Start is called before the first frame update
    void Start()
    {
      
    }

    public void Save()
    {
        //MakeJson
        json = JsonUtility.ToJson(profiles, true);
        PlayerPrefs.SetString("AllProfiles", json);

        print(json);
    }

    public void Load()
    {
        //fill in class from JSON data
        json = PlayerPrefs.GetString("AllProfiles");
        
        profiles = JsonUtility.FromJson<Profiles>(json);
    }
    
}
