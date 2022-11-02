using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ButtonsInFirstScene : MonoBehaviour
{
    public Canvas canvasMenu;
    public Canvas canvasSettings;
    public GameObject panelStartGame;
    public GameObject panelContinueGame;

    public void ExitGame() // ����� �� ���� 
    {
        Game.Save();
        Application.Quit();
    }

    public void StartNewGame() // ������ - ������ ����� ����
    {
        if (/*ChooseCharacter.gameIsStarted == false || */!Game.HasSave()) // ���� ��� ������ ������, �� ������ ����������� ������ ����� 
        {
            Game.StartNewGame();
            SceneManager.LoadScene(1);
            ChooseCharacter.current_char = 0;
            ChooseCharacter.currentCharacter = 0;
        }
            
        else // ���� ����  ���� �������� ����� - ����������� ������ � �������� - ������ ����� ����?
        {
            panelStartGame.SetActive(true);
        }
    }

    public void Yes_NewGame() // ��, � ���� ������ ����� ���� (������� ������)
    {
        Game.StartNewGame();
        ChooseCharacter.gameIsStarted = false;
        Game.GameIsStarted = false;
        //ChangeBars.fill = 1f;
        SceneManager.LoadScene(1);
        Player.Name = null;
        //Game.StartNewGame(); // 06 jan
        ChooseCharacter.current_char = 0;
        ChooseCharacter.currentCharacter = 0;
    }

    public void No_NewGame() // ���, ������ - �������� ������ � �������� - ������ ����� ����?
    {
        panelStartGame.SetActive(false);
    }

    public void ContinueGame() // ������ - ���������� ����
    {
        if (/*ChooseCharacter.gameIsStarted == false || */!Game.HasSave()) // ���� ���� �� ���� ����� ��������, ����������� ������ � ������� - � ��� ��� ����������� ����, ������ ������ �����?
        {
            panelContinueGame.SetActive(true);
        }

        else // ���� ���� ���� ����� ��������, �� ������ ���������� ����� 1 � ����������� ������ 
        {
            Game.Load();
            ChooseCharacter.gameIsStarted = true;
            Pause.GameIsStarted_IsStopped = false;
            ChangeBars.saving = 1;
            SceneManager.LoadScene(1);
        }
    }

    public void Yes_ContinueGame() // ��, � ���� ������ ����� ����
    {
        Game.StartNewGame();
        SceneManager.LoadScene(1);
        Player.Name = null;

    }

    public void No_ContinueGame() // ���, ������ - �������� ������ 
    {
        panelContinueGame.SetActive(false);
    }

    public void GoToSettings() // ������� �� ������ � ����������� 
    {
        canvasMenu.gameObject.SetActive(false);
        canvasSettings.gameObject.SetActive(true);
    }

    public void ReturnToMenu() // ��������� � ���� �� �������� 
    {
        canvasMenu.gameObject.SetActive(true);
        canvasSettings.gameObject.SetActive(false);
    }
}
