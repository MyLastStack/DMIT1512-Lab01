using System.Collections;
using System.Collections.Generic;
using TreeEditor;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    [SerializeField] GameObject Fireball;
    [SerializeField] int upToCount = 2500;
    GameObject fireBallChild;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        int attack = Random.Range(0, upToCount);
        for (int counting = 0; counting < attack; counting++)
        {
            fireBallChild = Instantiate(Fireball, new Vector3(this.transform.position.x, this.transform.position.y + 0.8f, 0), this.transform.rotation) as GameObject;
        }
    }
}
