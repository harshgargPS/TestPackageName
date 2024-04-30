using UnityEditor;

namespace TestEditor
{
    public class EditorTestClass
    {
        [MenuItem("PSTools/HelloTool")]
        public static void PrintHello() {
            UnityEngine.Debug.LogError("Hello world from editor");
        }

        [MenuItem("PSTools/HelloTool2")]
        public static void PrintHelloXYZ()
        {
            TestClass.PrintHello();
        }
    }
}