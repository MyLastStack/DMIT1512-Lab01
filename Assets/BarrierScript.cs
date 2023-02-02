using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarrierScript : MonoBehaviour
{
    [SerializeField] GameObject Barrier;
    public int health;

    // Start is called before the first frame update
    void Start()
    {
        health = 5;
    }

    // Update is called once per frame
    void Update()
    {
        if (health < 5)
        {
            Barrier.GetComponent<Renderer>().material.color = Color.yellow;
        }
        if (health < 3)
        {
            Barrier.GetComponent<Renderer>().material.color = Color.red;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Fireball")
        {
            health -= 1;
            Destroy(collision.gameObject);
            if (health == 0)
            {
                Destroy(Barrier);
            }
        }
    }
}
