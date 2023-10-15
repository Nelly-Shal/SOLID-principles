namespace OCP
{
    using UnityEngine;

    /// <summary>
    /// ����� ��� ������ ������ � �������
    /// </summary>
    public class ResetCards : BaseResetData
    {
        /// <summary>
        /// ����� ������ � ������� ��������
        /// </summary>
        protected override void ResetData()
        {
            // FIXME: ��������� ������ � �������� � ������ ���������� ������ � �����
            PlayerPrefs.DeleteKey("currentLevelCards");
            PlayerPrefs.DeleteKey("bestResultCards");
        }
    }
}