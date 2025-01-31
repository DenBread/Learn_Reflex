using Reflex.Attributes;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class GameManager : MonoBehaviour
{
    [Inject] private Fader _fader;

    private void Start()
    {
        StartCoroutine(AutoSceneSwitch());
    }

    private IEnumerator AutoSceneSwitch()
    {
        while (true) // Бесконечный цикл переключения сцен
        {
            yield return new WaitForSeconds(3f); // Ждем перед переходом

            string currentScene = SceneManager.GetActiveScene().name;
            string nextScene = currentScene == "Lesson_3_a" ? "Lesson_3_b" : "Lesson_3_a";

            yield return StartCoroutine(TransitionScene(nextScene));
        }
    }

    private IEnumerator TransitionScene(string sceneName)
    {
        _fader.FadeIn(1f); // Затемняем экран
        yield return new WaitForSeconds(1f); // Ждем окончания анимации

        SceneManager.LoadScene(sceneName); // Загружаем следующую сцену
        yield return null; // Ждем загрузки сцены

        _fader.FadeOut(1f); // Показываем новую сцену
    }
}