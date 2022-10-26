using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{

    public static Move instance;

    public Rigidbody rb;

    private bool goingRight = true;

    [SerializeField]
    private float speed = 5;

    [SerializeField]
    private GameObject goLeft;

    [SerializeField]
    private GameObject goRight;


    // Start is called before the first frame update
    void Start()
    {

        instance = this;

    }

    // Update is called once per frame
    void Update()
    {

        if (goingRight == true)
        {

            //rb.velocity = new Vector3(speed, 0, 0);

            transform.Translate(Vector3.right * speed * Time.deltaTime);

        }

        else
        {

            //rb.velocity = new Vector3(-speed, 0, 0);

            transform.Translate(Vector3.left * speed * Time.deltaTime);

        }


        if (transform.position.x >= 7)
        {

            goingRight = false;

            //speed = Random.Range(3, 10);

        }

        if (transform.position.x <= -1.44)
        {

            goingRight = true;

            //speed = Random.Range(3, 10);

        }

    }

    public void ChangeSpeed()
    {

        speed = Random.Range(3, 10);

        print("homo");

    }


    //private void OnTriggerEnter(Collider other)
    //{

    //    if (other.gameObject == goLeft)
    //    {

    //        goingRight = false;

    //        speed = Random.Range(3, 10);

    //    }

    //    if (other.gameObject == goRight)
    //    {

    //        goingRight = true;

    //        speed = Random.Range(3, 10);

    //    }


    //}





}
