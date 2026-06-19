using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadToStage : MonoBehaviour
{
    [SerializeField] GameObject fadeout;
    void Start()
    {
        StartCoroutine(LoadLevel());
    }

    IEnumerator LoadLevel()
    {
        yield return new WaitForSeconds(3);
        fadeout.SetActive(true);
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene(1);
    }
}
