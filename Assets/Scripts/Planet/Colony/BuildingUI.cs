﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Manager;
namespace Universe 
{
/// <summary>
/// 用于打开各种Building的UI面板
/// </summary>
public class BuildingUI : MonoSingleton<BuildingUI>
{
    public BuildingBase New(BuildingType type)
    {
        return null;
    }
    public void Open(BuildingBase building)
    {
        Debug.Log("Open"+building.Type);
    }
    public void Upgrade(BuildingBase building)
    {
        Debug.Log("Upgrade"+building.Type);
    }
    public void Recycle(BuildingBase building)
    {
        Debug.Log("Recycle"+building.Type);
    }
}
}