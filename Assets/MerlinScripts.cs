using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine;

public class MerlinScripts : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
        transform.transform.localScale = new Vector3(5f, 5f, 5f);
    }

    void FixedUpdate()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Keyboard.current
    }
}
