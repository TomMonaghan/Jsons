using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[Serializable]
public class PlayerPreferences
{

    public string playerName;
    public int fireKey;
    public string[] skinNames;

}

[Serializable]
public class Profiles
{
    public PlayerPreferences[] players;
}