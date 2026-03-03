using System;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;

namespace UnityEngine.Experimental.U2D;

public class SpriteRendererGroup : Il2CppSystem.Object
{
	private delegate void AddRenderersDelegate(System.IntPtr renderers, int count);

	private delegate void ClearDelegate();

	private static readonly AddRenderersDelegate AddRenderersDelegateField;

	private static readonly ClearDelegate ClearDelegateField;

	static SpriteRendererGroup()
	{
		Il2CppClassPointerStore<SpriteRendererGroup>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Experimental.U2D", "SpriteRendererGroup");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpriteRendererGroup>.NativeClassPtr);
		AddRenderersDelegateField = IL2CPP.ResolveICall<AddRenderersDelegate>("UnityEngine.Experimental.U2D.SpriteRendererGroup::AddRenderers");
		ClearDelegateField = IL2CPP.ResolveICall<ClearDelegate>("UnityEngine.Experimental.U2D.SpriteRendererGroup::Clear");
	}

	public SpriteRendererGroup(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public unsafe static void AddRenderers(NativeArray<SpriteIntermediateRendererInfo> renderers)
	{
		//IL_000f: Expected O, but got Ref
		AddRenderers(renderers.GetUnsafeReadOnlyPtr(), ((NativeArray<SpriteIntermediateRendererInfo>)(&renderers)).Length);
	}

	public unsafe static void AddRenderers(void* renderers, int count)
	{
		AddRenderersDelegateField((nint)renderers, count);
	}

	public static void Clear()
	{
		ClearDelegateField();
	}
}
