using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AninalBase : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag ("Player")) {
            gameObject.transform.parent = other.transform;
            Wall.Instance.WallBool = false;
            //gameObject.SetActive(false);
        }

        if(other.CompareTag("Wall")) {
            gameObject.SetActive(false);
        }
    }
}
