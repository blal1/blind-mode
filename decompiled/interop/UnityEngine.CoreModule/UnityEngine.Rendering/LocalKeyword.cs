using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;
using UnityEngine.Bindings;

namespace UnityEngine.Rendering;

public sealed class LocalKeyword : Il2CppSystem.ValueType
{
	private delegate bool IsDynamic_InjectedDelegate([In] System.IntPtr kw);

	private delegate bool IsOverridable_InjectedDelegate([In] System.IntPtr kw);

	private delegate ShaderKeywordType GetKeywordType_InjectedDelegate([In] System.IntPtr spaceInfo, uint keyword);

	private delegate bool IsValid_InjectedDelegate([In] System.IntPtr spaceInfo, uint keyword);

	private static readonly System.IntPtr NativeFieldInfoPtr_m_SpaceInfo;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_Name;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_Index;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetShaderKeywordCount_Private_Static_UInt32_Shader_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetShaderKeywordIndex_Private_Static_UInt32_Shader_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetComputeShaderKeywordCount_Private_Static_UInt32_ComputeShader_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetComputeShaderKeywordIndex_Private_Static_UInt32_ComputeShader_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_name_Public_get_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Shader_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_ComputeShader_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_LocalKeyword_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetShaderKeywordCount_Injected_Private_Static_UInt32_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetShaderKeywordIndex_Injected_Private_Static_UInt32_IntPtr_byref_ManagedSpanWrapper_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetComputeShaderKeywordCount_Injected_Private_Static_UInt32_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetComputeShaderKeywordIndex_Injected_Private_Static_UInt32_IntPtr_byref_ManagedSpanWrapper_0;

	private static readonly IsDynamic_InjectedDelegate IsDynamic_InjectedDelegateField;

	private static readonly IsOverridable_InjectedDelegate IsOverridable_InjectedDelegateField;

	private static readonly GetKeywordType_InjectedDelegate GetKeywordType_InjectedDelegateField;

	private static readonly IsValid_InjectedDelegate IsValid_InjectedDelegateField;

	public unsafe LocalKeywordSpace m_SpaceInfo
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_SpaceInfo);
			return *(LocalKeywordSpace*)num;
		}
		set
		{
			*(LocalKeywordSpace*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_SpaceInfo)) = value;
		}
	}

	public unsafe string m_Name
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Name);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Name)), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe uint m_Index
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Index);
			return *(uint*)num;
		}
		set
		{
			*(uint*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Index)) = value;
		}
	}

	public unsafe string name
	{
		[CallerCount(29)]
		[CachedScanResults(RefRangeStart = 765815, RefRangeEnd = 765844, XrefRangeStart = 765815, XrefRangeEnd = 765844, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_name_Public_get_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return IL2CPP.Il2CppStringToManaged(intPtr2);
		}
	}

	public unsafe bool isDynamic => IsDynamic(Unsafe.Read<LocalKeyword>((void*)(nint)this));

	public unsafe bool isOverridable => IsOverridable(Unsafe.Read<LocalKeyword>((void*)(nint)this));

	public bool isValid => IsValid(m_SpaceInfo, m_Index);

	public ShaderKeywordType type => GetKeywordType(m_SpaceInfo, m_Index);

	static LocalKeyword()
	{
		Il2CppClassPointerStore<LocalKeyword>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Rendering", "LocalKeyword");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LocalKeyword>.NativeClassPtr);
		NativeFieldInfoPtr_m_SpaceInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalKeyword>.NativeClassPtr, "m_SpaceInfo");
		NativeFieldInfoPtr_m_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalKeyword>.NativeClassPtr, "m_Name");
		NativeFieldInfoPtr_m_Index = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalKeyword>.NativeClassPtr, "m_Index");
		NativeMethodInfoPtr_GetShaderKeywordCount_Private_Static_UInt32_Shader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalKeyword>.NativeClassPtr, 100668850);
		NativeMethodInfoPtr_GetShaderKeywordIndex_Private_Static_UInt32_Shader_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalKeyword>.NativeClassPtr, 100668851);
		NativeMethodInfoPtr_GetComputeShaderKeywordCount_Private_Static_UInt32_ComputeShader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalKeyword>.NativeClassPtr, 100668852);
		NativeMethodInfoPtr_GetComputeShaderKeywordIndex_Private_Static_UInt32_ComputeShader_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalKeyword>.NativeClassPtr, 100668853);
		NativeMethodInfoPtr_get_name_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalKeyword>.NativeClassPtr, 100668854);
		NativeMethodInfoPtr__ctor_Public_Void_Shader_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalKeyword>.NativeClassPtr, 100668855);
		NativeMethodInfoPtr__ctor_Public_Void_ComputeShader_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalKeyword>.NativeClassPtr, 100668856);
		NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalKeyword>.NativeClassPtr, 100668857);
		NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalKeyword>.NativeClassPtr, 100668858);
		NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_LocalKeyword_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalKeyword>.NativeClassPtr, 100668859);
		NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalKeyword>.NativeClassPtr, 100668860);
		NativeMethodInfoPtr_GetShaderKeywordCount_Injected_Private_Static_UInt32_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalKeyword>.NativeClassPtr, 100668861);
		NativeMethodInfoPtr_GetShaderKeywordIndex_Injected_Private_Static_UInt32_IntPtr_byref_ManagedSpanWrapper_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalKeyword>.NativeClassPtr, 100668862);
		NativeMethodInfoPtr_GetComputeShaderKeywordCount_Injected_Private_Static_UInt32_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalKeyword>.NativeClassPtr, 100668863);
		NativeMethodInfoPtr_GetComputeShaderKeywordIndex_Injected_Private_Static_UInt32_IntPtr_byref_ManagedSpanWrapper_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalKeyword>.NativeClassPtr, 100668864);
		IsDynamic_InjectedDelegateField = IL2CPP.ResolveICall<IsDynamic_InjectedDelegate>("UnityEngine.Rendering.LocalKeyword::IsDynamic_Injected");
		IsOverridable_InjectedDelegateField = IL2CPP.ResolveICall<IsOverridable_InjectedDelegate>("UnityEngine.Rendering.LocalKeyword::IsOverridable_Injected");
		GetKeywordType_InjectedDelegateField = IL2CPP.ResolveICall<GetKeywordType_InjectedDelegate>("UnityEngine.Rendering.LocalKeyword::GetKeywordType_Injected");
		IsValid_InjectedDelegateField = IL2CPP.ResolveICall<IsValid_InjectedDelegate>("UnityEngine.Rendering.LocalKeyword::IsValid_Injected");
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1240396, XrefRangeEnd = 1240401, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static uint GetShaderKeywordCount(Shader shader)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)shader);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetShaderKeywordCount_Private_Static_UInt32_Shader_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(uint*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1240419, RefRangeEnd = 1240420, XrefRangeStart = 1240401, XrefRangeEnd = 1240419, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static uint GetShaderKeywordIndex(Shader shader, string keyword)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)shader);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(keyword);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetShaderKeywordIndex_Private_Static_UInt32_Shader_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(uint*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1240420, XrefRangeEnd = 1240425, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static uint GetComputeShaderKeywordCount(ComputeShader shader)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)shader);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetComputeShaderKeywordCount_Private_Static_UInt32_ComputeShader_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(uint*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1240443, RefRangeEnd = 1240444, XrefRangeStart = 1240425, XrefRangeEnd = 1240443, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static uint GetComputeShaderKeywordIndex(ComputeShader shader, string keyword)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)shader);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(keyword);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetComputeShaderKeywordIndex_Private_Static_UInt32_ComputeShader_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(uint*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1240472, RefRangeEnd = 1240473, XrefRangeStart = 1240444, XrefRangeEnd = 1240472, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe LocalKeyword(Shader shader, string name)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LocalKeyword>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)shader);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(name);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Shader_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(15)]
	[CachedScanResults(RefRangeStart = 1240501, RefRangeEnd = 1240516, XrefRangeStart = 1240473, XrefRangeEnd = 1240501, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe LocalKeyword(ComputeShader shader, string name)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LocalKeyword>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)shader);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(name);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_ComputeShader_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(29)]
	[CachedScanResults(RefRangeStart = 765815, RefRangeEnd = 765844, XrefRangeStart = 765815, XrefRangeEnd = 765844, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override string ToString()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToString_Public_Virtual_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1240516, XrefRangeEnd = 1240519, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override bool Equals(Il2CppSystem.Object o)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)o);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe virtual bool Equals(LocalKeyword rhs)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)rhs));
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_LocalKeyword_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1240519, XrefRangeEnd = 1240521, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override int GetHashCode()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1240521, XrefRangeEnd = 1240523, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static uint GetShaderKeywordCount_Injected(System.IntPtr shader)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&shader);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetShaderKeywordCount_Injected_Private_Static_UInt32_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(uint*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1240523, XrefRangeEnd = 1240525, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static uint GetShaderKeywordIndex_Injected(System.IntPtr shader, ref ManagedSpanWrapper keyword)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&shader);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref keyword);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetShaderKeywordIndex_Injected_Private_Static_UInt32_IntPtr_byref_ManagedSpanWrapper_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(uint*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1240525, XrefRangeEnd = 1240527, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static uint GetComputeShaderKeywordCount_Injected(System.IntPtr shader)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&shader);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetComputeShaderKeywordCount_Injected_Private_Static_UInt32_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(uint*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1240527, XrefRangeEnd = 1240529, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static uint GetComputeShaderKeywordIndex_Injected(System.IntPtr shader, ref ManagedSpanWrapper keyword)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&shader);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref keyword);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetComputeShaderKeywordIndex_Injected_Private_Static_UInt32_IntPtr_byref_ManagedSpanWrapper_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(uint*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	public LocalKeyword(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public LocalKeyword()
		: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LocalKeyword>.NativeClassPtr))
	{
	}

	public static bool IsDynamic(LocalKeyword kw)
	{
		return IsDynamic_Injected(ref kw);
	}

	public static bool IsOverridable(LocalKeyword kw)
	{
		return IsOverridable_Injected(ref kw);
	}

	public static ShaderKeywordType GetKeywordType(LocalKeywordSpace spaceInfo, uint keyword)
	{
		return GetKeywordType_Injected(ref spaceInfo, keyword);
	}

	public static bool IsValid(LocalKeywordSpace spaceInfo, uint keyword)
	{
		return IsValid_Injected(ref spaceInfo, keyword);
	}

	public unsafe static bool operator ==(LocalKeyword lhs, LocalKeyword rhs)
	{
		//IL_0009: Expected O, but got Ref
		return ((LocalKeyword)(&lhs)).Equals(rhs);
	}

	public static bool operator !=(LocalKeyword lhs, LocalKeyword rhs)
	{
		return !(lhs == rhs);
	}

	public unsafe static bool IsDynamic_Injected([In] ref LocalKeyword kw)
	{
		IsDynamic_InjectedDelegate isDynamic_InjectedDelegateField = IsDynamic_InjectedDelegateField;
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)kw);
		return isDynamic_InjectedDelegateField((nint)(&intPtr));
	}

	public unsafe static bool IsOverridable_Injected([In] ref LocalKeyword kw)
	{
		IsOverridable_InjectedDelegate isOverridable_InjectedDelegateField = IsOverridable_InjectedDelegateField;
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)kw);
		return isOverridable_InjectedDelegateField((nint)(&intPtr));
	}

	public unsafe static ShaderKeywordType GetKeywordType_Injected([In] ref LocalKeywordSpace spaceInfo, uint keyword)
	{
		return GetKeywordType_InjectedDelegateField((nint)Unsafe.AsPointer(ref spaceInfo), keyword);
	}

	public unsafe static bool IsValid_Injected([In] ref LocalKeywordSpace spaceInfo, uint keyword)
	{
		return IsValid_InjectedDelegateField((nint)Unsafe.AsPointer(ref spaceInfo), keyword);
	}
}
