//using System.Collections;
//using System.Collections.Generic;
//using TreeEditor;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    [SerializeField] GameObject Fireball;
    [SerializeField] float upToCount;
    GameObject fireBallChild;
    public float attack;
    private float countdown = 0;

    // Start is called before the first frame update
    void Start()
    {
        upToCount = 1f;
        attack = Random.Range(0.25f, upToCount);
    }

    // Update is called once per frame
    void Update()
    {
        if (attack > countdown)
        {
            attack -= Time.deltaTime;
        }
        else if (countdown >= attack)
        {
            attack = Random.Range(5, upToCount);
            fireBallChild = Instantiate(Fireball, new Vector3(this.transform.position.x, this.transform.position.y + 0.8f, 0), this.transform.rotation) as GameObject;
        }
    }
}
