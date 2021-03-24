using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpBan : MonoBehaviour
{
    public List<GameObject> colList = new List<GameObject>();
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        colList.Add(collision.gameObject);
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        colList.Remove(collision.gameObject);
    }
}
