using Entitas;

namespace Yoxware
{
    public class CreateEntitySystem : IInitializeSystem
    {
        // Context is a data structure for managing entities
        // Context manages the life cycle of all entities created; first observer notifed on entity manipulation
        private readonly Contexts contexts;

        public CreateEntitySystem(Contexts contexts)
        {
            this.contexts = contexts;
        }

        // InitializeSystems are used for creating initial game state at start

        public void Initialize()
        {
            // contexts.game access the entity manager for Game entities (see Jenny codegen for details)
            contexts.game.CreateEntity();
        }
    }
}