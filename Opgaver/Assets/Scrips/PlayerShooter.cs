using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShooter : MonoBehaviour
{
    private Transform tf;
    public float rotationSpeed = 1f;

    // Start is called before the first frame update
    void Start()
    {
        tf = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        float z = Input.GetAxisRaw("ArrowKeys")*rotationSpeed;
        tf.Rotate(0,z,0);
        
    }
}
