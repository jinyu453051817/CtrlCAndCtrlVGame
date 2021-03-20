using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using FitMode = UnityEngine.UI.ContentSizeFitter.FitMode;

public class UIRightTextManager : MonoBehaviour
{
    public string[] allText;

    private Transform rightText;
    private RectTransform bubbleRect;


    // Start is called before the first frame update
    void Start()
    {
        rightText = transform.Find("copyotherText").Find("Text");
        rightText.GetComponent<ContentSizeFitter>().enabled = true;
        bubbleRect = GetComponent<RectTransform>();
        ///强制改变rect的高度
        LayoutRebuilder.ForceRebuildLayoutImmediate(rightText.GetComponent<RectTransform>());
        bubbleRect.sizeDelta = new Vector2(bubbleRect.rect.width, rightText.GetComponent<RectTransform>().rect.height + 80);
    }

    // Update is called once per frame
    void Update()
    {

    }

}
