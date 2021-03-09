using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 键盘输入
/// </summary>
public class KeybordInput :IUserInput {

    //键盘按键
    [Header("===== key settings =====")]
    public string keyJump;
    public string keyB;
    public string keyC;
    public string keyD;

    public MyButton KeyA = new MyButton();
    public MyButton KeyB = new MyButton();
    //public MyButton KeyC = new MyButton();


    void Update()
    {
        KeyA.Tick(Input.GetButton(keyJump));
        //KeyC.Tick(Input.GetButton(keyC));

        targetDRight = Input.GetAxis("Horizontal");

        if (inputEnabled == false)
        {
            targetDRight = 0;
        }

        Dright = Mathf.SmoothDamp(Dright, targetDRight, ref velocityDRight, 0.1f);
        if (Mathf.Abs(Dright) <= 0.001f)
        {
            Dright = 0;
        }
        Dvec = new Vector2(Dright, 0);

        isJump = KeyA.OnPressed;
    }

}
