using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakePlanet : MonoBehaviour
{
    [SerializeField] GameObject planet;
    [SerializeField] GameObject background;
    GameObject p;
    GameObject bg;
    // Start is called before the first frame update
    void Start()
    {

        // Make the planet when the camera starts in the scene.
        Camera cam = Camera.main;
        bg = Instantiate(background, new Vector3(0f, 0f, 2f), Quaternion.identity);

        p = Instantiate(planet, new Vector3(3f, 2f, 1f), Quaternion.identity);
        p.transform.localScale = Vector2.one * 3f;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
