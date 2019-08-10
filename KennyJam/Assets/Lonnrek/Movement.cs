using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    float speed = 5;


    private void Update()
    {
        Move();
    }
    public void Move()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        Vector3 vec3 = new Vector3(horizontal, 0, vertical);
        transform.Translate(vec3 * speed * Time.deltaTime);
    }
}
