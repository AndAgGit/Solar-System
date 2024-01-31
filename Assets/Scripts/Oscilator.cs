using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Oscilator : MonoBehaviour
{
    int frame;
    Vector3 startPos;
    // Start is called before the first frame update
    void Start()
    {
        frame=0;
        Debug.Log("I'm in Start at frame: " + frame); 

        startPos = transform.position; 
    }

    // Update is called once per frame
    void Update()
    {
        frame++;
        Debug.Log("I'm in Update at frame: " + frame);

        float offset = Mathf.Sin(Time.time);
        transform.position = startPos + (Vector3.right * offset);
    }
}
