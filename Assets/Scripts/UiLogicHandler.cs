using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UiLogicHandler : MonoBehaviour
{
    [SerializeField] private UIHandler uiHandler;
    [SerializeField] private Image houseInfoImage;
    [SerializeField] private TMP_Text houseInfoTitle;
    [SerializeField] private TMP_Text houseInfoDescription;

    public void UpdateHouseInfoImage(Sprite sprite)
    {
      houseInfoImage.sprite = sprite;
    }

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
