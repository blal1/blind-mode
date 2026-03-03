using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;
using UnityEngine.Bindings;

namespace UnityEngine.Rendering;

public sealed class ShaderKeyword : Il2CppSystem.ValueType
{
	private delegate ShaderKeywordType GetGlobalShaderKeywordTypeDelegate(uint keyword);

	private delegate uint GetKeywordCount_InjectedDelegate(System.IntPtr shader);

	private delegate uint GetKeywordIndex_InjectedDelegate(System.IntPtr shader, System.IntPtr keyword);

	private delegate uint GetComputeShaderKeywordCount_InjectedDelegate(System.IntPtr shader);

	private delegate uint GetComputeShaderKeywordIndex_InjectedDelegate(System.IntPtr shader, System.IntPtr keyword);

	private static readonly System.IntPtr NativeFieldInfoPtr_m_Name;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_Index;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_IsLocal;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_IsCompute;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_IsValid;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetGlobalKeywordCount_Internal_Static_UInt32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetGlobalKeywordIndex_Internal_Static_UInt32_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateGlobalKeyword_Internal_Static_Void_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_name_Public_get_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetGlobalKeywordIndex_Injected_Private_Static_UInt32_byref_ManagedSpanWrapper_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateGlobalKeyword_Injected_Private_Static_Void_byref_ManagedSpanWrapper_0;

	private static readonly GetGlobalShaderKeywordTypeDelegate GetGlobalShaderKeywordTypeDelegateField;

	private static readonly GetKeywordCount_InjectedDelegate GetKeywordCount_InjectedDelegateField;

	private static readonly GetKeywordIndex_InjectedDelegate GetKeywordIndex_InjectedDelegateField;

	private static readonly GetComputeShaderKeywordCount_InjectedDelegate GetComputeShaderKeywordCount_InjectedDelegateField;

	private static readonly GetComputeShaderKeywordIndex_InjectedDelegate GetComputeShaderKeywordIndex_InjectedDelegateField;

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

	public unsafe bool m_IsLocal
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_IsLocal);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_IsLocal)) = value;
		}
	}

	public unsafe bool m_IsCompute
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_IsCompute);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_IsCompute)) = value;
		}
	}

	public unsafe bool m_IsValid
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_IsValid);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_IsValid)) = value;
		}
	}

	public unsafe string name
	{
		[CallerCount(255)]
		[CachedScanResults(RefRangeStart = 761723, RefRangeEnd = 761978, XrefRangeStart = 761723, XrefRangeEnd = 761978, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

	public int index => (int)m_Index;

	static ShaderKeyword()
	{
		Il2CppClassPointerStore<ShaderKeyword>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Rendering", "ShaderKeyword");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShaderKeyword>.NativeClassPtr);
		NativeFieldInfoPtr_m_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderKeyword>.NativeClassPtr, "m_Name");
		NativeFieldInfoPtr_m_Index = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderKeyword>.NativeClassPtr, "m_Index");
		NativeFieldInfoPtr_m_IsLocal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderKeyword>.NativeClassPtr, "m_IsLocal");
		NativeFieldInfoPtr_m_IsCompute = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderKeyword>.NativeClassPtr, "m_IsCompute");
		NativeFieldInfoPtr_m_IsValid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderKeyword>.NativeClassPtr, "m_IsValid");
		NativeMethodInfoPtr_GetGlobalKeywordCount_Internal_Static_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShaderKeyword>.NativeClassPtr, 100668872);
		NativeMethodInfoPtr_GetGlobalKeywordIndex_Internal_Static_UInt32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShaderKeyword>.NativeClassPtr, 100668873);
		NativeMethodInfoPtr_CreateGlobalKeyword_Internal_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShaderKeyword>.NativeClassPtr, 100668874);
		NativeMethodInfoPtr_get_name_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShaderKeyword>.NativeClassPtr, 100668875);
		NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShaderKeyword>.NativeClassPtr, 100668876);
		NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShaderKeyword>.NativeClassPtr, 100668877);
		NativeMethodInfoPtr_GetGlobalKeywordIndex_Injected_Private_Static_UInt32_byref_ManagedSpanWrapper_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShaderKeyword>.NativeClassPtr, 100668878);
		NativeMethodInfoPtr_CreateGlobalKeyword_Injected_Private_Static_Void_byref_ManagedSpanWrapper_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShaderKeyword>.NativeClassPtr, 100668879);
		GetGlobalShaderKeywordTypeDelegateField = IL2CPP.ResolveICall<GetGlobalShaderKeywordTypeDelegate>("UnityEngine.Rendering.ShaderKeyword::GetGlobalShaderKeywordType");
		GetKeywordCount_InjectedDelegateField = IL2CPP.ResolveICall<GetKeywordCount_InjectedDelegate>("UnityEngine.Rendering.ShaderKeyword::GetKeywordCount_Injected");
		GetKeywordIndex_InjectedDelegateField = IL2CPP.ResolveICall<GetKeywordIndex_InjectedDelegate>("UnityEngine.Rendering.ShaderKeyword::GetKeywordIndex_Injected");
		GetComputeShaderKeywordCount_InjectedDelegateField = IL2CPP.ResolveICall<GetComputeShaderKeywordCount_InjectedDelegate>("UnityEngine.Rendering.ShaderKeyword::GetComputeShaderKeywordCount_Injected");
		GetComputeShaderKeywordIndex_InjectedDelegateField = IL2CPP.ResolveICall<GetComputeShaderKeywordIndex_InjectedDelegate>("UnityEngine.Rendering.ShaderKeyword::GetComputeShaderKeywordIndex_Injected");
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1240540, XrefRangeEnd = 1240542, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static uint GetGlobalKeywordCount()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetGlobalKeywordCount_Internal_Static_UInt32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(uint*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1240556, RefRangeEnd = 1240558, XrefRangeStart = 1240542, XrefRangeEnd = 1240556, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static uint GetGlobalKeywordIndex(string keyword)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(keyword);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetGlobalKeywordIndex_Internal_Static_UInt32_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(uint*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1240572, RefRangeEnd = 1240573, XrefRangeStart = 1240558, XrefRangeEnd = 1240572, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void CreateGlobalKeyword(string keyword)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(keyword);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateGlobalKeyword_Internal_Static_Void_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1240573, XrefRangeEnd = 1240579, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ShaderKeyword(string keywordName)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShaderKeyword>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(keywordName);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(255)]
	[CachedScanResults(RefRangeStart = 761723, RefRangeEnd = 761978, XrefRangeStart = 761723, XrefRangeEnd = 761978, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1240579, XrefRangeEnd = 1240581, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static uint GetGlobalKeywordIndex_Injected(ref ManagedSpanWrapper keyword)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)Unsafe.AsPointer(ref keyword);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetGlobalKeywordIndex_Injected_Private_Static_UInt32_byref_ManagedSpanWrapper_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(uint*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1240581, XrefRangeEnd = 1240583, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void CreateGlobalKeyword_Injected(ref ManagedSpanWrapper keyword)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)Unsafe.AsPointer(ref keyword);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateGlobalKeyword_Injected_Private_Static_Void_byref_ManagedSpanWrapper_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public ShaderKeyword(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public ShaderKeyword()
		: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShaderKeyword>.NativeClassPtr))
	{
	}

	public static uint GetKeywordCount(Shader shader)
	{
		return GetKeywordCount_Injected(Object.MarshalledUnityObject.Marshal(shader));
	}

	public unsafe static uint GetKeywordIndex(Shader shader, string keyword)
	{
		//IL_001e: Expected O, but got Ref
		//IL_002a: Expected O, but got Ref
		//The blocks IL_002f are reachable both inside and outside the pinned region starting at IL_001e. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
		try
		{
			System.IntPtr shader2 = Object.MarshalledUnityObject.Marshal(shader);
			Unsafe.SkipInit(out ManagedSpanWrapper managedSpanWrapper);
			if (!StringMarshaller.TryMarshalEmptyOrNullString(keyword, ref managedSpanWrapper))
			{
				Il2CppSystem.ReadOnlySpan<char> readOnlySpan = Il2CppSystem.MemoryExtensions.AsSpan(keyword);
				fixed (char* begin = &((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan)).GetPinnableReference())
				{
					managedSpanWrapper = new ManagedSpanWrapper(begin, ((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan)).Length);
					return GetKeywordIndex_Injected(shader2, ref managedSpanWrapper);
				}
			}
			return GetKeywordIndex_Injected(shader2, ref managedSpanWrapper);
		}
		finally
		{
		}
	}

	public static uint GetComputeShaderKeywordCount(ComputeShader shader)
	{
		return GetComputeShaderKeywordCount_Injected(Object.MarshalledUnityObject.Marshal(shader));
	}

	public unsafe static uint GetComputeShaderKeywordIndex(ComputeShader shader, string keyword)
	{
		//IL_001e: Expected O, but got Ref
		//IL_002a: Expected O, but got Ref
		//The blocks IL_002f are reachable both inside and outside the pinned region starting at IL_001e. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
		try
		{
			System.IntPtr shader2 = Object.MarshalledUnityObject.Marshal(shader);
			Unsafe.SkipInit(out ManagedSpanWrapper managedSpanWrapper);
			if (!StringMarshaller.TryMarshalEmptyOrNullString(keyword, ref managedSpanWrapper))
			{
				Il2CppSystem.ReadOnlySpan<char> readOnlySpan = Il2CppSystem.MemoryExtensions.AsSpan(keyword);
				fixed (char* begin = &((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan)).GetPinnableReference())
				{
					managedSpanWrapper = new ManagedSpanWrapper(begin, ((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan)).Length);
					return GetComputeShaderKeywordIndex_Injected(shader2, ref managedSpanWrapper);
				}
			}
			return GetComputeShaderKeywordIndex_Injected(shader2, ref managedSpanWrapper);
		}
		finally
		{
		}
	}

	public static ShaderKeywordType GetGlobalShaderKeywordType(uint keyword)
	{
		return GetGlobalShaderKeywordTypeDelegateField(keyword);
	}

	public unsafe static ShaderKeywordType GetGlobalKeywordType(ShaderKeyword index)
	{
		//IL_0008: Expected O, but got Ref
		if (((ShaderKeyword)(&index)).IsValid())
		{
			return GetGlobalShaderKeywordType(index.m_Index);
		}
		return ShaderKeywordType.UserDefined;
	}

	public static bool IsKeywordLocal(ShaderKeyword keyword)
	{
		return keyword.m_IsLocal;
	}

	public bool IsValid()
	{
		return m_IsValid;
	}

	public bool IsValid(ComputeShader shader)
	{
		return m_IsValid;
	}

	public bool IsValid(Shader shader)
	{
		return m_IsValid;
	}

	public static ShaderKeywordType GetKeywordType(Shader shader, ShaderKeyword index)
	{
		return ShaderKeywordType.UserDefined;
	}

	public static ShaderKeywordType GetKeywordType(ComputeShader shader, ShaderKeyword index)
	{
		return ShaderKeywordType.UserDefined;
	}

	public static string GetGlobalKeywordName(ShaderKeyword index)
	{
		return index.m_Name;
	}

	public static string GetKeywordName(Shader shader, ShaderKeyword index)
	{
		return index.m_Name;
	}

	public static string GetKeywordName(ComputeShader shader, ShaderKeyword index)
	{
		return index.m_Name;
	}

	public unsafe ShaderKeywordType GetKeywordType()
	{
		//IL_0002: Expected native int or pointer, but got O
		return GetGlobalKeywordType(Unsafe.Read<ShaderKeyword>((void*)(nint)this));
	}

	public unsafe string GetKeywordName()
	{
		//IL_0002: Expected native int or pointer, but got O
		return GetGlobalKeywordName(Unsafe.Read<ShaderKeyword>((void*)(nint)this));
	}

	public string GetName()
	{
		return GetKeywordName();
	}

	public static uint GetKeywordCount_Injected(System.IntPtr shader)
	{
		return GetKeywordCount_InjectedDelegateField(shader);
	}

	public unsafe static uint GetKeywordIndex_Injected(System.IntPtr shader, ref ManagedSpanWrapper keyword)
	{
		return GetKeywordIndex_InjectedDelegateField(shader, (nint)Unsafe.AsPointer(ref keyword));
	}

	public static uint GetComputeShaderKeywordCount_Injected(System.IntPtr shader)
	{
		return GetComputeShaderKeywordCount_InjectedDelegateField(shader);
	}

	public unsafe static uint GetComputeShaderKeywordIndex_Injected(System.IntPtr shader, ref ManagedSpanWrapper keyword)
	{
		return GetComputeShaderKeywordIndex_InjectedDelegateField(shader, (nint)Unsafe.AsPointer(ref keyword));
	}
}
