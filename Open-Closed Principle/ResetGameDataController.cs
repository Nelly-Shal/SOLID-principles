namespace OCP
{
    using UnityEngine;

    /// <summary>
    /// Сброс данных
    /// Рассмотрим принцип окрытости-закрытости на примере данного класса
    /// 
    /// Сброс данных из 2 разных разделов => при увеличении количества разделов 
    /// возникнет необходимость дописывать новые методы 
    /// Создадим базовый класс для сброса данных и 2 наследников для сброса данных в разных разделах
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