using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public static class Resolutions
{
    
    Resolution[] _resolutionsList = new Resolution[]{
        new Resolution(1920,1080,0,"1920x1080"),
        new Resolution(1600,900,1,"1600x900"),
        new Resolution(1440,900,2,"1440x900"),
        new Resolution(1366,768,3,"1566x768"),
        new Resolution(1280,1024,4,"1280x1024"),
        new Resolution(1280,720,5,"1280x720"),
    };

    public Resolution GetResolution(ResolutionIndex resIndex){
        return _resolutionsList[((int)resIndex)];
    }
}

enum ResolutionIndex
{
    r1920x1080 = 0,
    r1600x900 = 1,
    r1440x900 = 2,
    r1366x768 = 3,
    r1280x1024 = 4,
    r1280x720 = 5
}

public class Resolution{
    int _width;
    int _height;
    int _resIndex;
    string _name;

    public Resolution(int width, int height, int resIndex, string name){
        _width = width;
        _height = height;
        _resIndex = resIndex;
        _name = name;
    }

    public int GetWidth(){
        return _width;
    }

    public int GetHeight(){
        return _height;
    }

    public int GetResIndex(){
        return _resIndex;
    }
}


