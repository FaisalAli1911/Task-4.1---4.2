using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyscript : MonoBehaviour
{
    public float speed = 3.0f;
    public Rigidbody enemyrb;
    PositionArray address;
    private Vector3 Player;
    // Start is called before the first frame update
    void Awake()
    {
        enemyrb = GetComponent<Rigidbody>();
        address = GameObject.Find("vectorstofollow").GetComponent<PositionArray>();
        


    }

    // Update is called once per frame
    void Update()
    {
       Vector3 follow = address.position[0];
       enemyrb.AddForce((follow - transform.position).normalized*speed);
    }
}
