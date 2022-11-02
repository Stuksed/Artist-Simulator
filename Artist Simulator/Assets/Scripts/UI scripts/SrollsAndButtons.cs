using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SrollsAndButtons : MonoBehaviour
{
    public GameObject panelJobInformation;

    public GameObject contractScroll;
    public GameObject jobScroll;

    // ������ ������ �� ������ �����
    public void ClickOnWorkButton()
    {
        contractScroll.SetActive(false);
        jobScroll.SetActive(false);
        panelJobInformation.SetActive(true);
    }

    public void ContractButton()
    {
        contractScroll.SetActive(true);
        jobScroll.SetActive(false);
        panelJobInformation.SetActive(false);
    }

    public void JobButton()
    {
        contractScroll.SetActive(false);
        jobScroll.SetActive(true);
        panelJobInformation.SetActive(false);
    }

    public void ClickOnBackToWorkButton()
    {
        ClickOnWorkButton();
    }


    /*
    public GameObject studyScroll;
    public GameObject skillsScroll;

    // ������ ������ �� ������ �����
    public void ClickOnStudyButton()
    {
        studyScroll.SetActive(false);
        skillsScroll.SetActive(false);
    }

    public void StudyButton()
    {
        studyScroll.SetActive(true);
        skillsScroll.SetActive(false);
    }

    public void SkillsButton()
    {
        studyScroll.SetActive(false);
        skillsScroll.SetActive(true);
    }*/





    public GameObject forPaintingScroll;
    public GameObject otherScroll;

    // ��������� ������ �� ������ �����
    public void ClickOnStoreButton()
    {
        forPaintingScroll.SetActive(false);
        otherScroll.SetActive(false);
    }

    public void ForPaintingButton()
    {
        forPaintingScroll.SetActive(true);
        otherScroll.SetActive(false);
    }

    public void OtherButton()
    {
        forPaintingScroll.SetActive(false);
        otherScroll.SetActive(true);
    }






    public GameObject treatingScroll;
    public GameObject foodScroll;
    public GameObject moodScroll;
    public GameObject relaxScroll;

    // ����� ������ �� ������ �����
    public void ClickOnIncreasingButton()
    {
        treatingScroll.SetActive(false);
        foodScroll.SetActive(false);
        moodScroll.SetActive(false);
        relaxScroll.SetActive(false);
    }

    public void TreatingButton()
    {
        treatingScroll.SetActive(true);
        foodScroll.SetActive(false);
        moodScroll.SetActive(false);
        relaxScroll.SetActive(false);
    }

    public void FoodButton()
    {
        treatingScroll.SetActive(false);
        foodScroll.SetActive(true);
        moodScroll.SetActive(false);
        relaxScroll.SetActive(false);
    }
    public void MoodButton()
    {
        treatingScroll.SetActive(false);
        foodScroll.SetActive(false);
        moodScroll.SetActive(true);
        relaxScroll.SetActive(false);
    }
    public void RelaxButton()
    {
        treatingScroll.SetActive(false);
        foodScroll.SetActive(false);
        moodScroll.SetActive(false);
        relaxScroll.SetActive(true);
    }
}
