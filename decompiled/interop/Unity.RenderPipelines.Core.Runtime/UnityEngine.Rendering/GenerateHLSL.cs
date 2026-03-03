using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;

namespace UnityEngine.Rendering;

public class GenerateHLSL : Il2CppSystem.Attribute
{
	private static readonly System.IntPtr NativeFieldInfoPtr_packingRules;

	private static readonly System.IntPtr NativeFieldInfoPtr_containsPackedFields;

	private static readonly System.IntPtr NativeFieldInfoPtr_needAccessors;

	private static readonly System.IntPtr NativeFieldInfoPtr_needSetters;

	private static readonly System.IntPtr NativeFieldInfoPtr_needParamDebug;

	private static readonly System.IntPtr NativeFieldInfoPtr_paramDefinesStart;

	private static readonly System.IntPtr NativeFieldInfoPtr_omitStructDeclaration;

	private static readonly System.IntPtr NativeFieldInfoPtr_generateCBuffer;

	private static readonly System.IntPtr NativeFieldInfoPtr_constantRegister;

	private static readonly System.IntPtr NativeFieldInfoPtr_sourcePath;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_PackingRules_Boolean_Boolean_Boolean_Int32_Boolean_Boolean_Boolean_Int32_String_0;

	public unsafe PackingRules packingRules
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_packingRules);
			return *(PackingRules*)num;
		}
		set
		{
			*(PackingRules*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_packingRules)) = value;
		}
	}

	public unsafe bool containsPackedFields
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_containsPackedFields);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_containsPackedFields)) = value;
		}
	}

	public unsafe bool needAccessors
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_needAccessors);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_needAccessors)) = value;
		}
	}

	public unsafe bool needSetters
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_needSetters);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_needSetters)) = value;
		}
	}

	public unsafe bool needParamDebug
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_needParamDebug);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_needParamDebug)) = value;
		}
	}

	public unsafe int paramDefinesStart
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_paramDefinesStart);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_paramDefinesStart)) = value;
		}
	}

	public unsafe bool omitStructDeclaration
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_omitStructDeclaration);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_omitStructDeclaration)) = value;
		}
	}

	public unsafe bool generateCBuffer
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_generateCBuffer);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_generateCBuffer)) = value;
		}
	}

	public unsafe int constantRegister
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_constantRegister);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_constantRegister)) = value;
		}
	}

	public unsafe string sourcePath
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sourcePath);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sourcePath)), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	static GenerateHLSL()
	{
		Il2CppClassPointerStore<GenerateHLSL>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Core.Runtime.dll", "UnityEngine.Rendering", "GenerateHLSL");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GenerateHLSL>.NativeClassPtr);
		NativeFieldInfoPtr_packingRules = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenerateHLSL>.NativeClassPtr, "packingRules");
		NativeFieldInfoPtr_containsPackedFields = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenerateHLSL>.NativeClassPtr, "containsPackedFields");
		NativeFieldInfoPtr_needAccessors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenerateHLSL>.NativeClassPtr, "needAccessors");
		NativeFieldInfoPtr_needSetters = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenerateHLSL>.NativeClassPtr, "needSetters");
		NativeFieldInfoPtr_needParamDebug = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenerateHLSL>.NativeClassPtr, "needParamDebug");
		NativeFieldInfoPtr_paramDefinesStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenerateHLSL>.NativeClassPtr, "paramDefinesStart");
		NativeFieldInfoPtr_omitStructDeclaration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenerateHLSL>.NativeClassPtr, "omitStructDeclaration");
		NativeFieldInfoPtr_generateCBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenerateHLSL>.NativeClassPtr, "generateCBuffer");
		NativeFieldInfoPtr_constantRegister = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenerateHLSL>.NativeClassPtr, "constantRegister");
		NativeFieldInfoPtr_sourcePath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenerateHLSL>.NativeClassPtr, "sourcePath");
		NativeMethodInfoPtr__ctor_Public_Void_PackingRules_Boolean_Boolean_Boolean_Int32_Boolean_Boolean_Boolean_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenerateHLSL>.NativeClassPtr, 100666051);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1046917, XrefRangeEnd = 1046919, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe GenerateHLSL(PackingRules rules = PackingRules.Exact, bool needAccessors = true, bool needSetters = false, bool needParamDebug = false, int paramDefinesStart = 1, bool omitStructDeclaration = false, bool containsPackedFields = false, bool generateCBuffer = false, int constantRegister = -1, string sourcePath = null)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GenerateHLSL>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[10];
		*ptr = (nint)(&rules);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &needAccessors;
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &needSetters;
		*(bool**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &needParamDebug;
		*(int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &paramDefinesStart;
		*(bool**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &omitStructDeclaration;
		*(bool**)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = &containsPackedFields;
		*(bool**)((byte*)ptr + checked((nuint)7u * unchecked((nuint)sizeof(System.IntPtr)))) = &generateCBuffer;
		*(int**)((byte*)ptr + checked((nuint)8u * unchecked((nuint)sizeof(System.IntPtr)))) = &constantRegister;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)9u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(sourcePath);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_PackingRules_Boolean_Boolean_Boolean_Int32_Boolean_Boolean_Boolean_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public GenerateHLSL(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
