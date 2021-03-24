using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;

public class GameConversationManager : MonoBehaviour
{
    public static int state = 0;

    public AloneFunction af;
    public Flowchart fc;
    public CopyManager cm;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        switch (collision.gameObject.name)
        {
            case "trigger1":
                if (state == 1)
                {
                    cm.ChangeTextLevelShow(0);
                    fc.ExecuteBlock("level1_2");
                    FreezyBall();
                }
                else if (state == 3)
                {
                    fc.ExecuteBlock("level1_4");
                    FreezyBall();
                }
                else if (state == 5)
                {
                    fc.ExecuteBlock("level1_6");
                    FreezyBall();
                }
                else if(state == 8)
                {
                    int colLength = collision.transform.parent.Find("trigger2").GetComponent<JumpBan>().colList.Count;
                    if (colLength != 0)
                    {
                        for (int i = 0; i < colLength; i++)
                        {
                            collision.transform.parent.Find("trigger2").GetComponent<JumpBan>().colList[i].GetComponent<Rigidbody2D>().AddForce(new Vector2(0, 1000));
                        }
                    }
                }
                break;
            case "trigger2":
                if (state == 2)
                {
                    fc.ExecuteBlock("level1_3");
                }
                else if (state == 4)
                {
                    fc.ExecuteBlock("level1_5");
                }
                else if (state == 6)
                {
                    af.WindPower();
                }
                break;
            default:
                break;
        }
    }

    public static void FreezyBall()
    {
        Rigidbody2D ball = GameObject.Find("ball").GetComponent<Rigidbody2D>();
        ball.velocity = Vector2.zero;
        ball.constraints = RigidbodyConstraints2D.FreezeAll;
    }
}
