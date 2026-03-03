using Il2CppSystem;

namespace UnityEngine;

public sealed class GUIElement
{
	public static void FeatureRemoved()
	{
		throw new Exception("GUIElement has been removed from Unity. Consider using https://docs.unity3d.com/ScriptReference/UIElements.Image.html, https://docs.unity3d.com/ScriptReference/UIElements.TextElement.html or TextMeshPro instead.");
	}

	public bool HitTest(Vector3 screenPosition)
	{
		FeatureRemoved();
		return false;
	}

	public bool HitTest(Vector3 screenPosition, Camera camera)
	{
		FeatureRemoved();
		return false;
	}

	public Rect GetScreenRect(Camera camera)
	{
		FeatureRemoved();
		return new Rect(0f, 0f, 0f, 0f);
	}

	public Rect GetScreenRect()
	{
		FeatureRemoved();
		return new Rect(0f, 0f, 0f, 0f);
	}
}
