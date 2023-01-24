using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class detectobject : MonoBehaviour
{
    [SerializeField]private int score = 0;
    [SerializeField] private int maxscore = 2;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "object")
        {
            score += 1;
            Destroy(other.gameObject);
        }
        if(score >= maxscore)
        {
            Debug.Log("You win");
            StartCoroutine(restartgame());
        }
    }
    IEnumerator restartgame()
    {
        yield return new WaitForSeconds(3f);
        SceneManager.LoadScene("Scene1");
    }
}
