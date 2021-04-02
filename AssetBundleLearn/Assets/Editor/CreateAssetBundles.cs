using UnityEditor;
using System.IO;

public class CreateAssetBundles
{
    [MenuItem("Assets/Build AssetBundles")]
    public static void BuildAllAssetBundles()
    {
        string output = "AssetBundles";
        if (!Directory.Exists(output))
        {
            Directory.CreateDirectory(output);
        }
        BuildPipeline.BuildAssetBundles(output,BuildAssetBundleOptions.None, BuildTarget.StandaloneWindows64);

    }
}
