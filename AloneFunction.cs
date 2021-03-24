using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Fungus;

public class AloneFunction : MonoBehaviour
{
    public Text upText;
    public GameObject rightPrefab;
    public GameObject content;
    public ActorController ac;
    public GameConversationManager gcm;
    public Flowchart fc;

    public void ShowDiaInRight()
    {
        GameObject go = Instantiate(rightPrefab, content.transform);
        go.transform.Find("copyotherText").GetComponent<InputField>().text = upText.text;
    }

    public void SetPlayerCanMove()
    {
        
        ac.pi.inputEnabled = fc.GetBooleanVariable("inputEnable");
    }

    public void SetGameState()
    {
        GameConversationManager.state = fc.GetIntegerVariable("state");
    }

    public void WindPower()
    {
        if (GameConversationManager.state != 7)
        {
            Rigidbody2D ball = GameObject.Find("ball").GetComponent<Rigidbody2D>();
            ball.constraints = RigidbodyConstraints2D.None;
            ball.AddForce(new Vector2(-50, 0));
        }
        
    }

    public void CanShowText()
    {
        ac.canShowText = true;
    }

    public void CantShowText()
    {
        ac.canShowText = false;
    }

    public void ResetLevel1()
    {
        GameObject.Find("muxiang").GetComponent<InputField>().text = "木";
        print(GameObject.Find("muxiang").GetComponent<InputField>().text);
        ac.transform.position = new Vector3(-6.77f, -3.22f, 0);
        GameObject.Find("ball").transform.position = new Vector3(-5.1f, -2.58f, 0);
    }
}
