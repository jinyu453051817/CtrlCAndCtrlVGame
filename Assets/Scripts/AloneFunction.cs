using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AloneFunction : MonoBehaviour
{
    public Text upText;
    public GameObject rightPrefab;
    public GameObject content;
    public ActorController ac;

    public void ShowDiaInRight()
    {
        GameObject go = Instantiate(rightPrefab, content.transform);
        go.transform.Find("copyotherText").GetComponent<InputField>().text = upText.text;
    }

    public void SetPlayerCanMove()
    {
        ac.pi.inputEnabled = true;
    }

    public void SetPlayerCannotMove()
    {
        ac.pi.inputEnabled = false;
    }
}
