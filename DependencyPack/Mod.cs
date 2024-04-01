using Colossal.Logging;
using Game;
using Game.Modding;
using Game.SceneFlow;
using HarmonyLib;
using Unity.Entities;

namespace DependencyPack
{
    public class Mod : IMod
    {
        public static ILog log = LogManager.GetLogger( $"{nameof( DependencyPack )}.{nameof( Mod )}" ).SetShowsErrorsInUI( false );

        public void OnLoad( UpdateSystem updateSystem )
        {
            InitialiseHarmony( );
        }

        public void OnDispose( )
        {
        }

        private void InitialiseHarmony( )
        {
            var harmony = new Harmony( "cities2modding.harmonyx_lib" );
            log.Info( $"DependencyPack has loaded Harmony" );
        }
    }
}
