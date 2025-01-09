using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlatformMovement : MonoBehaviour
{
    public float speed;
    public int startingPoint;
    public Transform[] points;
    private int i;

    void Start()
    {
        transform.position = points[startingPoint].position;

    }

    void Update()
    {
        if(Vector2.Distance(transform.position, points[i].position) < 00.2f)
        {
            i++;
            if(i  == points.Length)
            {
                i = 0;
            }
        }
        transform.position = Vector2.MoveTowards(transform.position, points[i].position, speed * Time.deltaTime);
    }

    private void OnCollisionEnter(Collision collision)
    {
        collision.transform.SetParent(transform);
    }

     private void OnCollisionExit(Collision collision)
    {
        collision.transform.SetParent(null);
    }

}

