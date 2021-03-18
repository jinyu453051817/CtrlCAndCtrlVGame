using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIRightTextManager : MonoBehaviour
{
    public string[] allText;

    private Text rightText;

    // Start is called before the first frame update
    void Start()
    {
        rightText = transform.Find("copyotherText").Find("Text").GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {

    }
}
