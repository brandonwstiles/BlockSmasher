using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RingObstacleMovement : MonoBehaviour
{
    private Rigidbody rbody;

    [SerializeField] private float rotationSpeed;

    void Start()
    {
        rbody = gameObject.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rbody.transform.Rotate(new Vector3(0, rotationSpeed, 0), Space.Self);
    }
}
