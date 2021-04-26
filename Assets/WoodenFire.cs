using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;

public class WoodenFire : MonoBehaviour
{
    public Transform enemy1;
    public Transform enemy2;
    public Flowchart fc;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (enemy1.localScale.y <0 && enemy2.localScale.y < 0)
        {
            enemy1.gameObject.SetActive(false);
            enemy2.gameObject.SetActive(false);
            fc.ExecuteBlock("level2_1");
        }
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.name == "fireSp")
        {
            gameObject.AddComponent<Rigidbody2D>();
        }
    }

}
