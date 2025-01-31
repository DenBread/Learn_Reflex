using Reflex.Core;
using Reflex.Injectors;
using UnityEngine;

public class FaderInstaller : MonoBehaviour, IInstaller
{
    [SerializeField] private Fader _prefabFader;
    
    public void InstallBindings(ContainerBuilder builder)
    {
        // Создаем Fader в рантайме
        GameObject faderObject = Instantiate(_prefabFader.gameObject);
        faderObject.name = "FaderSystem";
        DontDestroyOnLoad(faderObject);

        // Получаем Fader и CanvasGroup
        Fader fader = faderObject.GetComponent<Fader>();
        CanvasGroup canvasGroup = faderObject.GetComponent<CanvasGroup>();

        if (fader == null || canvasGroup == null)
        {
            Debug.LogError("FaderInstaller: Fader или CanvasGroup отсутствуют на префабе!");
            return;
        }

        // Добавляем CanvasGroup в контейнер ПЕРЕД инъекцией
        builder.AddSingleton<CanvasGroup>(_ => canvasGroup);
        builder.AddSingleton<Fader>(_ => fader);

        // Получаем контейнер
        var container = builder.Build();

        // Вызываем инъекцию зависимостей
        GameObjectInjector.InjectObject(faderObject, container);
    }
}