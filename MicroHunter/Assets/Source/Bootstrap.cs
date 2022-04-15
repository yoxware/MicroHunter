using UnityEngine;

namespace Yoxware
{
    public sealed class Bootstrap : MonoBehaviour
    {
        private GameSystems gameSystems;

        private void Start()
        {
            Contexts contexts = Contexts.sharedInstance;
            gameSystems = new GameSystems(contexts);
            // calls Entitas systems denoted as InitializeSystems (run at the start of the game)
            gameSystems.Initialize();
        }

        private void Update()
        {
            // calls Entitas systems denoted as ExecuteSystems (run every frame)
            gameSystems.Execute();
        }
    }
}