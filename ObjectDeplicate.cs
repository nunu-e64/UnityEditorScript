// 【Unity】Ctrl + Dで複製したオブジェクトから（1）を無くし、元オブジェクトの下に生成する
// https://gist.github.com/tsubaki/320619a75116ba9e948d4e54e7906b1d
using UnityEngine;
using UnityEditor;

public class ObjectDeplicate
{
    [MenuItem("Edit/DummyDeplicate %d", false, -1)]
    static void CreateEmptyObjec2t()
    {
        foreach (var obj in Selection.objects)
        {
            var path = AssetDatabase.GetAssetPath(obj);
            if (path == string.Empty)
            {
                var gameObject = obj as GameObject;
                var copy = GameObject.Instantiate(gameObject, gameObject.transform.parent);
                copy.name = obj.name;
                copy.transform.SetSiblingIndex(gameObject.transform.GetSiblingIndex());
                Undo.RegisterCreatedObjectUndo (copy, "deplicate");
            }
            else
            {
                var newPath = AssetDatabase.GenerateUniqueAssetPath(path);
                AssetDatabase.CopyAsset(path, newPath);
            }
        }
    }
}
