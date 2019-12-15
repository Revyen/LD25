using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 0.5F;
    public string horAxis;
    public string vertAxis;
    private Rigidbody2D rb2d;

    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {
		float moveHorizontal = Input.GetAxis(horAxis);
		float moveVertical = Input.GetAxis(vertAxis);
        Vector3 movement = new Vector3 (moveHorizontal, moveVertical, 0);
        this.transform.position += movement * speed;
    }
}
