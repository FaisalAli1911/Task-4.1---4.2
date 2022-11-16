using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playercontrol : MonoBehaviour
{
    public float speed = 5.0f;
    private Rigidbody playerrb;
    public GameObject Camera;

    // Start is called before the first frame update
    void Start()
    {
        Camera = GameObject.Find("Focal Point");
        playerrb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float forwardInput = Input.GetAxis("Vertical");

        playerrb.AddForce(Camera.transform.forward * forwardInput*speed);
    }
}
