using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CtrlCText : MonoBehaviour
{
    public string nowstring = "";
    public ActorController ac;

    // Start is called before the first frame update
    void Start()
    {
        ac = GameObject.Find("player").GetComponent<ActorController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (GetComponent<InputField>().isFocused)
        {
            

            if (Input.GetKey(KeyCode.LeftControl))
            {
                if (Input.GetKeyDown(KeyCode.V))
                {

                    GetComponent<InputField>().text = GUIUtility.systemCopyBuffer;
                    nowstring = GUIUtility.systemCopyBuffer;
                    print("粘贴");
                }
            }
            else if (ac.pi.backspaceDown)
            {
                if (nowstring.Length != 0)
                {
                    nowstring = nowstring.Substring(0, nowstring.Length - 1);
                    GetComponent<InputField>().text = nowstring;
                }
            }
            else
            {
                print("11111111");
                if (Input.anyKeyDown)
                {
                    print("anyKeyDown");
                    GetComponent<InputField>().text = nowstring;
                    return;
                }
            }
        }

        
        //string str = GUIUtility.systemCopyBuffer;
        //Debug.Log("剪贴板内容：" + str);
    }
}
