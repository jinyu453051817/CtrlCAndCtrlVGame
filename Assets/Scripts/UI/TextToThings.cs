using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Fungus;

public class TextToThings : MonoBehaviour
{
    public GameObject goObject;
    public Vector3 offset;
    public float scaleX;
    public float scaleY;

    private Vector3 objVec;
    private Text myText;
    public Text nextText;
    private Flowchart fc;

    // Start is called before the first frame update
    void Start()
    {
        myText = transform.Find("Text").GetComponent<Text>();
        fc = GameObject.Find("Flowchart").GetComponent<Flowchart>();
    }

    // Update is called once per frame
    void Update()
    {
        objVec = goObject.transform.position;
        gameObject.GetComponent<Image>().rectTransform.position = Camera.main.WorldToScreenPoint(new Vector3(objVec.x * scaleX, objVec.y * scaleY, objVec.z) + offset, 0);

        if (Input.GetKeyDown(KeyCode.Return))
        {
            print("return");
            if (myText.text == "石")
            {
                if (nextText.gameObject.name == "qiu")
                {
                    //goObject.GetComponent<Rigidbody2D>().mass = 99999;
                    Sprite[] sprite = Resources.LoadAll<Sprite>("Scenes/level1/ball2");
                    goObject.GetComponent<SpriteRenderer>().sprite = sprite[0];

                    if (GameConversationManager.state == 7)
                    {
                        print("dierguan");
                        fc.ExecuteBlock("level1_8");
                        GameConversationManager.FreezyBall();

                    }
                    else
                    {
                        fc.ExecuteBlock("level1_7");
                    }

                }
            }
            else if(myText.text == "铁")
            {
                if (nextText.gameObject.name == "xiang")
                {
                    //goObject.GetComponent<Rigidbody2D>().mass = 99999;
                    //Sprite[] sprite = Resources.LoadAll<Sprite>("Scenes/level1/ball2");
                    //goObject.GetComponent<SpriteRenderer>().sprite = sprite[0];
                    goObject.GetComponent<SpriteRenderer>().color = Color.black;

                    //if (GameConversationManager.state == 7)
                    //{
                    //    print("dierguan");
                    //    fc.ExecuteBlock("level1_8");
                    //    GameConversationManager.FreezyBall();

                    //}
                    //else
                    //{
                    //    fc.ExecuteBlock("level1_7");
                    //}

                }
            }
        }
    }
}
