using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [Header("Player Stats")]
    [SerializeField] private float movementSpeed;
    [SerializeField] private float attackSpeed;
    [SerializeField] private float attackRange;
    [SerializeField] private float damage;

    public Rigidbody playerRb;

    private Vector3 movementDirection;
    private Vector3 mousePosition;

    private float movementX;
    private float movementY;

    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        PlayerMovement();
        LookAtMouse();
    }

    void PlayerMovement()
    {
        movementX = Input.GetAxisRaw("Horizontal");
        movementY = Input.GetAxisRaw("Vertical");

        movementDirection = new Vector3(movementX, movementY, 0).normalized;

        playerRb.velocity = new Vector3(movementDirection.x * movementSpeed, movementDirection.y * movementSpeed);
    }

    void LookAtMouse()
    {
        mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.up = (mousePosition - new Vector3(transform.position.x, transform.position.y, 0));
    }
}
