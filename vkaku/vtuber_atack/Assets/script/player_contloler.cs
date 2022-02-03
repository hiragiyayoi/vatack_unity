using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_contloler : MonoBehaviour
{
    private float screen_width = Screen.currentResolution.width;
    private float screen_heigt = Screen.currentResolution.height;
    public float move_number, back_number, offset, speed;

    private float h, v, m_h, m_v; 

    public Animator anim;

    Renderer targetRenderer;

    Rigidbody rb;

    void Start()
    {
        anim = gameObject.GetComponent<Animator>();
        rb = GetComponent<Rigidbody>();
        targetRenderer = GetComponent<Renderer>();
    }

    void FixedUpdate()
    {
        mortion();
        move_position();

    }

    private void move_position()
    {
        if (targetRenderer.isVisible)
        {
            // ï\é¶Ç≥ÇÍÇƒÇ¢ÇÈèÍçáÇÃèàóù
            float x = Input.GetAxis("Horizontal") * speed;
            float z = Input.GetAxis("Vertical") * speed;
            rb.AddForce(x, 0, z);
        }
        else
        {
            float x = -1 * Input.GetAxis("Horizontal") * speed;
            float z = -1 * Input.GetAxis("Vertical") * speed;
            rb.AddForce(x, 0, z);
        }
    }

    public void mortion()
    {
        if (Input.GetKey(KeyCode.W))
        {
            anim.SetTrigger("move");
        }
        else if (Input.GetKey(KeyCode.S))
        {
            anim.SetTrigger("back");
        }
        else if (Input.GetKey(KeyCode.D))
        {
            anim.SetTrigger("move_r");
        }
        else if (Input.GetKey(KeyCode.W) && Input.GetKey(KeyCode.D))
        {
            anim.SetTrigger("move_f_r");
        }
        else if (Input.GetKey(KeyCode.S) && Input.GetKey(KeyCode.D))
        {
            anim.SetTrigger("back_r");
        }
        else if (Input.GetKey(KeyCode.A))
        {
            anim.SetTrigger("move_l");
        }
        else if (Input.GetKey(KeyCode.W) && Input.GetKey(KeyCode.A))
        {
            anim.SetTrigger("move_f_l");
        }
        else if (Input.GetKey(KeyCode.S) && Input.GetKey(KeyCode.A))
        {
            anim.SetTrigger("back_l");
        }
        else
        {
            anim.SetTrigger("stop");
        }
    }
}
