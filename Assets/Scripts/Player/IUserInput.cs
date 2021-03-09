using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class IUserInput : MonoBehaviour {

    [Header("===== Output signals =====")]
    public float Dright;
    public Vector2 Dvec;

    [Header("===== Others =====")]

    public bool inputEnabled = true;
    public bool isJump = false;

    protected float targetDRight;
    protected float velocityDRight;
}
