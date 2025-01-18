using Reflex.Core;
using UnityEngine;

public class GameInitializer : MonoBehaviour, IInstaller
{
    public void InstallBindings(ContainerBuilder containerBuilder)
    {
        containerBuilder.AddSingleton(new Weapon("Sword"), typeof(Weapon));
        containerBuilder.AddSingleton(new Weapon("Gun"), typeof(Weapon));

        containerBuilder.AddSingleton<Player>(container => new Player(container.Resolve<Weapon>()));

    }
}