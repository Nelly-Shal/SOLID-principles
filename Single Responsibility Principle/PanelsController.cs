namespace SRP
{
    using UnityEngine;

    /// <summary>
    /// Контролер панелей/окон интерфейса.
    /// 
    /// Изначально в данный класс были перенесены методы QuickPanel(), LongPanel() и backPanel() из класса MainMenuController
    /// Однако, данный класс нарушает принцип инверсии зависимостей 
    /// Поэтому необходимо создать класс для работы с любыми панелями
    /// </summary>
    public class PanelsController : MonoBehaviour
    {
        protected GameObject mainPanel = default;
        protected GameObject quickPanel = default;
        protected GameObject longPanel = default;

        /// <summary>
        /// Активация панели из раздела проверки кратковременной памяти
        /// </summary>
        public void QuickPanel()
        {
            quickPanel.SetActive(true);
            mainPanel.SetActive(false);
        }

        /// <summary>
        /// Активация панели из раздела проверки долговременной памяти
        /// </summary>
        public void LongPanel()
        {
            longPanel.SetActive(true);
            mainPanel.SetActive(false);
        }

        /// <summary>
        /// Кнопка "Назад"
        /// </summary>
        public void backPanel()
        {
            longPanel.SetActive(false);
            quickPanel.SetActive(false);
            mainPanel.SetActive(true);
        }
    }
}
