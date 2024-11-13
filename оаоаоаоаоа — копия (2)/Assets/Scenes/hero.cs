using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hero : MonoBehaviour
{
    [SerializeField] private float speed = 3f; // скорость движения 
    [SerializeField] private int lives = 5; // количество жизней
    [SerializeField] private float jumpForce = 7f; // сила прыжка
    private bool isGrounded = false;

    private Rigidbody2D rb;
    private SpriteRenderer sprite;
    private Camera mainCamera;

    private void FixedUpdate()
    {
        CheckGround();
    }

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        sprite = GetComponentInChildren<SpriteRenderer>();
        mainCamera = Camera.main;
    }

    private void Update()
    {
        if (Input.GetButton("Horizontal"))
            Run();
        if (Input.GetButtonDown("Jump"))
            Jump();
    }

    private void Run()
    {
        Vector3 dir = transform.right * Input.GetAxis("Horizontal");
        transform.position = Vector3.MoveTowards(transform.position, transform.position + dir, speed * Time.deltaTime);
        sprite.flipX = dir.x < 0.0f;


        Vector3 screenPoint = mainCamera.WorldToScreenPoint(transform.position);
        if (screenPoint.x < 0 || screenPoint.x > Screen.width)
        {

            transform.position = mainCamera.ScreenToWorldPoint(new Vector3(Mathf.Clamp(screenPoint.x, 0, Screen.width), screenPoint.y, screenPoint.z));
        }
    }

    private void Jump()
    {
        if (isGrounded)
        {
            rb.AddForce(transform.up * jumpForce, ForceMode2D.Impulse);
            isGrounded = false;
        }
    }

    private void CheckGround()
    {
        Collider2D[] collider = Physics2D.OverlapCircleAll(transform.position, 0.3f);
        isGrounded = collider.Length > 1;
    }

}