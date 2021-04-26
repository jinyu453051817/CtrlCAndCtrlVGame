using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class LittleEnemy : MonoBehaviour
{
    private Vector3 ori;
    private Vector3 des;
    private float x = 0;

    // Start is called before the first frame update
    void Start()
    {
        ori = transform.position;
        des = new Vector3(-8.81f, -56.22f, 0);
        x = transform.position.x;
    }

    // Update is called once per frame
    void Update()
    {
        float dis = Mathf.PingPong(Time.time*2, Vector3.Distance(ori, des));
        transform.position = new Vector3(x + dis, transform.position.y, 0);
            
    }

}
