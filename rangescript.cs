using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rangescript : MonoBehaviour
{
    Collider m_ObjectCollider;
    private GameObject enemy;
    public Rigidbody enemyRb;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        m_ObjectCollider = GetComponent<BoxCollider>();
        enemyRb = GetComponent<Rigidbody>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (enemy!=null ) { Vector3 enemyDirection = (enemy.transform.position - transform.position).normalized;
            enemyRb.AddForce(enemyDirection * speed); }
    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag != "Ground")
        {
            
            enemy = collision.gameObject;
            Debug.Log("InRange");
        }
    }

    private void OnTriggerExit(Collider collision)
    {
        if (collision.gameObject.tag != "Ground")
        {
            
            Debug.Log("notinRange");
        }
    }

}
