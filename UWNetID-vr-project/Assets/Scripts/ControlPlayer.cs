using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlPlayer : MonoBehaviour
{
    public float speed = 5;
    public Rigidbody rigid;

    // Start is called before the first frame update
    void Start()
    {
        if (rigid == null)
        {
            rigid = this.gameObject.GetComponent<Rigidbody>();
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            rigid.MovePosition(transform.position + this.transform.forward * speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S))
        {
            rigid.MovePosition(transform.position - this.transform.forward * speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D))
        {
            rigid.MovePosition(transform.position + this.transform.right * speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.A))
        {
            rigid.MovePosition(transform.position - this.transform.right * speed * Time.deltaTime);
        }
    }

}
