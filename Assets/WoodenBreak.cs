using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;

public class WoodenBreak : MonoBehaviour
{
    public Flowchart fc;

    private void OnCollisionEnter2D(UnityEngine.Collision2D collision)
    {
        if (collision.gameObject.GetComponent<SpriteRenderer>().color == Color.black)
        {
            if (gameObject.GetComponent<Rigidbody2D>() == null)
            {
                gameObject.AddComponent<Rigidbody2D>();
                fc.ExecuteBlock("level1_9");
            }
        }
    }
}
