using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine.Bindings;

namespace UnityEngine.Rendering;

[StructLayout(LayoutKind.Explicit)]
public struct ShaderKeywordSet
{
	private delegate bool IsGlobalKeywordEnabled_InjectedDelegate([In] System.IntPtr state, uint index);

	private delegate bool IsKeywordEnabled_InjectedDelegate([In] System.IntPtr state, [In] System.IntPtr keywordSpace, uint index);

	private delegate void EnableGlobalKeyword_InjectedDelegate([In] System.IntPtr state, uint index);

	private delegate void EnableKeywordName_InjectedDelegate([In] System.IntPtr state, System.IntPtr name);

	private delegate void DisableGlobalKeyword_InjectedDelegate([In] System.IntPtr state, uint index);

	private delegate void DisableKeywordName_InjectedDelegate([In] System.IntPtr state, System.IntPtr name);

	private delegate System.IntPtr GetEnabledKeywords_InjectedDelegate([In] System.IntPtr state);

	private static readonly System.IntPtr NativeFieldInfoPtr_m_KeywordState;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_Shader;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_ComputeShader;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_StateIndex;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsKeywordNameEnabled_Private_Static_Boolean_ShaderKeywordSet_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CheckKeywordCompatible_Private_Void_ShaderKeyword_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsEnabled_Public_Boolean_ShaderKeyword_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsKeywordNameEnabled_Injected_Private_Static_Boolean_byref_ShaderKeywordSet_byref_ManagedSpanWrapper_0;

	[FieldOffset(0)]
	public System.IntPtr m_KeywordState;

	[FieldOffset(8)]
	public System.IntPtr m_Shader;

	[FieldOffset(16)]
	public System.IntPtr m_ComputeShader;

	[FieldOffset(24)]
	public ulong m_StateIndex;

	private static readonly IsGlobalKeywordEnabled_InjectedDelegate IsGlobalKeywordEnabled_InjectedDelegateField;

	private static readonly IsKeywordEnabled_InjectedDelegate IsKeywordEnabled_InjectedDelegateField;

	private static readonly EnableGlobalKeyword_InjectedDelegate EnableGlobalKeyword_InjectedDelegateField;

	private static readonly EnableKeywordName_InjectedDelegate EnableKeywordName_InjectedDelegateField;

	private static readonly DisableGlobalKeyword_InjectedDelegate DisableGlobalKeyword_InjectedDelegateField;

	private static readonly DisableKeywordName_InjectedDelegate DisableKeywordName_InjectedDelegateField;

	private static readonly GetEnabledKeywords_InjectedDelegate GetEnabledKeywords_InjectedDelegateField;

	static ShaderKeywordSet()
	{
		Il2CppClassPointerStore<ShaderKeywordSet>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Rendering", "ShaderKeywordSet");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShaderKeywordSet>.NativeClassPtr);
		NativeFieldInfoPtr_m_KeywordState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderKeywordSet>.NativeClassPtr, "m_KeywordState");
		NativeFieldInfoPtr_m_Shader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderKeywordSet>.NativeClassPtr, "m_Shader");
		NativeFieldInfoPtr_m_ComputeShader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderKeywordSet>.NativeClassPtr, "m_ComputeShader");
		NativeFieldInfoPtr_m_StateIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderKeywordSet>.NativeClassPtr, "m_StateIndex");
		NativeMethodInfoPtr_IsKeywordNameEnabled_Private_Static_Boolean_ShaderKeywordSet_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShaderKeywordSet>.NativeClassPtr, 100668880);
		NativeMethodInfoPtr_CheckKeywordCompatible_Private_Void_ShaderKeyword_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShaderKeywordSet>.NativeClassPtr, 100668881);
		NativeMethodInfoPtr_IsEnabled_Public_Boolean_ShaderKeyword_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShaderKeywordSet>.NativeClassPtr, 100668882);
		NativeMethodInfoPtr_IsKeywordNameEnabled_Injected_Private_Static_Boolean_byref_ShaderKeywordSet_byref_ManagedSpanWrapper_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShaderKeywordSet>.NativeClassPtr, 100668883);
		IsGlobalKeywordEnabled_InjectedDelegateField = IL2CPP.ResolveICall<IsGlobalKeywordEnabled_InjectedDelegate>("UnityEngine.Rendering.ShaderKeywordSet::IsGlobalKeywordEnabled_Injected");
		IsKeywordEnabled_InjectedDelegateField = IL2CPP.ResolveICall<IsKeywordEnabled_InjectedDelegate>("UnityEngine.Rendering.ShaderKeywordSet::IsKeywordEnabled_Injected");
		EnableGlobalKeyword_InjectedDelegateField = IL2CPP.ResolveICall<EnableGlobalKeyword_InjectedDelegate>("UnityEngine.Rendering.ShaderKeywordSet::EnableGlobalKeyword_Injected");
		EnableKeywordName_InjectedDelegateField = IL2CPP.ResolveICall<EnableKeywordName_InjectedDelegate>("UnityEngine.Rendering.ShaderKeywordSet::EnableKeywordName_Injected");
		DisableGlobalKeyword_InjectedDelegateField = IL2CPP.ResolveICall<DisableGlobalKeyword_InjectedDelegate>("UnityEngine.Rendering.ShaderKeywordSet::DisableGlobalKeyword_Injected");
		DisableKeywordName_InjectedDelegateField = IL2CPP.ResolveICall<DisableKeywordName_InjectedDelegate>("UnityEngine.Rendering.ShaderKeywordSet::DisableKeywordName_Injected");
		GetEnabledKeywords_InjectedDelegateField = IL2CPP.ResolveICall<GetEnabledKeywords_InjectedDelegate>("UnityEngine.Rendering.ShaderKeywordSet::GetEnabledKeywords_Injected");
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1240597, RefRangeEnd = 1240598, XrefRangeStart = 1240583, XrefRangeEnd = 1240597, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool IsKeywordNameEnabled(ShaderKeywordSet state, string name)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&state);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(name);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsKeywordNameEnabled_Private_Static_Boolean_ShaderKeywordSet_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1240598, XrefRangeEnd = 1240606, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CheckKeywordCompatible(ShaderKeyword keyword)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)keyword));
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CheckKeywordCompatible_Private_Void_ShaderKeyword_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 1240615, RefRangeEnd = 1240619, XrefRangeStart = 1240606, XrefRangeEnd = 1240615, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool IsEnabled(ShaderKeyword keyword)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)keyword));
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsEnabled_Public_Boolean_ShaderKeyword_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1240619, XrefRangeEnd = 1240621, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool IsKeywordNameEnabled_Injected([In] ref ShaderKeywordSet state, ref ManagedSpanWrapper name)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)Unsafe.AsPointer(ref state);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref name);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsKeywordNameEnabled_Injected_Private_Static_Boolean_byref_ShaderKeywordSet_byref_ManagedSpanWrapper_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ShaderKeywordSet>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}

	public static bool IsGlobalKeywordEnabled(ShaderKeywordSet state, uint index)
	{
		return IsGlobalKeywordEnabled_Injected(ref state, index);
	}

	public static bool IsKeywordEnabled(ShaderKeywordSet state, LocalKeywordSpace keywordSpace, uint index)
	{
		return IsKeywordEnabled_Injected(ref state, ref keywordSpace, index);
	}

	public static void EnableGlobalKeyword(ShaderKeywordSet state, uint index)
	{
		EnableGlobalKeyword_Injected(ref state, index);
	}

	public unsafe static void EnableKeywordName(ShaderKeywordSet state, string name)
	{
		//IL_001a: Expected O, but got Ref
		//IL_0026: Expected O, but got Ref
		//The blocks IL_002b are reachable both inside and outside the pinned region starting at IL_001a. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
		try
		{
			Unsafe.SkipInit(out ManagedSpanWrapper managedSpanWrapper);
			if (!StringMarshaller.TryMarshalEmptyOrNullString(name, ref managedSpanWrapper))
			{
				Il2CppSystem.ReadOnlySpan<char> readOnlySpan = Il2CppSystem.MemoryExtensions.AsSpan(name);
				fixed (char* begin = &((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan)).GetPinnableReference())
				{
					managedSpanWrapper = new ManagedSpanWrapper(begin, ((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan)).Length);
					EnableKeywordName_Injected(ref state, ref managedSpanWrapper);
					return;
				}
			}
			EnableKeywordName_Injected(ref state, ref managedSpanWrapper);
		}
		finally
		{
		}
	}

	public static void DisableGlobalKeyword(ShaderKeywordSet state, uint index)
	{
		DisableGlobalKeyword_Injected(ref state, index);
	}

	public unsafe static void DisableKeywordName(ShaderKeywordSet state, string name)
	{
		//IL_001a: Expected O, but got Ref
		//IL_0026: Expected O, but got Ref
		//The blocks IL_002b are reachable both inside and outside the pinned region starting at IL_001a. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
		try
		{
			Unsafe.SkipInit(out ManagedSpanWrapper managedSpanWrapper);
			if (!StringMarshaller.TryMarshalEmptyOrNullString(name, ref managedSpanWrapper))
			{
				Il2CppSystem.ReadOnlySpan<char> readOnlySpan = Il2CppSystem.MemoryExtensions.AsSpan(name);
				fixed (char* begin = &((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan)).GetPinnableReference())
				{
					managedSpanWrapper = new ManagedSpanWrapper(begin, ((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan)).Length);
					DisableKeywordName_Injected(ref state, ref managedSpanWrapper);
					return;
				}
			}
			DisableKeywordName_Injected(ref state, ref managedSpanWrapper);
		}
		finally
		{
		}
	}

	public static Il2CppReferenceArray<ShaderKeyword> GetEnabledKeywords(ShaderKeywordSet state)
	{
		return GetEnabledKeywords_Injected(ref state);
	}

	public bool IsEnabled(GlobalKeyword keyword)
	{
		return IsGlobalKeywordEnabled(this, keyword.m_Index);
	}

	public bool IsEnabled(LocalKeyword keyword)
	{
		return IsKeywordEnabled(this, keyword.m_SpaceInfo, keyword.m_Index);
	}

	public unsafe void Enable(ShaderKeyword keyword)
	{
		//IL_0018: Expected O, but got Ref
		CheckKeywordCompatible(keyword);
		if (keyword.m_IsLocal || !((ShaderKeyword)(&keyword)).IsValid())
		{
			EnableKeywordName(this, keyword.m_Name);
		}
		else
		{
			EnableGlobalKeyword(this, keyword.m_Index);
		}
	}

	public unsafe void Disable(ShaderKeyword keyword)
	{
		//IL_0010: Expected O, but got Ref
		if (keyword.m_IsLocal || !((ShaderKeyword)(&keyword)).IsValid())
		{
			DisableKeywordName(this, keyword.m_Name);
		}
		else
		{
			DisableGlobalKeyword(this, keyword.m_Index);
		}
	}

	public Il2CppReferenceArray<ShaderKeyword> GetShaderKeywords()
	{
		return GetEnabledKeywords(this);
	}

	public unsafe static bool IsGlobalKeywordEnabled_Injected([In] ref ShaderKeywordSet state, uint index)
	{
		return IsGlobalKeywordEnabled_InjectedDelegateField((nint)Unsafe.AsPointer(ref state), index);
	}

	public unsafe static bool IsKeywordEnabled_Injected([In] ref ShaderKeywordSet state, [In] ref LocalKeywordSpace keywordSpace, uint index)
	{
		return IsKeywordEnabled_InjectedDelegateField((nint)Unsafe.AsPointer(ref state), (nint)Unsafe.AsPointer(ref keywordSpace), index);
	}

	public unsafe static void EnableGlobalKeyword_Injected([In] ref ShaderKeywordSet state, uint index)
	{
		EnableGlobalKeyword_InjectedDelegateField((nint)Unsafe.AsPointer(ref state), index);
	}

	public unsafe static void EnableKeywordName_Injected([In] ref ShaderKeywordSet state, ref ManagedSpanWrapper name)
	{
		EnableKeywordName_InjectedDelegateField((nint)Unsafe.AsPointer(ref state), (nint)Unsafe.AsPointer(ref name));
	}

	public unsafe static void DisableGlobalKeyword_Injected([In] ref ShaderKeywordSet state, uint index)
	{
		DisableGlobalKeyword_InjectedDelegateField((nint)Unsafe.AsPointer(ref state), index);
	}

	public unsafe static void DisableKeywordName_Injected([In] ref ShaderKeywordSet state, ref ManagedSpanWrapper name)
	{
		DisableKeywordName_InjectedDelegateField((nint)Unsafe.AsPointer(ref state), (nint)Unsafe.AsPointer(ref name));
	}

	public unsafe static Il2CppReferenceArray<ShaderKeyword> GetEnabledKeywords_Injected([In] ref ShaderKeywordSet state)
	{
		System.IntPtr intPtr = GetEnabledKeywords_InjectedDelegateField((nint)Unsafe.AsPointer(ref state));
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<ShaderKeyword>>(intPtr) : null;
	}
}
