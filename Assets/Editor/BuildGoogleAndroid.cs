using UnityEngine;
using UnityEditor;

public class BuildGoogleAndroid : Editor
{
    [MenuItem("Tools/BuildGoogleProject")]
    static public void BuildAssetBundles()
    {
        BuildPipeline.BuildPlayer(new string[] { "Assets/Main.unity" }, Application.dataPath + "/../", BuildTarget.Android, BuildOptions.AcceptExternalModificationsToPlayer);
    }
}