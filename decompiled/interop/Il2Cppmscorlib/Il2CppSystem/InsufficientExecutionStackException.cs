using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem.Runtime.Serialization;

namespace Il2CppSystem;

[System.Serializable]
public sealed class InsufficientExecutionStackException : SystemException
{
	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Internal_Void_SerializationInfo_StreamingContext_0;

	static InsufficientExecutionStackException()
	{
		Il2CppClassPointerStore<InsufficientExecutionStackException>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "InsufficientExecutionStackException");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InsufficientExecutionStackException>.NativeClassPtr);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InsufficientExecutionStackException>.NativeClassPtr, 100665209);
		NativeMethodInfoPtr__ctor_Internal_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InsufficientExecutionStackException>.NativeClassPtr, 100665210);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 728445, XrefRangeEnd = 728448, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe InsufficientExecutionStackException()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InsufficientExecutionStackException>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(12)]
	[CachedScanResults(RefRangeStart = 719641, RefRangeEnd = 719653, XrefRangeStart = 719641, XrefRangeEnd = 719653, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe InsufficientExecutionStackException(SerializationInfo info, StreamingContext context)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InsufficientExecutionStackException>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)info);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)context));
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Internal_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public InsufficientExecutionStackException(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
