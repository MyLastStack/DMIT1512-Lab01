using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SplooshSpawner : MonoBehaviour
{
    [SerializeField] GameObject SplooshLaser;
    [SerializeField] float speed = 3;
    // Start is called before the first frame update
    void Start()
    {
        transform.Rotate(0, 0, 90);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector3( speed * Time.deltaTime, 0, 0));
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            Destroy(collision.gameObject);
            Destroy(SplooshLaser);

        }
        if (collision.gameObject.tag == "LaserDestroyer")
        {
            Destroy(SplooshLaser);
        }
    }
}
