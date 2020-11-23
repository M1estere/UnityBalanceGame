using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MoveSphere : MonoBehaviour
{
    public float speed = 5;
    Vector2 velocity;

    public Rigidbody rb;
    public Transform resp;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    void Update()
    {
        /*velocity.y = Input.GetAxis("Vertical") * speed * Time.deltaTime;
        velocity.x = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        transform.Translate(velocity.x, -velocity.y, 0);*/
        rb.AddForce(Input.GetAxis("Horizontal") * 3, 0, Input.GetAxis("Vertical") * 3);
    }
    public void OnTriggerEnter(Collider other)
    {
        if(other.tag == "DeadZone")
        {
            SceneManager.LoadScene("Level1");
            //transform.position = resp.transform.position;
           // rb.freezeRotation = true;
        }
        if(other.tag == "Fall")
        {
            //StartCoroutine(DestroyBlock(1));
            //Destroy(other.gameObject);
        }
    }

    /*IEnumerator DestroyBlock(float delay)
    {
        yield return new WaitForSeconds(delay);
    }*/
}
