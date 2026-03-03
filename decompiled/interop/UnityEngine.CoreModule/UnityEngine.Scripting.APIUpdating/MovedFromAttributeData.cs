using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;

namespace UnityEngine.Scripting.APIUpdating;

public sealed class MovedFromAttributeData : Il2CppSystem.ValueType
{
	private static readonly System.IntPtr NativeFieldInfoPtr_className;

	private static readonly System.IntPtr NativeFieldInfoPtr_nameSpace;

	private static readonly System.IntPtr NativeFieldInfoPtr_assembly;

	private static readonly System.IntPtr NativeFieldInfoPtr_classHasChanged;

	private static readonly System.IntPtr NativeFieldInfoPtr_nameSpaceHasChanged;

	private static readonly System.IntPtr NativeFieldInfoPtr_assemblyHasChanged;

	private static readonly System.IntPtr NativeFieldInfoPtr_autoUdpateAPI;

	private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Void_Boolean_String_String_String_0;

	public unsafe string className
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_className);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_className)), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe string nameSpace
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_nameSpace);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_nameSpace)), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe string assembly
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_assembly);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_assembly)), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe bool classHasChanged
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_classHasChanged);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_classHasChanged)) = value;
		}
	}

	public unsafe bool nameSpaceHasChanged
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_nameSpaceHasChanged);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_nameSpaceHasChanged)) = value;
		}
	}

	public unsafe bool assemblyHasChanged
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_assemblyHasChanged);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_assemblyHasChanged)) = value;
		}
	}

	public unsafe bool autoUdpateAPI
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_autoUdpateAPI);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_autoUdpateAPI)) = value;
		}
	}

	static MovedFromAttributeData()
	{
		Il2CppClassPointerStore<MovedFromAttributeData>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Scripting.APIUpdating", "MovedFromAttributeData");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MovedFromAttributeData>.NativeClassPtr);
		NativeFieldInfoPtr_className = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MovedFromAttributeData>.NativeClassPtr, "className");
		NativeFieldInfoPtr_nameSpace = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MovedFromAttributeData>.NativeClassPtr, "nameSpace");
		NativeFieldInfoPtr_assembly = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MovedFromAttributeData>.NativeClassPtr, "assembly");
		NativeFieldInfoPtr_classHasChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MovedFromAttributeData>.NativeClassPtr, "classHasChanged");
		NativeFieldInfoPtr_nameSpaceHasChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MovedFromAttributeData>.NativeClassPtr, "nameSpaceHasChanged");
		NativeFieldInfoPtr_assemblyHasChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MovedFromAttributeData>.NativeClassPtr, "assemblyHasChanged");
		NativeFieldInfoPtr_autoUdpateAPI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MovedFromAttributeData>.NativeClassPtr, "autoUdpateAPI");
		NativeMethodInfoPtr_Set_Public_Void_Boolean_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MovedFromAttributeData>.NativeClassPtr, 100667250);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1228432, RefRangeEnd = 1228433, XrefRangeStart = 1228429, XrefRangeEnd = 1228432, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Set(bool autoUpdateAPI, string sourceNamespace = null, string sourceAssembly = null, string sourceClassName = null)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&autoUpdateAPI);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(sourceNamespace);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(sourceAssembly);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(sourceClassName);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Set_Public_Void_Boolean_String_String_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public MovedFromAttributeData(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public MovedFromAttributeData()
		: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MovedFromAttributeData>.NativeClassPtr))
	{
	}
}
