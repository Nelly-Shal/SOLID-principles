namespace SRP
{
    using UnityEngine;

    /// <summary>
    /// ��������� �������/���� ����������.
    /// 
    /// ���������� � ������ ����� ���� ���������� ������ QuickPanel(), LongPanel() � backPanel() �� ������ MainMenuController
    /// ������, ������ ����� �������� ������� �������� ������������ 
    /// ������� ���������� ������� ����� ��� ������ � ������ ��������
    /// </summary>
    public class PanelsController : MonoBehaviour
    {
        protected GameObject mainPanel = default;
        protected GameObject quickPanel = default;
        protected GameObject longPanel = default;

        /// <summary>
        /// ��������� ������ �� ������� �������� ��������������� ������
        /// </summary>
        public void QuickPanel()
        {
            quickPanel.SetActive(true);
            mainPanel.SetActive(false);
        }

        /// <summary>
        /// ��������� ������ �� ������� �������� �������������� ������
        /// </summary>
        public void LongPanel()
        {
            longPanel.SetActive(true);
            mainPanel.SetActive(false);
        }

        /// <summary>
        /// ������ "�����"
        /// </summary>
        public void backPanel()
        {
            longPanel.SetActive(false);
            quickPanel.SetActive(false);
            mainPanel.SetActive(true);
        }
    }
}
