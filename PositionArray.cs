using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PositionArray : MonoBehaviour
{
    public Vector3[] position;
    private GameObject enemy;
    // Start is called before the first frame update
    void Start()
    {
        enemy= GameObject.Find("Enemy");
        position[0] = gameObject.transform.position   ;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
