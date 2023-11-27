using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractableDoor : MonoBehaviour
{
  [SerializeField] private string title;
  [SerializeField] private string description;

  private UiLogicHandler uiLogicHandler;

  private void Start()
  {
    uiLogicHandler = GameObject.Find("UiLogicHandler").GetComponent<UiLogicHandler>();
  }

  private void OnMouseDown()
  {
      uiLogicHandler.UpdateHouseInfoTitle(title);
      uiLogicHandler.UpdateHouseInfoDescription(description);
      uiLogicHandler.SetHouseUIActive();
  }
}
