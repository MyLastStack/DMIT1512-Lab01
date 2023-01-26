using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine;
using UnityEditor.Tilemaps;
using UnityEngine.Rendering;

public class MerlinScripts : MonoBehaviour
{
    [SerializeField] GameObject Sploosh;

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
        SpriteRenderer sr = GetComponent<SpriteRenderer>();

        if (Keyboard.current.spaceKey.wasReleasedThisFrame)
        {

        }
        if (Keyboard.current.aKey.isPressed)
        {
            transform.Translate(Vector2.left * 5f * Time.deltaTime);
            if (!sr.flipX)
            {
                sr.flipX = true;
            }
        }
        if (Keyboard.current.dKey.isPressed)
        {
            transform.Translate(Vector2.right * 5f * Time.deltaTime);
            if (sr.flipX)
            {
                sr.flipX = false;
            }
        }
        ScreenPos.x = transform.position.x;

        //if (ScreenPos.x + )
    }
}
