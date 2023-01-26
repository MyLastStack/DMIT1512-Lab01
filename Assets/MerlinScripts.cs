using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine;
using UnityEditor.Tilemaps;

public class MerlinScripts : MonoBehaviour
{
    Vector2 ScreenPos;
    Vector2 Direction = new(1, 0);
    Vector2 ScreenSize;

    // Start is called before the first frame update
    void Start()
    {
        ScreenSize = new(1920, 1080);
    }

    void FixedUpdate()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Keyboard.current.aKey.isPressed)
        {
            transform.Translate(Vector2.left * 5f * Time.deltaTime);
            //if (transform.rotation.y != 0)
            //{
            //    transform.
            //}
            
        }
        if (Keyboard.current.dKey.isPressed)
        {
            transform.Translate(Vector2.right * 5f * Time.deltaTime);
            //if (transform.rotation.y != 0)
            //{
            //    transform.Rotate(0f, 0f, 0f);
            //}
        }
        ScreenPos.x = transform.position.x;

        //if (ScreenPos.x + )
    }
}
