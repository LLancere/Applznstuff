using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class throwscript : MonoBehaviour
{
    public Transform Glassobject;
    Rigidbody m_Rigidbody;
    public float m_Thrust = 20f;

    // Start is called before the first frame update
    void Start()
    {
    //Fetch the Rigidbody from the GameObject with this script attached
    m_Rigidbody = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        if (Input.GetButton("Jump"))
        {
            Vector3 direction = Glassobject.position - transform.position;
            //Apply a force to this Rigidbody in direction of this GameObjects up axis
            m_Rigidbody.AddForce(direction.normalized * m_Thrust);
        }
    }
}
