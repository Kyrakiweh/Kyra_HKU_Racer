using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CharacterListCode1 : MonoBehaviour {

    private GameObject[] characterList;
    private int index=0;

    private void Start()
    {
        index = PlayerPrefs.GetInt("CharacterSelected");

        characterList = new GameObject[transform.childCount];

        for (int i = 0; i < transform.childCount; i++)

            characterList[i] = transform.GetChild(i).gameObject;
        foreach (GameObject go in characterList)
        {
            go.SetActive(false);
        }

        if (characterList[index])
        {
            characterList[index].SetActive(true);
        }
    }
        public void ToggleLeft()
        {
        //toggle off the current model
        characterList[index].SetActive(false);

            index -= 1;
            if (index < 0)
        {
            index = characterList.Length - 1;
        }
        //toggle on the next model
        characterList[index].SetActive(true);
    }


    public void ToggleRightt()
    {
        //toggle off the current model
        characterList[index].SetActive(false);

        index += 1;
        if (index == characterList.Length )
        {
            index = 0;
        }
        //toggle on the next model
        characterList[index].SetActive(true);
    }

    public void StartButton()
    {
        PlayerPrefs.SetInt("CharacterSelected", index);
        SceneManager.LoadScene("Scene Racer");
    }

    public void QuitGame()
    {
        Debug.Log("QUIT");
        Application.Quit();
    }
}
