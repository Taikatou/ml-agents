using Sensors.TopDown;
using Unity.MLAgents.Editor;
using UnityEditor;

internal class TopDownRayPerceptionSensorComponentBaseEditor : RayPerceptionSensorComponentBaseEditor
{
    [CustomEditor(typeof(TopDownRaySensorComponent))]
    [CanEditMultipleObjects]
    internal class TopDownRaySensorComponent2DEditor : RayPerceptionSensorComponentBaseEditor
    {
        public override void OnInspectorGUI()
        {
            OnRayPerceptionInspectorGUI(false);
        }

        protected override void AddProperties(SerializedObject so, bool is3d)
        {
            base.AddProperties(so, is3d);

            EditorGUILayout.PropertyField(so.FindProperty("verticalOffSet"), true);
            //EditorGUILayout.PropertyField(so.FindProperty("mAdversaryIds"), true);
            //EditorGUILayout.PropertyField(so.FindProperty("mSelfIds"), true);
        }
    }
}
