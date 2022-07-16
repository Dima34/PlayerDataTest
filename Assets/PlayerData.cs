using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class PlayerData
{
    public int Coins;
    public SettingsList Settings = new SettingsList();

    public PlayerData(int coins){
        Coins = coins; 
    }
}

[Serializable]
public class SettingsList {
    public float Volume = 0;
    public Resolution Resolution = Resolutions.GetResolutionByCode(ResolutionCode.R1920x1080);
    public bool IsFullscreen = true;
    public int Quality;
    public ControlsList ControlsList;

    public SettingsList(){

    }

    public SettingsList(float volume, Resolution resolution, bool isFullscreen, int quality, ControlsList controlsList){
        Volume = volume;
        Resolution = resolution;
        IsFullscreen = isFullscreen;
        Quality = quality;
        ControlsList = controlsList;
    }
}

[Serializable]
public class ControlsList{
    public KeyCode Throttle = KeyCode.Space;
    public KeyCode Left = KeyCode.A;
    public KeyCode Right = KeyCode.D;
    public KeyCode Shoot = KeyCode.W;
    public KeyCode Pause = KeyCode.Escape;

    public ControlsList(){

    }

    public ControlsList(ControlsList controlList){
        Throttle = controlList.Throttle;
        Left = controlList.Left;
        Right = controlList.Right;
        Shoot = controlList.Shoot;
        Pause = controlList.Pause;
    }

    public ControlsList(
        KeyCode throttle,
        KeyCode left,
        KeyCode right,
        KeyCode shoot,
        KeyCode pause
    ){
        Throttle = throttle;
        Left = left;
        Right = right;
        Shoot = shoot;
        Pause = pause;
    }
}