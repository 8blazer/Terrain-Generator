using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flame : MonoBehaviour
{
    public float size = 1.62f;
    public float max = 4.5f;
    public float min = 1.62f;
    System.Random rnd = new System.Random();
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        int upOrDown = rnd.Next(1, 3);
        if (upOrDown == 1 && size < max)
        {
            size = size + .02f;
        }
        else if (upOrDown == 2 && size > min)
        {
            size = size - .02f;
        }
        GetComponent<UnityEngine.Experimental.Rendering.LWRP.Light2D>().pointLightOuterRadius = size;
    }
}