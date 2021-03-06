﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
namespace Universe 
{
public class LeftBuildingWindow : MonoBehaviour 
{
    public Button newBuilding;
    public Button open;
    public Button upgrade;
    public Button recycle;

    void Awake()
    {
        Manager.EventManager.Instance.AddListener(Manager.GameEvent.LOOK_BUILDING, OnLookingBuilding);
    }
    void OnLookingBuilding(Manager.GameEvent eventType, Component sender, object param = null)
    {
        Debug.Assert(eventType == Manager.GameEvent.LOOK_BUILDING);
        if (sender == null)
        {
            NoBuilding();
            return;
        }
        ExistsBuilding();
    }

    void NoBuilding()
    {
        newBuilding.gameObject.SetActive(true);
        open.gameObject.SetActive(false);
        upgrade.gameObject.SetActive(false);
        recycle.gameObject.SetActive(false);
    }
    void ExistsBuilding()
    {
        newBuilding.gameObject.SetActive(false);
        open.gameObject.SetActive(true);
        upgrade.gameObject.SetActive(true);
        recycle.gameObject.SetActive(true);
    }
}
}