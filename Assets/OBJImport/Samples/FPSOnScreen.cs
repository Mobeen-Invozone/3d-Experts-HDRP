using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using TMPro;

public class FPSOnScreen : MonoBehaviour
{
    public TextMeshProUGUI fpsText;
    public TextMeshProUGUI texturesText;
    
    public float deltaTime;

    void Update()
    {
        deltaTime += (Time.deltaTime - deltaTime) * 0.1f;
        float fps = 1.0f / deltaTime;
        fpsText.text = Mathf.Ceil(fps).ToString();

        texturesText.text = ObjFromStream.instance.currentTextureNum.ToString() + " / " + ObjFromStream.instance.totalTextures.ToString();
    }
}