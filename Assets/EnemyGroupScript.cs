using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGroupScript : MonoBehaviour
{
    [SerializeField] GameObject dragon;
    [SerializeField] float speed;

    //this just makes it so that moving starts to the right.
    private Vector3 groupDirection = Vector2.right;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.position += groupDirection * speed * Time.deltaTime;

        foreach (Transform dragon in this.transform)
        {
            if (groupDirection == Vector3.right && dragon.position.x >= 8)
            {
                DirectionAndRowDown();
            }
            else if (groupDirection == Vector3.left && dragon.position.x <= -8)
            {
                DirectionAndRowDown();
            }
        }
    }

    private void DirectionAndRowDown()
    {
        groupDirection *= -1;

        Vector3 position = this.transform.position;
        position.y -= 0.25f;
        this.transform.position = position;
    }
}
