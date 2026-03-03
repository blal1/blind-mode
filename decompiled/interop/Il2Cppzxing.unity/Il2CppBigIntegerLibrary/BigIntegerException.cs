using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;

namespace Il2CppBigIntegerLibrary;

[System.Serializable]
public sealed class BigIntegerException : Il2CppSystem.Exception
{
	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Exception_0;

	static BigIntegerException()
	{
		Il2CppClassPointerStore<BigIntegerException>.NativeClassPtr = IL2CPP.GetIl2CppClass("zxing.unity.dll", "BigIntegerLibrary", "BigIntegerException");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BigIntegerException>.NativeClassPtr);
		NativeMethodInfoPtr__ctor_Public_Void_String_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigIntegerException>.NativeClassPtr, 100663377);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1412260, XrefRangeEnd = 1412264, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe BigIntegerException(string message, Il2CppSystem.Exception innerException)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BigIntegerException>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)innerException);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_String_Exception_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public BigIntegerException(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
