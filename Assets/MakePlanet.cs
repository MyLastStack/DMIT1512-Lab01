using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakePlanet : MonoBehaviour
{
    [SerializeField] GameObject planet;
    GameObject p;
    // Start is called before the first frame update
    void Start()
    {
        // Make the planet when the camera starts in the scene.
        GameObject p = Instantiate(planet, new Vector2(3f, 2f), Quaternion.identity);
        p.transform.localScale = new Vector2(3f, 3f);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.anyKeyDown)
        {
            Destroy(p);
        }
    }
}
