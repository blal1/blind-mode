using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem.Runtime.Serialization;

namespace Il2CppSystem;

[System.Serializable]
public class OutOfMemoryException : SystemException
{
	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0;

	static OutOfMemoryException()
	{
		Il2CppClassPointerStore<OutOfMemoryException>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "OutOfMemoryException");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OutOfMemoryException>.NativeClassPtr);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OutOfMemoryException>.NativeClassPtr, 100666378);
		NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OutOfMemoryException>.NativeClassPtr, 100666379);
		NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OutOfMemoryException>.NativeClassPtr, 100666380);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 750202, RefRangeEnd = 750203, XrefRangeStart = 750196, XrefRangeEnd = 750202, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe OutOfMemoryException()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OutOfMemoryException>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 750203, XrefRangeEnd = 750207, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe OutOfMemoryException(string message)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OutOfMemoryException>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(52)]
	[CachedScanResults(RefRangeStart = 735940, RefRangeEnd = 735992, XrefRangeStart = 735940, XrefRangeEnd = 735992, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe OutOfMemoryException(SerializationInfo info, StreamingContext context)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OutOfMemoryException>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)info);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)context));
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public OutOfMemoryException(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
