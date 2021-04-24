using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MimeMove : MonoBehaviour
{
    public float speed = 5;
    public float smoothTime = 0.125f;
    private Rigidbody2D rb;
    private Vector3 vel;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float horVel = Input.GetAxis("Horizontal") * speed;
        float vertVel = Input.GetAxis("Vertical") * speed;

        Vector2 targetVel = new Vector2(horVel, vertVel);

        rb.velocity = Vector3.SmoothDamp(rb.velocity, targetVel, ref vel, smoothTime);
    }
}
