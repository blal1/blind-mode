using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Reflection;

namespace Il2CppSystem.Runtime.Serialization.Formatters.Binary;

public sealed class BinaryAssemblyInfo : Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_assemblyString;

	private static readonly System.IntPtr NativeFieldInfoPtr_assembly;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Internal_Void_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Internal_Void_String_Assembly_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetAssembly_Internal_Assembly_0;

	public unsafe string assemblyString
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_assemblyString);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_assemblyString)), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe Assembly assembly
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_assembly);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Assembly>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_assembly)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	static BinaryAssemblyInfo()
	{
		Il2CppClassPointerStore<BinaryAssemblyInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Serialization.Formatters.Binary", "BinaryAssemblyInfo");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BinaryAssemblyInfo>.NativeClassPtr);
		NativeFieldInfoPtr_assemblyString = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BinaryAssemblyInfo>.NativeClassPtr, "assemblyString");
		NativeFieldInfoPtr_assembly = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BinaryAssemblyInfo>.NativeClassPtr, "assembly");
		NativeMethodInfoPtr__ctor_Internal_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryAssemblyInfo>.NativeClassPtr, 100670824);
		NativeMethodInfoPtr__ctor_Internal_Void_String_Assembly_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryAssemblyInfo>.NativeClassPtr, 100670825);
		NativeMethodInfoPtr_GetAssembly_Internal_Assembly_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryAssemblyInfo>.NativeClassPtr, 100670826);
	}

	[CallerCount(215)]
	[CachedScanResults(RefRangeStart = 79185, RefRangeEnd = 79400, XrefRangeStart = 79185, XrefRangeEnd = 79400, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe BinaryAssemblyInfo(string assemblyString)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BinaryAssemblyInfo>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(assemblyString);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Internal_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(138)]
	[CachedScanResults(RefRangeStart = 141598, RefRangeEnd = 141736, XrefRangeStart = 141598, XrefRangeEnd = 141736, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe BinaryAssemblyInfo(string assemblyString, Assembly assembly)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BinaryAssemblyInfo>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(assemblyString);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)assembly);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Internal_Void_String_Assembly_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 799988, XrefRangeEnd = 799995, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Assembly GetAssembly()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetAssembly_Internal_Assembly_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Assembly>(intPtr2) : null;
	}

	public BinaryAssemblyInfo(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
