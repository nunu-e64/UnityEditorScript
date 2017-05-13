using UnityEditor;
using UnityEngine;
using System.Text.RegularExpressions;
using System.Reflection;

public class UnityKeyRemapEditor : EditorWindow
{
	// ゲームオブジェクトの有効、無効
	[MenuItem("Tool/KeyRemap/ActiveToggle &t")]
	static void KeyRemapActiveToggle()
	{
		foreach (var aObj in Selection.objects) {
			GameObject aGameObject = aObj as GameObject;
			if (aGameObject) {
				aGameObject.SetActive(!aGameObject.activeSelf);
			}
		}
	}

	// フォーカス変更
	[MenuItem("Tool/KeyRemap/Scene #&s")]
	static void KeyRemapScene()
	{
		CommonExecuteMenuItem("Window/Scene");
	}

	[MenuItem("Tool/KeyRemap/Scene #&g")]
	static void KeyRemapGame()
	{
		CommonExecuteMenuItem("Window/Game");
	}

	[MenuItem("Tool/KeyRemap/Inspector #&i")]
	static void KeyRemapInspector()
	{
		CommonExecuteMenuItem("Window/Inspector");
	}

	[MenuItem("Tool/KeyRemap/Hierarchy #&h")]
	static void KeyRemapHierarchy()
	{
		CommonExecuteMenuItem("Window/Hierarchy");
	}

	[MenuItem("Tool/KeyRemap/Project #&p")]
	static void KeyRemapProject()
	{
		CommonExecuteMenuItem("Window/Project");
	}

	[MenuItem("Tool/KeyRemap/Animation #&a")]
	static void KeyRemapAnimation()
	{
		CommonExecuteMenuItem("Window/Animation");
	}

	[MenuItem("Tool/KeyRemap/Console #&c")]
	static void KeyRemapConsole()
	{
		CommonExecuteMenuItem("Window/Console");
	}

	static void CommonExecuteMenuItem(string iStr)
	{
		EditorApplication.ExecuteMenuItem(iStr);
	}
}
