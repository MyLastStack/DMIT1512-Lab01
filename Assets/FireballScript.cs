using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireballScript : MonoBehaviour
{
    [SerializeField] GameObject Fireball;
    [SerializeField] float speed = 3;

    // Start is called before the first frame update
    void Start()
    {
        transform.Rotate(0, 0, 270);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector3(speed * Time.deltaTime, 0, 0));
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Merlin")
        {
            Destroy(collision.gameObject);
            Destroy(Fireball);
        }
        if (collision.gameObject.tag == "LaserDestroyer")
        {
            Destroy(Fireball);
        }
    }
}
