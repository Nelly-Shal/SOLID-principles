namespace SRP
{
    using System.Collections;
    using System.Collections.Generic;
    using UnityEngine;
    using UnityEngine.SceneManagement;


    /// <summary>
    /// –ассмотрим принцип единственной ответственности на примере данного контролера
    /// ƒанный класс отвечает за несколько разных действий в главном меню
    /// —ледует разделить данный класс на несколько,каждый из которых иммет только одну область ответственности.
    /// –азделим данный класс: 
    /// 1) класс отвечающий за работу с загрузкой сцен - SceneLoadController
    /// 2) Ћогика взаимодействи€ с окнами - PanelsController
    /// 3) Ћогика сброса данных - ResetGameDataController
    /// </summary>
    public class MainMenuController : MonoBehaviour
    {
        public GameObject mainPanel;
        public GameObject quickPanel;
        public GameObject longPanel;


        public void LoadScene(string nameScene)
        {
            SceneManager.LoadScene(nameScene);

        }
        public void ReLoadScene()
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }

        public void Delete()
        {
            PlayerPrefs.DeleteKey("currentLevelCards");
            PlayerPrefs.DeleteKey("bestResultCards");
        }
        public void QuickPanel()
        {
            quickPanel.SetActive(true);
            mainPanel.SetActive(false);
        }
        public void LongPanel()
        {
            longPanel.SetActive(true);
            mainPanel.SetActive(false);
        }
        public void backPanel()
        {
            longPanel.SetActive(false);
            quickPanel.SetActive(false);
            mainPanel.SetActive(true);
        }

        public void DeleteWords()
        {

            for (int i = 0; i < LongMemoryController.numberOfWords + 1; i++)
                PlayerPrefs.DeleteKey($"Word{i}");
            PlayerPrefs.SetInt("firstDay", 1);
        }
    }
}