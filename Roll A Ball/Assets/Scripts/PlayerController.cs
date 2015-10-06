using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PlayerController : MonoBehaviour {

    public float speed;
    public Text countText;
    public Text winText;

    private Rigidbody rb;
    private int count;
    private bool isGrounded = true;


    void Start()
    {
        rb = GetComponent<Rigidbody>();
        count = 0;
        SetCountText();
        winText.text = "";
    }
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            rb.AddForce(5, 200, 5);
        }
    }
    //Physics code
    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal 2");
        float moveVertical = Input.GetAxis("Vertical 2");

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
        countText.text = "Count: " + count.ToString();
        if(count > 12)
        {
            winText.text = "You win!";
        }

    }
}
