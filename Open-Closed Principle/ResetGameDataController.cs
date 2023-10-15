namespace OCP
{
    using UnityEngine;

    /// <summary>
    /// ����� ������
    /// ���������� ������� ���������-���������� �� ������� ������� ������
    /// 
    /// ����� ������ �� 2 ������ �������� => ��� ���������� ���������� �������� 
    /// ��������� ������������� ���������� ����� ������ 
    /// �������� ������� ����� ��� ������ ������ � 2 ����������� ��� ������ ������ � ������ ��������
    /// </summary>
    public class ResetGameDataController : MonoBehaviour
    {
        /// <summary>
        /// �������� ������ � ������� ��������
        /// </summary>
        protected virtual void Delete()
        {
            // FIXME: ��������� ������ � �������� � ������ ���������� ������ � �����
            PlayerPrefs.DeleteKey("currentLevelCards");
            PlayerPrefs.DeleteKey("bestResultCards");
        }

        /// <summary>
        /// �������� ������������������ � ������� ����
        /// </summary>
        protected virtual void DeleteWords()
        {
            // FIXME: ��������� ������ � �������� � ������ ���������� ������ � �����
            for (int i = 0; i < LongMemoryController.numberOfWords + 1; i++)
            {
                PlayerPrefs.DeleteKey($"Word{i}");
            }

            PlayerPrefs.SetInt("firstDay", 1);
            PlayerPrefs.Save();
        }
    }
}