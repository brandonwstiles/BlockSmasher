using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputPlayer : MonoBehaviour
{
    void Update()
    {
        if (Input.GetAxis("Fire1") != 0)
            gameObject.GetComponent<IMovable>().Move();
    }
}
