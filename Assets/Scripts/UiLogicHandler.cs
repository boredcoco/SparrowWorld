using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UiLogicHandler : MonoBehaviour
{
    [SerializeField] private UIHandler uiHandler;
    [SerializeField] private TMP_Text houseInfoTitle;
    [SerializeField] private TMP_Text houseInfoDescription;

    public void UpdateHouseInfoTitle(string newTitle)
    {
      houseInfoTitle.text = newTitle;
    }

    public void UpdateHouseInfoDescription(string newDescription)
    {
      houseInfoDescription.text = newDescription;
    }

    public void SetHouseUIActive()
    {
      uiHandler.SetHouseInfoActive();
    }
}
