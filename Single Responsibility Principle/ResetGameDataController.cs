namespace SRP
{
    using UnityEngine;

    /// <summary>
    /// Сброс данных
    /// 
    /// Однако данный класс (как и логика сохранения данных) еще требует рефакторинга
    /// 1) Стоит исправить работу с префсами
    /// 2) Удаление данных из 2 разных разделов => при увеличении количества разделов 
    /// возникнет необходимость дописывать новые методы 
    /// </summary>
    public class ResetGameDataController : MonoBehaviour
    {
        /// <summary>
        /// Удаление данных в разделе карточки
        /// </summary>
        protected virtual void Delete()
        {
            // FIXME: Исправить работы с префсами и логику сохранения данных в целом
            PlayerPrefs.DeleteKey("currentLevelCards");
            PlayerPrefs.DeleteKey("bestResultCards");
        }

        /// <summary>
        /// Удаление последовательности в разделе слов
        /// </summary>
        protected virtual void DeleteWords()
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