using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Title : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(DoChangeScene());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public float delay = 1;

    /*public void ChangeToScene(string CubeScene)
    {
        StartCoroutine(DoChangeScene(CubeScene, 1f));
    }*/
    IEnumerator DoChangeScene()
    {
        yield return new WaitForSeconds(delay);
        SceneManager.LoadScene(1);
    }
}
