using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;


public class PlayerController1 : MonoBehaviour
{
    private float speed = 25;
    private float movementX;
    private float movementY;
    RaycastHit hitData;


    // Start is called before the first frame update
    private void OnMove(InputValue value)
    {
        Vector2 v = value.Get<Vector2>();
        movementX = v.x;
        //movementY = v.y;
        if (movementX != 0)
        {
            if (movementX == -1)
            {
                if(transform.position.z != 10)
                {
                    Ray ray = new Ray(transform.position, transform.forward);
                    
                    Physics.Raycast(ray, out hitData);
                    float hitPosition = hitData.distance;
            
                    if (hitPosition > 10 || hitPosition == 0)
                    {
                        transform.position = transform.position + 10 * Vector3.forward;
                    }
                }
            }

            if (movementX == 1)
            {
                if (transform.position.z != -10)
                {
                    Ray ray = new Ray(transform.position, -transform.forward);

                    Physics.Raycast(ray, out hitData);
                    float hitPosition = hitData.distance;
               
                    if (hitPosition > 10 || hitPosition == 0)
                    {
                        transform.position = transform.position - 10 * Vector3.forward;
                    }
                }
            }
        }
    }

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.right * speed * Time.deltaTime);

        speed += 0.1f * Time.deltaTime;
        Debug.Log(speed);
    }
}
