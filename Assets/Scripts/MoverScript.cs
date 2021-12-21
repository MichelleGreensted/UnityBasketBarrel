using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoverScript : MonoBehaviour
{
    public float yAxis;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.frameCount% 50 == 0)
        {
            yAxis *= -1;
        }
        transform.Translate(0, yAxis, 0, Space.World);
    }
}
