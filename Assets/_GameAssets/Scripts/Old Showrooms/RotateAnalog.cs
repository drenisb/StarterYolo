using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateAnalog : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 move = Vector2.zero;//CHANGE OVRInput.Get(OVRInput.Axis2D.SecondaryThumbstick);
        gameObject.transform.Rotate(-Vector3.up * move.x);
    }
}
