using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace Il2CppSystem.Runtime.CompilerServices;

[System.Serializable]
public sealed class IteratorStateMachineAttribute : StateMachineAttribute
{
	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Type_0;

	static IteratorStateMachineAttribute()
	{
		Il2CppClassPointerStore<IteratorStateMachineAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.CompilerServices", "IteratorStateMachineAttribute");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IteratorStateMachineAttribute>.NativeClassPtr);
		NativeMethodInfoPtr__ctor_Public_Void_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IteratorStateMachineAttribute>.NativeClassPtr, 100671398);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 684810, RefRangeEnd = 684814, XrefRangeStart = 684810, XrefRangeEnd = 684814, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe IteratorStateMachineAttribute(Type stateMachineType)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IteratorStateMachineAttribute>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)stateMachineType);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public IteratorStateMachineAttribute(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
