namespace SRP
{
    using UnityEngine;
    using UnityEngine.SceneManagement;

    /// <summary>
    /// Контролер загрузки сцен
    /// В данный класс были перенесены методы LoadScene() и ReLoadScene() из MainMenuController
    /// Таким образом методы загрузки сцен можно использовать независимо от логики текущей сцены
    /// </summary>
    public class SceneLoadController : MonoBehaviour
    {
        /// <summary>
        /// Загрузить сцену
        /// </summary>
        /// <param name="nameScene"></param>
        public void LoadScene(string nameScene) => SceneManager.LoadScene(nameScene);

        /// <summary>
        /// Перезагрузить текущую сцену
        /// </summary>
        public void ReloadScene() => SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}