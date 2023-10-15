namespace SRP
{
    using UnityEngine;
    using UnityEngine.SceneManagement;

    /// <summary>
    /// ��������� �������� ����
    /// � ������ ����� ���� ���������� ������ LoadScene() � ReLoadScene() �� MainMenuController
    /// ����� ������� ������ �������� ���� ����� ������������ ���������� �� ������ ������� �����
    /// </summary>
    public class SceneLoadController : MonoBehaviour
    {
        /// <summary>
        /// ��������� �����
        /// </summary>
        /// <param name="nameScene"></param>
        public void LoadScene(string nameScene) => SceneManager.LoadScene(nameScene);

        /// <summary>
        /// ������������� ������� �����
        /// </summary>
        public void ReloadScene() => SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}