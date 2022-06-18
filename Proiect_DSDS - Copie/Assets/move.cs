using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class move : MonoBehaviour
{
    public Rigidbody rb;
    public float speed;
    public float rotationSpeed;
    public Animator animator;

    public Text hit;

    public Joystick joystick;

    float h;
    float v;
    float animSpeed;
    Vector3 direction;

    void Update()
    {
        float h = joystick.Horizontal;
        float v = joystick.Vertical;

        animSpeed = Mathf.Abs(h + v);
        animator.SetFloat("Speed", animSpeed);

        direction = new Vector3(h, 0, v);
        direction.Normalize();

        transform.Translate(direction * speed * Time.deltaTime, Space.World);

        if (direction != Vector3.zero)
        {
            Quaternion rotation = Quaternion.LookRotation(direction, Vector3.up);
            transform.rotation = Quaternion.RotateTowards(transform.rotation, rotation, rotationSpeed * Time.deltaTime);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        hit.text = collision.gameObject.tag;
    }
}
