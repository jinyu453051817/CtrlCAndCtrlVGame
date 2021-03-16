using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AloneFunction : MonoBehaviour
{
    public Text upText;
    public GameObject rightPrefab;
    public GameObject content;

    public void ShowDiaInRight()
    {
        print("upText:" + upText.text);
        GameObject go = Instantiate(rightPrefab, content.transform);
        go.transform.Find("copyotherText").GetComponent<InputField>().text = upText.text;
    }
}
