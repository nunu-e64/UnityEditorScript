using UnityEngine;
using UnityEditor;
using System.Reflection;

public class SukenChat : ScriptableObject
{
	static BindingFlags Flags = BindingFlags.Public | BindingFlags.Static;

	[MenuItem("Tool/SukenChat")]
	static void Open()
	{
		string typeName = "UnityEditor.Web.WebViewEditorWindow";
		var type = System.Reflection.Assembly.Load("UnityEngine.dll").GetType(typeName);
		var methodInfo = type.GetMethod("Create", Flags);
		methodInfo = methodInfo.MakeGenericMethod(typeof(SukenChat));
		methodInfo.Invoke(null, new object[] {
			"Suken_Chat",
			"http://chat.kanichat.com/chat?roomid=SukenChat72",
			100, 100, 200, 200
		});
	}
}