using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace Il2CppSystem.Runtime.Serialization.Formatters.Binary;

public static class IOUtil : Object
{
	private static readonly System.IntPtr NativeMethodInfoPtr_FlagTest_Internal_Static_Boolean_MessageEnum_MessageEnum_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_WriteStringWithCode_Internal_Static_Void_String___BinaryWriter_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_WriteWithCode_Internal_Static_Void_Type_Object___BinaryWriter_0;

	static IOUtil()
	{
		Il2CppClassPointerStore<IOUtil>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Serialization.Formatters.Binary", "IOUtil");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IOUtil>.NativeClassPtr);
		NativeMethodInfoPtr_FlagTest_Internal_Static_Boolean_MessageEnum_MessageEnum_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IOUtil>.NativeClassPtr, 100670821);
		NativeMethodInfoPtr_WriteStringWithCode_Internal_Static_Void_String___BinaryWriter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IOUtil>.NativeClassPtr, 100670822);
		NativeMethodInfoPtr_WriteWithCode_Internal_Static_Void_Type_Object___BinaryWriter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IOUtil>.NativeClassPtr, 100670823);
	}

	[CallerCount(0)]
	public unsafe static bool FlagTest(MessageEnum flag, MessageEnum target)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&flag);
		*(MessageEnum**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &target;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FlagTest_Internal_Static_Boolean_MessageEnum_MessageEnum_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 799973, RefRangeEnd = 799976, XrefRangeStart = 799972, XrefRangeEnd = 799973, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void WriteStringWithCode(string value, __BinaryWriter sout)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)sout);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_WriteStringWithCode_Internal_Static_Void_String___BinaryWriter_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 799987, RefRangeEnd = 799988, XrefRangeStart = 799976, XrefRangeEnd = 799987, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void WriteWithCode(Type type, Object value, __BinaryWriter sout)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)type);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)sout);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_WriteWithCode_Internal_Static_Void_Type_Object___BinaryWriter_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public IOUtil(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
