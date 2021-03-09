using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CtrlCText : MonoBehaviour
{
    public string nowstring = ""; 

    // Start is called before the first frame update
    void Start()
    {
        
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
            else
            {
                if (Input.anyKeyDown)
                {
                    GetComponent<InputField>().text = nowstring;
                    return;
                }
            }
        }

        
        //string str = GUIUtility.systemCopyBuffer;
        //Debug.Log("剪贴板内容：" + str);
    }
}
