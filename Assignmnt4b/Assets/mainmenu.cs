using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainmenu : MonoBehaviour
{
    public void playPenguineGame()
    {
        SceneManager.LoadScene("Penguins");
    }

    public void playHummingBirdGame()
    {
        SceneManager.LoadScene(2);//flowerIsland
    }
    public void LoadMainMenu()
    {
        SceneManager.LoadScene(0);//MainMenu
    }
}
