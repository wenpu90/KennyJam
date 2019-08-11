using System.Collections;
using UnityEngine;
using System.Collections.Generic;
using UnityEngine.UI;

public class Animalstock : MonoBehaviour
{
    [SerializeField]
    private SpriteRenderer Sp_riteR;
    public Sprite [] animal;
    // Start is called before the first frame update
    void Start()
    {
        Sp_riteR.sprite = animal[Random.Range(0, animal.Length)];
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
