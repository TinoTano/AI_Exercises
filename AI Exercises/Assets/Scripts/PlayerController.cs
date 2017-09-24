using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{

    public float speed;
    public Text count_text;
    public Text win_text;
    private Rigidbody rigid_body;
    private int pick_counts;

    void Start()
    {
        rigid_body = GetComponent<Rigidbody>();
        pick_counts = 0;
        SetCountText();
        win_text.text = "";
    }

    void FixedUpdate()
    {
        float move_horizontal = Input.GetAxis("Horizontal");
        float move_vertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(move_horizontal, 0.0f, move_vertical);
        rigid_body.AddForce(movement * speed);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Pick Up"))
        {
            other.gameObject.SetActive(false);
            pick_counts++;
            SetCountText();
        }
    }

    void SetCountText()
    {
        count_text.text = "Count: " + pick_counts.ToString();
        if(pick_counts == 13)
        {
            win_text.text = "You Win!";
        }
    }
}
