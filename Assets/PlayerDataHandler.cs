using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class PlayerDataHandler : MonoBehaviour
{
  PlayerData data;
  SettingsList settings;

  string _dataFileName = "Data";
  string _dataDirectoryPath;
  string _dataFilePath;

  void Start()
  {
    _dataDirectoryPath = Application.dataPath + "/Data/";
    _dataFilePath = _dataDirectoryPath + _dataFileName + ".json";

    settings = new SettingsList();
    data = new PlayerData(20);

    checkData();
  }

  public void AddCoin()
  {
    data.Coins += 1;
  }

  string getJsonLine(PlayerData data)
  {
    return JsonUtility.ToJson(data);;
  }

  bool isDataExist()
  {
    return File.Exists(_dataFilePath);
  }

  void checkData()
  {

    // if data doesn`t exist
    if (!isDataExist())
    {
      Directory.CreateDirectory(_dataDirectoryPath);
      File.Create(_dataFilePath).Close();

      writeDefaultData();
    }
    // if data exists
    else{
      Debug.Log("File exist");
      startDataGettingSequence();
    }
  }

  void writeDefaultData(){
    PlayerData playerData = new PlayerData();

    // Get Json string of player`s data
    string jsonedData = getJsonLine(playerData);

    StreamWriter dataFile = new StreamWriter(_dataFilePath);
    dataFile.WriteLine(jsonedData);

    dataFile.Close();
  }

  void startDataGettingSequence(){
    string recievedJsonData = File.ReadAllLines(_dataFilePath)[0];

    PlayerData recievedDataObj = JsonUtility.FromJson<PlayerData>(recievedJsonData);

    Debug.Log("Data cecieved.");
    recievedDataObj.Print();
  }

}
