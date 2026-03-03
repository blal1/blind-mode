using System;
using Il2CppInterop.Runtime;

namespace UnityEngine;

public static class RendererExtensions
{
	private delegate void UpdateGIMaterialsForRenderer_InjectedDelegate(IntPtr renderer);

	private static readonly UpdateGIMaterialsForRenderer_InjectedDelegate UpdateGIMaterialsForRenderer_InjectedDelegateField = IL2CPP.ResolveICall<UpdateGIMaterialsForRenderer_InjectedDelegate>("UnityEngine.RendererExtensions::UpdateGIMaterialsForRenderer_Injected");

	public static void UpdateGIMaterials(Renderer renderer)
	{
		UpdateGIMaterialsForRenderer(renderer);
	}

	public static void UpdateGIMaterialsForRenderer(Renderer renderer)
	{
		UpdateGIMaterialsForRenderer_Injected(Object.MarshalledUnityObject.Marshal(renderer));
	}

	public static void UpdateGIMaterialsForRenderer_Injected(IntPtr renderer)
	{
		UpdateGIMaterialsForRenderer_InjectedDelegateField(renderer);
	}
}
