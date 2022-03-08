using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateWithButton : MonoBehaviour
{   // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            transform.Rotate(0, 45, 0);
        }
    }
}
