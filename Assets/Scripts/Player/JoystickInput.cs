//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;

//public class JoystickInput : IUserInput {

//    [Header("===== Joystick Settings =====")]
//    public string axisX = "axisX";
//    public string axisY = "axisY";
//    public string axisJup = "axis5";
//    public string axisJright = "axis4";

//    public float targetTrigger;

   
//    // Update is called once per frame
//    void Update()
//    {
//        Jup = -1 * Input.GetAxis(axisJup);
//        Jright = Input.GetAxis(axisJright);

//        targetDUp = Input.GetAxis(axisY);
//        targetDRight = Input.GetAxis(axisX);

//        Dup = Mathf.SmoothDamp(Dup, targetDUp, ref velocityDUp, 0.1f);
//        Dright = Mathf.SmoothDamp(Dright, targetDRight, ref velocityDRight, 0.1f);

//        Vector2 tempDAxis = SquareToCircle(new Vector2(Dright, Dup));
//        float Dright2 = tempDAxis.x;
//        float Dup2 = tempDAxis.y;

//        Dmag = Mathf.Sqrt((Dup2 * Dup2) + (Dright2 * Dright2));
//        Dvec = Dright2 * transform.right - Dup * transform.up;
//    }
//}
