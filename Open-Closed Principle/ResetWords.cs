namespace OCP
{
    using UnityEngine;

    /// <summary>
    /// Класс для сброса данных в разделе слов
    /// </summary>
    public class ResetWords : BaseResetData
    {
        /// <summary>
        /// Удаление последовательности в разделе слов
        /// </summary>
        protected override void ResetData()
        {
            // FIXME: Исправить работы с префсами и логику сохранения данных в целом
            for (int i = 0; i < LongMemoryController.numberOfWords + 1; i++)
            {
                PlayerPrefs.DeleteKey($"Word{i}");
            }

            PlayerPrefs.SetInt("firstDay", 1);
            PlayerPrefs.Save();
        }
    }
}