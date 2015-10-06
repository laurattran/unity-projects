using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Player1Controller : MonoBehaviour {

    public float speed;
    public Text countText;

    private Rigidbody rb;
    private int count;
    private bool isGrounded = true;


    void Start()
    {
        rb = GetComponent<Rigidbody>();
        count = 0;
        SetCountText();
    }
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.G) && isGrounded)
        {
            rb.AddForce(0, 200, 0);
        }
    }
    //Physics code
    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal 1");
        float moveVertical = Input.GetAxis("Vertical 1");

        Vector3 movement = new Vector3(moveHorizontal, 0, moveVertical);

        rb.AddForce(movement * speed);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Pick up"))
        {
            other.gameObject.SetActive(false);
            count = count + 1;
            SetCountText();
        }
    }

    void OnCollisionEnter(Collision collisionInfo)
    {
        if(collisionInfo.gameObject.CompareTag("Wall"))
        {
            count = count - 1;
            SetCountText();
        }
        if (collisionInfo.gameObject.CompareTag("Player"))
        {
            if(this.transform.position.y < collisionInfo.gameObject.transform.position.y)
            {
                count = count - 1;
                SetCountText();
            }

        }

    }

    void OnCollisionStay(Collision collisionInfo)
    {
        isGrounded = true;
    }

    void OnCollisionExit(Collision collisionInfo)
    {
        if (isGrounded)
        {
            isGrounded = false;
        }
    }

    void SetCountText()
    {
        countText.text = count.ToString();

    }
}
