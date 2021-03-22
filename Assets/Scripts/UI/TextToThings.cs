using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextToThings : MonoBehaviour
{
    public GameObject goObject;
    public Vector3 offset;
    public float scaleX;
    public float scaleY;

    private Vector3 objVec;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        objVec = goObject.transform.position;
        gameObject.GetComponent<Image>().rectTransform.position = Camera.main.WorldToScreenPoint(new Vector3(objVec.x * scaleX, objVec.x * scaleY, objVec.z) + offset, 0);
    }
}
