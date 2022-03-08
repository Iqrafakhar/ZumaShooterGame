using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{

    // Start is called before the first frame update
    public float range = 100f;
    public Camera Cam;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            Debug.Log("Fire");
            Shoot();
        }
    }

    void Shoot()
    {
        RaycastHit hit;
        if(Physics.Raycast(Cam.transform.position, Cam.transform.forward, out hit, range))
        {
            Debug.Log(hit.transform.name);
            Target_ball target = hit.transform.GetComponent<Target_ball>();
        }
    }
}
