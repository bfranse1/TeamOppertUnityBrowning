using UnityEditor;

class CommandLine
{
    static void Build()
    {
        string[] scenes = { "Assets/Scenes/SampleScene.unity" };
        BuildPipeline.BuildPlayer(scenes);
    }
}

