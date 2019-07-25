using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour, IMovable
{
    private Rigidbody rbody;
    [SerializeField]
    private float speed = 10;
    void Awake()
    {
        rbody = gameObject.GetComponent<Rigidbody>();

    }

    public void Move()
    {
        if(rbody != null)
            rbody.transform.Translate(Vector3.down * Time.deltaTime * speed);
        else
            rbody = gameObject.GetComponent<Rigidbody>();
    }
}
