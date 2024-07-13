using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float maxHealth = 100;
    public float health = 100;
    private MeshRenderer meshRenderer;
    void Start()
    {
        health = maxHealth;
        meshRenderer = GetComponent<MeshRenderer>();
    }

    void Update()
    {
        Color colour = meshRenderer.material.color;
        colour.g = -(0.75f/maxHealth)*health+0.75f;
        colour.b = -(0.75f/maxHealth)*health+0.75f;

        //colour.g = 25.5f;
        //colour.b = 25.5f;
        //Debug.Log(gameObject.name + " health: " + health);
        //Debug.Log(gameObject.name + " clamp calc: " + colour.g+" "+colour.b);
        meshRenderer.material.color = colour;
        //Debug.Log(meshRenderer.material.color.r + " is the colour of the material."+meshRenderer.material.name);
        if (health <= 0)
        {
            Destroy(gameObject);
        }
    }
}
