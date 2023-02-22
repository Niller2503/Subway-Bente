using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;


public class PlayerController1 : MonoBehaviour
{
    private float speed = 30;
    private float movementX;
    private float movementY;
    
    RaycastHit hitData;


    // Start is called before the first frame update
    private void OnMove(InputValue value)
    {
        Vector2 v = value.Get<Vector2>();
        movementX = v.x;
        movementY = v.y;
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

        if (movementY == 1)
        {
            Ray ray = new Ray(transform.position, -1*transform.up);

            Physics.Raycast(ray, out hitData);
            float hitPosition = hitData.distance;

            if (hitPosition < 3)
            {
                transform.position = transform.position + 6 * Vector3.up;
            }
        }

        if (movementY == -1)
        {
            transform.localScale = transform.localScale * 0.5f;
        }

        if (movementY == 0)
        {
            transform.localScale = new Vector3 (1.8f, 2.5f, 1.8f);
        }
    }

    void Start()
    {
        //Debug.Log(Physics.gravity.y);
        Physics.gravity = Vector3.down * 40;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.right * speed * Time.deltaTime);

        speed += speed * 0.01f * Time.deltaTime;

        Ray rayFremad = new Ray(transform.position + 1.6f * Vector3.up, transform.right);

        Physics.Raycast(rayFremad, out hitData);
        float hitPositionFremad = hitData.distance;
        Debug.Log("hitpositionFrem:" + hitPositionFremad);
        //Debug.Log(hitData.transform.gameObject);
        if (hitPositionFremad < 0.3f && hitPositionFremad>0)
        {
            speed = 0;
        }

        Ray rayNed = new Ray(transform.position, -transform.up);

        Physics.Raycast(rayNed, out hitData);
        float hitPositionNed = hitData.distance;
        Debug.Log("hitpositionNed:"+hitPositionNed);
        if (hitPositionNed < 1f)
        {
            transform.position = transform.position + 1f * Vector3.up;
        }


    }
}
