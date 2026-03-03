using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace UnityEngine.VFX;

[Serializable]
public class EventAttributeColor : EventAttributeVector3
{
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	static EventAttributeColor()
	{
		Il2CppClassPointerStore<EventAttributeColor>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.VisualEffectGraph.Runtime.dll", "UnityEngine.VFX", "EventAttributeColor");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EventAttributeColor>.NativeClassPtr);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventAttributeColor>.NativeClassPtr, 100663358);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe EventAttributeColor()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EventAttributeColor>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public EventAttributeColor(IntPtr pointer)
		: base(pointer)
	{
	}
}
