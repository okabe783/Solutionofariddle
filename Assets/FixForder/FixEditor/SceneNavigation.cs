using UnityEditor;
using UnityEditor.SceneManagement;
using UnityEngine.SceneManagement;

public static class SceneNavigation
{
    [MenuItem("Scene/Title")]
    public static void OpenScene0()
    {
        EditorSceneManager.SaveOpenScenes();
        OpenScene(0);
    }
    
    [MenuItem("Scene/InGame")]
    public static void OpenScene1()
    {
        EditorSceneManager.SaveOpenScenes();
        OpenScene(1);
    }
    
    [MenuItem("Scene/Result")]
    public static void OpenScene2()
    {
        EditorSceneManager.SaveOpenScenes();
        OpenScene(0);
    }
    //シーンを保存して別のシーンに移動
    private static void OpenScene(int sceneIndex)
    {
        string scenePath = SceneUtility.GetScenePathByBuildIndex(sceneIndex);
        if (!string.IsNullOrEmpty(scenePath))
        {
            EditorSceneManager.OpenScene(scenePath);
        }
    }
}
