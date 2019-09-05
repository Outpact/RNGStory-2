using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class LevelChanger : MonoBehaviour
{
    public Animator animator;
    private int levelToLoad;

    // Update is called once per frame
    void Update()
    {

    }

    public void FadeToScene (int levelIndex)
    {
        levelToLoad =  1;
        animator.SetBool("Fade", true);
    }
    public void OnFadeComplete()
    {
        SceneManager.LoadScene(1);
    }
}
