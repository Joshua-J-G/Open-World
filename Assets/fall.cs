using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fall : MonoBehaviour
{
    public float health = 100f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(0,(4 * Time.deltaTime)*-1,0);

        if(health <= 0)
        {
            Destroy(gameObject);
        }
    }
}
