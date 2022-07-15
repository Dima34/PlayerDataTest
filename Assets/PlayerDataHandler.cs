using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDataHandler : MonoBehaviour
{
    PlayerData data;
    SettingsList settings;


    void Start()
    {
        settings = new SettingsList();
        data = new PlayerData(20);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddCoin(){
        data.Coins += 1;
        CreateJson();
    }

    public void CreateJson(){
        string JsonedData = JsonUtility.ToJson(data);
        Debug.Log(JsonedData);
        // TODO
    }
}
