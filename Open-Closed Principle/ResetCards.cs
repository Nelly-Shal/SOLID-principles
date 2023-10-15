namespace OCP
{
    using UnityEngine;

    /// <summary>
    /// Класс для сброса данных в разделе
    /// </summary>
    public class ResetCards : BaseResetData
    {
        /// <summary>
        /// Сброс данных в разделе карточки
        /// </summary>
        protected override void ResetData()
        {
            // FIXME: Исправить работы с префсами и логику сохранения данных в целом
            PlayerPrefs.DeleteKey("currentLevelCards");
            PlayerPrefs.DeleteKey("bestResultCards");
        }
    }
}