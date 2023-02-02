using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine;
using UnityEngine.Tilemaps;
using UnityEngine.Rendering;

public class MerlinScripts : MonoBehaviour
{
    [SerializeField] GameObject merlin;
    [SerializeField] GameObject sploosh;
    GameObject splooshChild;

    Vector2 ScreenPos;
    Vector2 Direction = new(1, 0);
    Vector2 ScreenSize;
    // Start is called before the first frame update
    void Start()
    {
        
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
            splooshChild = Instantiate(sploosh, new Vector3(merlin.transform.position.x, merlin.transform.position.y + 0.8f, 0), merlin.transform.rotation) as GameObject;
        }
        if (Keyboard.current.aKey.isPressed && gameObject.transform.position.x >= -8f)
        {
            transform.Translate(Vector2.left * 5f * Time.deltaTime);
            if (!sr.flipX)
            {
                sr.flipX = true;
            }
        }
        if (Keyboard.current.dKey.isPressed && gameObject.transform.position.x <= 8f)
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
