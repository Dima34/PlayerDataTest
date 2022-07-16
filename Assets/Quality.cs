using System;

[Serializable]
class Quality{
    string _name;
    int _settingIndex;

    public Quality(string name, int settingIndex){
        _name = name;
        _settingIndex = settingIndex;
    }

    public string GetName(){
        return _name;
    }

    public int GetSettingIndex(){
        return _settingIndex;
    }
}



public static Quality[] QualityList = new Quality[]{
    new Quality("Low", 0),
    new Quality("Low", 0),
    new Quality("Low", 0),
    new Quality("Low", 0),
};

enum QualityCode
{
    Low = 0, 
    Medium = 1,
    High = 2,
    Ultra = 3
}

