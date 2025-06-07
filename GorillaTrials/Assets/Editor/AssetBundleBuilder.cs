using UnityEngine;
using UnityEditor;
using System.IO;

public class AssetBundleBuilder
{
	public static string outputDirectory = "";
    [MenuItem("Bundles/Build AssetBundles")]
    static void BuildAllAssetBundles()
    {
		if (outputDirectory == "")
			outputDirectory = EditorUtility.OpenFolderPanel("Select Your Folder To Build Bundles To", "", "");
		
        if (!Directory.Exists(outputDirectory))
        {
            Debug.Log("Output Folder Doesn't Exist");
            return;
        }
        BuildPipeline.BuildAssetBundles(outputDirectory, BuildAssetBundleOptions.None, EditorUserBuildSettings.activeBuildTarget);
    }
}