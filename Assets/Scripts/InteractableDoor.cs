using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InteractableDoor : MonoBehaviour
{
  [SerializeField] private string title;
  [SerializeField] private string description;
  [SerializeField] private RandomImageAPI randomImageApi;

  private Sprite sprite;

  private UiLogicHandler uiLogicHandler;

  private void Start()
  {
    uiLogicHandler = GameObject.Find("UiLogicHandler").GetComponent<UiLogicHandler>();
    sprite = randomImageApi.GetSprite();
  }

  private void Update()
  {
    Debug.Log(sprite);
    if (sprite != null)
    {
      return;
    }
    sprite = randomImageApi.GetSprite();
  }

  private void OnMouseDown()
  {
      uiLogicHandler.UpdateHouseInfoImage(sprite);
      uiLogicHandler.UpdateHouseInfoTitle(title);
      uiLogicHandler.UpdateHouseInfoDescription(description);
      uiLogicHandler.SetHouseUIActive();
  }
}
