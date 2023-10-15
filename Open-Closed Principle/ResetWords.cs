namespace OCP
{
    using UnityEngine;

    /// <summary>
    /// ����� ��� ������ ������ � ������� ����
    /// </summary>
    public class ResetWords : BaseResetData
    {
        /// <summary>
        /// �������� ������������������ � ������� ����
        /// </summary>
        protected override void ResetData()
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