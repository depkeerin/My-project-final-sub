using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Duck7 : MonoBehaviour
{
    public Transform nest;
    public float speed = 5f;
    public CircleCollider2D winCollider; 

    private bool isMoving = false;
    private float timer = 10f;

    void Update()
    {
        if (timer <= 0)
        {
            return;
        }

        timer -= Time.deltaTime;

        Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mousePosition.z = 0;

        if (Input.GetMouseButton(0))
        {
            transform.LookAt(mousePosition);
            transform.position = Vector3.MoveTowards(transform.position, mousePosition, speed * Time.deltaTime);
            isMoving = true;
        }
        else if (isMoving)
        {
            Vector3 nestPosition = nest.position;
            nestPosition.z = 0;
            transform.LookAt(nestPosition);
            transform.position = Vector3.MoveTowards(transform.position, nest.position, speed * Time.deltaTime);

            if (Vector3.Distance(transform.position, nest.position) < 0.1f)
            {
                isMoving = false;
            }
        }

        if (winCollider.OverlapPoint(transform.position))
        {
            Debug.Log("You Win!");
        }
        else if (timer <= 0)
        {
            Debug.Log("You Lose!");
        }
    }
}