using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;

public class FireShao : MonoBehaviour
{
    public Flowchart fc;

    public void ShaoOver()
    {
        fc.ExecuteBlock("level2_2");
    }
}
