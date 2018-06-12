using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VRRot : MonoBehaviour
{
    public GameObject target;
    Vector3 prevForward;


    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            prevForward = transform.forward;
        }
        if (Input.GetKey(KeyCode.A))
        {
            Quaternion rotQ = Quaternion.FromToRotation(prevForward, transform.forward );
            // Debug.Log(transform.forward);
            // Debug.Log(prevForward);
            target.transform.rotation = rotQ * target.transform.rotation;
            prevForward = transform.forward;
        }

        if (Input.GetKey(KeyCode.X))
        {
            transform.Rotate(0.5f, 0.0f, 0.0f, Space.World);
        }
        if (Input.GetKey(KeyCode.Y))
        {
            transform.Rotate(0.0f, 0.5f, 0.0f, Space.World);
        }
        if (Input.GetKey(KeyCode.R))
        {
            transform.rotation = Quaternion.identity;
        }
    }
}
