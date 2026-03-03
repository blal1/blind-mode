using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;

namespace Il2CppJetBrains.Annotations;

public sealed class MustUseReturnValueAttribute : Il2CppSystem.Attribute
{
	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public string Justification
	{
		get
		{
			throw new System.NotSupportedException("Method unstripping failed");
		}
	}

	static MustUseReturnValueAttribute()
	{
		Il2CppClassPointerStore<MustUseReturnValueAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "JetBrains.Annotations", "MustUseReturnValueAttribute");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MustUseReturnValueAttribute>.NativeClassPtr);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MustUseReturnValueAttribute>.NativeClassPtr, 100663681);
	}

	[CallerCount(134)]
	[CachedScanResults(RefRangeStart = 24861, RefRangeEnd = 24995, XrefRangeStart = 24861, XrefRangeEnd = 24995, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe MustUseReturnValueAttribute()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MustUseReturnValueAttribute>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public MustUseReturnValueAttribute(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
