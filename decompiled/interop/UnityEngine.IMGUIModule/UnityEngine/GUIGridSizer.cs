using System;
using Il2CppInterop.Runtime.InteropTypes.Arrays;

namespace UnityEngine;

public sealed class GUIGridSizer : GUILayoutEntry
{
	public int rows
	{
		get
		{
			throw new NotSupportedException("Method unstripping failed");
		}
	}

	public static Rect GetRect(Il2CppReferenceArray<GUIContent> contents, int xCount, GUIStyle style, Il2CppReferenceArray<GUILayoutOption> options)
	{
		Rect result = new Rect(0f, 0f, 0f, 0f);
		switch (Event.current.type)
		{
		case EventType.Layout:
			GUILayoutUtility.current.topLevel.Add(new GUIGridSizer(contents, xCount, style, options));
			break;
		case EventType.Used:
			return GUILayoutEntry.kDummyRect;
		default:
			result = GUILayoutUtility.current.topLevel.GetNext().rect;
			break;
		}
		return result;
	}
}
