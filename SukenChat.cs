using UnityEngine;
using UnityEditor;
using System.Reflection;

public class SukenChat : ScriptableObject {
	static BindingFlags Flags = BindingFlags.Public | BindingFlags.Static;

	[MenuItem ("Tool/SukenChat")]
	static void Open () {
		var type = Types.GetType ("UnityEditor.Web.WebViewEditorWindow", "UnityEditor.dll");
		var methodInfo = type.GetMethod ("Create", Flags);
		methodInfo = methodInfo.MakeGenericMethod (typeof (SukenChat));
		methodInfo.Invoke (null, new object[]{
            "Suken_Chat",
            "http://chat.kanichat.com/chat?roomid=SukenChat72",
            100, 100, 200, 200
        });
	}
}