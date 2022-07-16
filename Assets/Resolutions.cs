using System;

public static class Resolutions
{
    static Resolution[] _resolutionsList = new Resolution[]
    {
        new Resolution(1920, 1080, "1920x1080"),
        new Resolution(1600, 900, "1600x900"),
        new Resolution(1440, 900, "1440x900"),
        new Resolution(1366, 768, "1366x768"),
        new Resolution(1280, 1024, "1280x1024"),
        new Resolution(1280, 720, "1280x720"),
    };

    static public Resolution GetResolutionByCode(ResolutionCode resolutionCode)
    {
        return _resolutionsList[(int)resolutionCode];
    }

    static public Resolution GetResolutionByIndex(int index)
    {
        if (index < _resolutionsList.Length)
            return _resolutionsList[index];
        else
            throw new Exception("Resolution index out of bounds");
    }

    static public Resolution[] GetResolutionsList(){
        return _resolutionsList;
    }
}

public enum ResolutionCode
{
    R1920x1080 = 0,
    R1600x900 = 1,
    R1440x900 = 2,
    R1366x768 = 3,
    R1280x1024 = 4,
    R1280x720 = 5,
}

[Serializable]
public class Resolution{
    int _width;
    int _height;
    string _name;

    public Resolution(int width, int height, string name){
        _width = width;
        _height = height;
        _name = name;
    }

    public int GetWidth(){
        return _width;
    }

    public int GetHeight(){
        return _height;
    }

    public override string ToString()
    {
        return (_width + "x" + _height);
    }
}


