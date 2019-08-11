using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PauseBtn : MonoBehaviour
{
    public Text FiveSecText;
    // Start is called before the first frame update
    void Start()
    {
    }

    public void PauseGame()
    {
        GameManager.Instance.FreezeBool = false;
        //Time.timeScale = 0f;
        StartCoroutine(Show_words());
    }

    IEnumerator Show_words()
    {

        yield return new WaitForSeconds(5);
        GameManager.Instance.FreezeBool = true;
        //Time.timeScale = 1f;

    }





    // Update is called once per frame
    void Update()
    {
        
    }
}
