namespace OCP
{
    using UnityEngine;

    /// <summary>
    /// Базовый класс для сброса данных
    /// </summary>
    public abstract class BaseResetData : MonoBehaviour
    {
        /// <summary>
        /// Метод для сброса данных
        /// </summary>
        protected abstract void ResetData();
    }
}