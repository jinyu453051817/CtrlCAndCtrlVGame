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
    public Transform rightContent;
    public CopyManager cm;

    public GameObject level2Fire;
    public GameObject level2Case;
    public GameObject level2Dong;
    public GameObject level2Right;

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
        Rigidbody2D ball = GameObject.Find("ball").GetComponent<Rigidbody2D>();
        ball.constraints = RigidbodyConstraints2D.None;
        ball.AddForce(new Vector2(-50,0));
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
        GameObject.Find("text_level1_1").GetComponent<InputField>().text = "木";
        ac.transform.position = new Vector3(-6.77f, -3.22f, 0);
        GameObject.Find("ball").transform.position = new Vector3(-5.1f, -2.58f, 0);
        Sprite[] sprite = Resources.LoadAll<Sprite>("Scenes/level1/bowl1");
        GameObject.Find("ball").GetComponent<SpriteRenderer>().sprite = sprite[0];
    }

    public void SetPlayerPos()
    {
        ac.transform.position = new Vector3(fc.GetFloatVariable("PlayerX"), fc.GetFloatVariable("PlayerY"), 0);
    }

    public void ClearRight()
    {
        for (int i = 0; i < rightContent.childCount; i++)
        {
            Destroy(rightContent.GetChild(i).gameObject);
        }
    }

    public void CloseTextShow()
    {
        cm.gameObject.SetActive(false);
    }

    public void ShowTextChange()
    {
        cm.ChangeTextLevelShow(fc.GetIntegerVariable("TextState"));
    }

    public void Level2WaterDown()
    {
        level2Case.SetActive(false);
        level2Fire.SetActive(false);
        level2Dong.SetActive(false);
        level2Right.SetActive(false);
    }
}
