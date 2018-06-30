using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class CharacterList2 : MonoBehaviour {

    private GameObject[] characterList2;
    private int index2 = 0;

    private void Start()
    {
        index2 = PlayerPrefs.GetInt("CharacterSelected");

        characterList2 = new GameObject[transform.childCount];

        for (int i = 0; i < transform.childCount; i++)

            characterList2[i] = transform.GetChild(i).gameObject;
        foreach (GameObject go in characterList2)
        {
            go.SetActive(false);
        }

        if (characterList2[index2])
        {
            characterList2[index2].SetActive(true);
        }
    }
    public void ToggleLeft()
    {
        //toggle off the current model
        characterList2[index2].SetActive(false);

        index2 -= 1;
        if (index2 < 0)
        {
            index2 = characterList2.Length - 1;
        }
        //toggle on the next model
        characterList2[index2].SetActive(true);
    }


    public void ToggleRightt()
    {
        //toggle off the current model
        characterList2[index2].SetActive(false);

        index2 += 1;
        if (index2 == characterList2.Length)
        {
            index2 = 0;
        }
        //toggle on the next model
        characterList2[index2].SetActive(true);
    }

    public void StartButton()
    {
        PlayerPrefs.SetInt("CharacterSelected", index2);
        SceneManager.LoadScene("Scene Racer");
    }

    public void QuitGame()
    {
        Debug.Log("QUIT");
        Application.Quit();
    }
}

