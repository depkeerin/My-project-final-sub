using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using static UnityEngine.RuleTile.TilingRuleOutput;

public class Duckling : MonoBehaviour
{
    public float moveSpeed = 1f; 
    private Rigidbody2D rb;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {

        Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        mousePosition.z = transform.position.z;

        Vector2 direction = (mousePosition - transform.position).normalized;

        rb.AddForce(direction * moveSpeed);


    }

    
}

