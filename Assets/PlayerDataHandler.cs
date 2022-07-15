using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDataHandler : MonoBehaviour
{
    PlayerData data;


    void Start()
    {
        data = new PlayerData(20);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddCoin(){
        data.coins += 1;
        Debug.Log("Coin amount - " + data.coins);
    }

    public void CreateJson(){
        // TODO
    }
}
