using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    public float pitchRPS, yawRPS, rollRPS;

    private float timeSpeed; //1 second is 1 day usually
    // Start is called before the first frame update
    void Start()
    {
        timeSpeed = 100f;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(pitchRPS,yawRPS,rollRPS) * Time.deltaTime * timeSpeed);
    }
}
