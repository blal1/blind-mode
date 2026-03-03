using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem.Runtime.Serialization;

namespace Il2CppSystem;

[System.Serializable]
public class ArrayTypeMismatchException : SystemException
{
	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0;

	static ArrayTypeMismatchException()
	{
		Il2CppClassPointerStore<ArrayTypeMismatchException>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "ArrayTypeMismatchException");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ArrayTypeMismatchException>.NativeClassPtr);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrayTypeMismatchException>.NativeClassPtr, 100664321);
		NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrayTypeMismatchException>.NativeClassPtr, 100664322);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 719778, RefRangeEnd = 719780, XrefRangeStart = 719775, XrefRangeEnd = 719778, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ArrayTypeMismatchException()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ArrayTypeMismatchException>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(12)]
	[CachedScanResults(RefRangeStart = 719641, RefRangeEnd = 719653, XrefRangeStart = 719641, XrefRangeEnd = 719653, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ArrayTypeMismatchException(SerializationInfo info, StreamingContext context)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ArrayTypeMismatchException>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)info);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)context));
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public ArrayTypeMismatchException(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
