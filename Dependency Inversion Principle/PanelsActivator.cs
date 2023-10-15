namespace DIP
{
    using System.Collections.Generic;
    using UnityEngine;

    /// <summary>
    /// ��������� �������/���� ����������.
    /// 
    /// ���������� � ������ ����� ���� ���������� ������ QuickPanel(), LongPanel() � backPanel() �� ������ MainMenuController
    /// ������, ������ ����� ������� �� ������� �������� ������������ 
    /// ������� ���������� ������� ����� ��� ������ � ������ ��������
    /// 
    /// ������ ����� ��� ��� ��������� � ������������ - ������� ������� ������� ��� ������ � ������,
    /// ����� ��� ���� � ��������� ������-���������� � ���� ������� ������ ���� ��� ��������� ������������� ������� �� 
    /// ������� ���� ��� �����������
    /// </summary>
    public class PanelsActivator : MonoBehaviour
    {
        [SerializeField]
        protected IReadOnlyList<GameObject> panelsToDeactivate = default;

        /// <summary>
        /// ��������� ������
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
        /// �������������� ��� ������
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

