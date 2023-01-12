using UnityEditor;
using static System.IO.Directory;
using static System.IO.Path;
using static UnityEditor.AssetDatabase;
using static UnityEngine.Application;

public static class ToolsMenu
{
    [MenuItem("Tools/Setup/Create Default Folders")]
    public static void CreateDefaultFolders()
    {
        Dir("_Project", "Scripts","Scenes","Animations","Art","Audio","Scriptable Objects","Editor","Prefabs");
        Refresh();
    }

    public static void Dir(string root, params string[] dir)
    {
        var fullPath = Combine(dataPath, root);
        foreach (var newDirectory in dir)
        {
            CreateDirectory(Combine(fullPath, newDirectory));
        }
    }
}