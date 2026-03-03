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
public struct LocalKeywordSpace
{
	private delegate System.IntPtr GetKeywordNamesDelegate(System.IntPtr @this);

	private delegate uint GetKeywordCountDelegate(System.IntPtr @this);

	private delegate void GetKeyword_InjectedDelegate(System.IntPtr _unity_self, System.IntPtr name, [Out] System.IntPtr ret);

	private static readonly System.IntPtr NativeFieldInfoPtr_m_KeywordSpace;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetKeywords_Private_Il2CppReferenceArray_1_LocalKeyword_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_keywords_Public_get_Il2CppReferenceArray_1_LocalKeyword_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_LocalKeywordSpace_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_LocalKeywordSpace_LocalKeywordSpace_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

	[FieldOffset(0)]
	public readonly System.IntPtr m_KeywordSpace;

	private static readonly GetKeywordNamesDelegate GetKeywordNamesDelegateField;

	private static readonly GetKeywordCountDelegate GetKeywordCountDelegateField;

	private static readonly GetKeyword_InjectedDelegate GetKeyword_InjectedDelegateField;

	public unsafe Il2CppReferenceArray<LocalKeyword> keywords
	{
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1240531, RefRangeEnd = 1240533, XrefRangeStart = 1240531, XrefRangeEnd = 1240533, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_keywords_Public_get_Il2CppReferenceArray_1_LocalKeyword_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<LocalKeyword>>(intPtr2) : null;
		}
	}

	public Il2CppStringArray keywordNames => GetKeywordNames();

	public uint keywordCount => GetKeywordCount();

	static LocalKeywordSpace()
	{
		Il2CppClassPointerStore<LocalKeywordSpace>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Rendering", "LocalKeywordSpace");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LocalKeywordSpace>.NativeClassPtr);
		NativeFieldInfoPtr_m_KeywordSpace = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalKeywordSpace>.NativeClassPtr, "m_KeywordSpace");
		NativeMethodInfoPtr_GetKeywords_Private_Il2CppReferenceArray_1_LocalKeyword_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalKeywordSpace>.NativeClassPtr, 100668865);
		NativeMethodInfoPtr_get_keywords_Public_get_Il2CppReferenceArray_1_LocalKeyword_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalKeywordSpace>.NativeClassPtr, 100668866);
		NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalKeywordSpace>.NativeClassPtr, 100668867);
		NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_LocalKeywordSpace_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalKeywordSpace>.NativeClassPtr, 100668868);
		NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_LocalKeywordSpace_LocalKeywordSpace_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalKeywordSpace>.NativeClassPtr, 100668869);
		NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalKeywordSpace>.NativeClassPtr, 100668870);
		GetKeywordNamesDelegateField = IL2CPP.ResolveICall<GetKeywordNamesDelegate>("UnityEngine.Rendering.LocalKeywordSpace::GetKeywordNames");
		GetKeywordCountDelegateField = IL2CPP.ResolveICall<GetKeywordCountDelegate>("UnityEngine.Rendering.LocalKeywordSpace::GetKeywordCount");
		GetKeyword_InjectedDelegateField = IL2CPP.ResolveICall<GetKeyword_InjectedDelegate>("UnityEngine.Rendering.LocalKeywordSpace::GetKeyword_Injected");
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1240531, RefRangeEnd = 1240533, XrefRangeStart = 1240529, XrefRangeEnd = 1240531, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Il2CppReferenceArray<LocalKeyword> GetKeywords()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetKeywords_Private_Il2CppReferenceArray_1_LocalKeyword_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<LocalKeyword>>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1240533, XrefRangeEnd = 1240536, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool Equals(Il2CppSystem.Object o)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)o);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 1164438, RefRangeEnd = 1164444, XrefRangeStart = 1164438, XrefRangeEnd = 1164444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual bool Equals(LocalKeywordSpace rhs)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&rhs);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_LocalKeywordSpace_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe static bool operator ==(LocalKeywordSpace lhs, LocalKeywordSpace rhs)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&lhs);
		*(LocalKeywordSpace**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &rhs;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_LocalKeywordSpace_LocalKeywordSpace_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override int GetHashCode()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<LocalKeywordSpace>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}

	public unsafe Il2CppStringArray GetKeywordNames()
	{
		//IL_000b: Expected O, but got Ref
		System.IntPtr intPtr = GetKeywordNamesDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)Unsafe.AsPointer(ref this)));
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr) : null;
	}

	public unsafe uint GetKeywordCount()
	{
		//IL_000b: Expected O, but got Ref
		return GetKeywordCountDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)Unsafe.AsPointer(ref this)));
	}

	public unsafe LocalKeyword GetKeyword(string name)
	{
		//IL_0019: Expected O, but got Ref
		//IL_0025: Expected O, but got Ref
		//The blocks IL_002a are reachable both inside and outside the pinned region starting at IL_0019. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
		Unsafe.SkipInit(out LocalKeyword ret);
		LocalKeyword result;
		try
		{
			Unsafe.SkipInit(out ManagedSpanWrapper managedSpanWrapper);
			if (!StringMarshaller.TryMarshalEmptyOrNullString(name, ref managedSpanWrapper))
			{
				Il2CppSystem.ReadOnlySpan<char> readOnlySpan = Il2CppSystem.MemoryExtensions.AsSpan(name);
				fixed (char* begin = &((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan)).GetPinnableReference())
				{
					managedSpanWrapper = new ManagedSpanWrapper(begin, ((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan)).Length);
					GetKeyword_Injected(ref this, ref managedSpanWrapper, out ret);
				}
			}
			else
			{
				GetKeyword_Injected(ref this, ref managedSpanWrapper, out ret);
			}
		}
		finally
		{
			result = ret;
		}
		return result;
	}

	public LocalKeyword FindKeyword(string name)
	{
		return GetKeyword(name);
	}

	public static bool operator !=(LocalKeywordSpace lhs, LocalKeywordSpace rhs)
	{
		return !(lhs == rhs);
	}

	public unsafe static void GetKeyword_Injected(ref LocalKeywordSpace _unity_self, ref ManagedSpanWrapper name, out LocalKeyword ret)
	{
		GetKeyword_InjectedDelegate getKeyword_InjectedDelegateField = GetKeyword_InjectedDelegateField;
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)ret);
		getKeyword_InjectedDelegateField((nint)Unsafe.AsPointer(ref _unity_self), (nint)Unsafe.AsPointer(ref name), (nint)(&intPtr));
	}
}
