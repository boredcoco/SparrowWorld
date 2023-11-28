using System.Collections;
using System.Collections.Generic;
using System.Net;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;

public class RandomImageAPI : MonoBehaviour
{
    [SerializeField] private string category = "city";
    private const string apiUrl = "https://picsum.photos/200/300"; 
    private Sprite uiSprite;

    private void Start()
    {
      StartCoroutine(FetchAndDisplayRandomImage());
    }

    public Sprite GetSprite()
    {
      return uiSprite;
    }

    public IEnumerator FetchAndDisplayRandomImage()
    {
        string url = apiUrl;

        UnityWebRequest www = UnityWebRequestTexture.GetTexture(url);
        www.timeout = 10;

        yield return www.SendWebRequest();

        if (www.result == UnityWebRequest.Result.ConnectionError || www.result == UnityWebRequest.Result.ProtocolError)
        {
            Debug.LogError("Error: " + www.error);
            // Handle the error as needed
        }
        else
        {
            // Convert the downloaded data to a texture
            Texture2D texture = DownloadHandlerTexture.GetContent(www);
            uiSprite = Sprite.Create(texture, new Rect(0.0f, 0.0f, texture.width, texture.height), new Vector2(0.5f, 0.5f), 100.0f);
            Debug.Log(texture);
        }

        www.Dispose();
    }
}
