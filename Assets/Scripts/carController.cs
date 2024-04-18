using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class carController : MonoBehaviour
{
    public float carSpeed;
    Vector2 position;
    void Start()
    {
        position = transform.position.position;
    }

    void Update()
    {
        position.x += Input.GetAxis ("Horizontal") * carSpeed * Time.deltaTime;
        transform.position = position;
    }
}
