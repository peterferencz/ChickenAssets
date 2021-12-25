
namespace ChickenAssets.Debug {
    using UnityEditor;
    using UnityEngine;
    using UnityEngine.UI;

    public static class DebugExtension {

        private static GameObject WorldCanvas = null;


        /// <summary>
        /// Draws 4 lines representing a rectangle
        /// ! Must be inside OnDrawGizmos, or OnDrawGizmosSelected !
        /// </summary>
        public static void DrawRect(Vector2 origin, float width, float height) {
            // 1 --- 2
            // |     |
            // 3 --- 4

            float halfW = width / 2;
            float halfH = height / 2;

            Debug.DrawLine(new Vector3(origin.x - halfW, origin.y + halfH), new Vector3(origin.x + halfW, origin.y + halfH)); //1 - 2
            Debug.DrawLine(new Vector3(origin.x + halfW, origin.y + halfH), new Vector3(origin.x + halfW, origin.y - halfH)); //2 - 4
            Debug.DrawLine(new Vector3(origin.x + halfW, origin.y - halfH), new Vector3(origin.x - halfW, origin.y - halfH)); //4 - 3
            Debug.DrawLine(new Vector3(origin.x - halfW, origin.y - halfH), new Vector3(origin.x - halfW, origin.y + halfH)); //3 - 2
        }

        public static TextMesh DrawText(Vector2 origin, string text, Color color, float size = 1) {
            GameObject obj = new GameObject($"WT_{text}", typeof(TextMesh));
            TextMesh textComponent = obj.GetComponent<TextMesh>();
            textComponent.text = text;
            textComponent.anchor = TextAnchor.MiddleCenter;
            textComponent.alignment = TextAlignment.Center;
            textComponent.color = color;
            textComponent.characterSize = size;
            return textComponent;
        }
    }
}