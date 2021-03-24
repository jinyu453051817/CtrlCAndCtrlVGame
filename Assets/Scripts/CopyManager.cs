using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CopyManager : MonoBehaviour
{
    public GameObject[] texts;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    /// <summary>
    /// 文字显示（按照关卡）
    /// </summary>
    /// <param name="t"></param>
    public void ChangeTextLevelShow(int t)
    {
        for (int i = 0; i < texts.Length; i++)
        {
            texts[i].SetActive(false);
        }
        texts[t].SetActive(true);
    }
}
