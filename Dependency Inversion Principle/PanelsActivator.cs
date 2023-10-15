namespace DIP
{
    using System.Collections.Generic;
    using UnityEngine;

    /// <summary>
    /// Контролер панелей/окон интерфейса.
    /// 
    /// Изначально в данный класс были перенесены методы QuickPanel(), LongPanel() и backPanel() из класса MainMenuController
    /// Однако, данный класс нарушал бы принцип инверсии зависимостей 
    /// Поэтому необходимо создать класс для работы с любыми панелями
    /// 
    /// Данный класс все еще нуждается в рефакторинге - следует создать систему для работу с окнами,
    /// храня все окна в отдельном классе-контейнере и имея порядок вызова окон для иключения необходимости следить за 
    /// набором окон для деактивации
    /// </summary>
    public class PanelsActivator : MonoBehaviour
    {
        [SerializeField]
        protected IReadOnlyList<GameObject> panelsToDeactivate = default;

        /// <summary>
        /// Активация панели
        /// </summary>
        public virtual void ActivatePanel(GameObject panelToActivate)
        {
            if (panelToActivate != null)
            {
                DeactivateAllPanels();
                panelToActivate.SetActive(true);
            }
        }

        /// <summary>
        /// Деактивировать все панели
        /// </summary>
        protected virtual void DeactivateAllPanels()
        {
            foreach (GameObject panel in panelsToDeactivate)
            {
                panel.SetActive(false);
            }
        }
    }
}

