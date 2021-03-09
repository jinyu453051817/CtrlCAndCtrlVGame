using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyTimer{

    public enum STATE
    {
        IDLE,
        RUN,
        FINISHIED
    }
    public STATE state;

    public float duration = 1.0f;//撑多久

    private float elapseTime = 0f;//流逝的时间

    public void Tick()
    {
        switch(state){
            case STATE.IDLE:
                break;
            case STATE.RUN:
                elapseTime += Time.deltaTime;
                if (elapseTime >= duration)
                {
                    state = STATE.FINISHIED;
                }
                break;
            case STATE.FINISHIED:
                break;
            default:
                Debug.Log("MyTimer Error");
                break;
        }
    }

    public void Go()
    {
        elapseTime = 0f;
        state = STATE.RUN;
    }
	
}
