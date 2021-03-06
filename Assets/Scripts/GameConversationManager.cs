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

    private KeybordInput pi;

    // Start is called before the first frame update
    void Start()
    {
        pi = gameObject.GetComponent<KeybordInput>();
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

    private void OnTriggerStay2D(Collider2D collision)
    {
        switch (collision.gameObject.name)
        {
            case "trigger1":
                print("11111");
                if (state == 8)
                {
                    if (pi.hudong)
                    {
                        GameObject.Find("tanhuang").GetComponent<Animator>().SetTrigger("tan");

                        int colLength = collision.transform.parent.Find("trigger2").GetComponent<JumpBan>().colList.Count;
                        //GameObject.Find("tanhuang").GetComponent<Animator>().SetTrigger("tan");

                        if (colLength != 0)
                        {
                            for (int i = 0; i < colLength; i++)
                            {
                                collision.transform.parent.Find("trigger2").GetComponent<JumpBan>().colList[i].GetComponent<Rigidbody2D>().AddForce(new Vector2(0, 1000));
                            }
                        }
                    }
                }
                break;
            case "enemy":
                if (Input.GetMouseButtonDown(0))
                {
                    print("enemy");
                    if (collision.transform.GetComponent<LittleEnemy>() != null)
                    {
                        collision.GetComponent<LittleEnemy>().enabled = false;
                    }
                    collision.transform.localScale = new Vector3(0.2f, -0.2f, 1);
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
