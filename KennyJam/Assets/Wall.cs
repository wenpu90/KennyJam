using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wall : MonoBehaviour
{
    public Transform monsterPoint;
    public static Wall Instance;
    public bool WallBool;
    public Collider boxCollider;
    public GameObject[] monsters;

    private void Start()
    {
        Instance = this;
        WallBool = true;
        Instantiate(monsters[Random.Range(0,monsters.Length)],monsterPoint);
    }
    private void Update()
    {
        if (!WallBool) {
            boxCollider.isTrigger = true;

        }

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) {
            print("o0o");
        }
    }
}
