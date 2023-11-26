using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIHandler : MonoBehaviour
{
    [SerializeField] private GameObject houseInfoUI;

    public void SetHouseInfoActive()
    {
      houseInfoUI.SetActive(true);
    }

    public void SetHouseInfoInactive()
    {
      houseInfoUI.SetActive(false);
    }
}
