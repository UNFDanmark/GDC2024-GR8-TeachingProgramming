using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private int bulletCooldown = 10;
    void Start()
    {
        print("Jeg er ond");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
