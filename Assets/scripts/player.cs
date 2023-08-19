using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject ball;
    public GameObject playerCamera;
    public float ballDistance = 2.35f;
    public float ballThrowForce = 250f;
    public bool holdBall = true;
    void Start()
    {
       ball. GetComponent<Rigidbody>().useGravity=false;
    }

    // Update is called once per frame
    void Update()
    {
        if (holdBall)
        {
            ball.transform.position = playerCamera.transform.position + playerCamera.transform.forward * ballDistance;


            if (Input.GetMouseButton(0))
            {
                ball.GetComponent<Rigidbody>().useGravity = true;
                holdBall = false;
                ball.GetComponent<Rigidbody>().AddForce(playerCamera.transform.forward*ballThrowForce);


            }
        }
    }
}
