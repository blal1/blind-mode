using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine.Bindings;

namespace Unity.Profiling.LowLevel.Unsafe;

[StructLayout(LayoutKind.Explicit)]
public struct ProfilerRecorderHandle
{
	private delegate void GetAvailable_InjectedDelegate(System.IntPtr outRecorderHandleList);

	private delegate void GetByName_InjectedDelegate([In] System.IntPtr category, System.IntPtr name, [Out] System.IntPtr ret);

	private delegate void GetByName_Unsafe_InjectedDelegate([In] System.IntPtr category, System.IntPtr name, int nameLen, [Out] System.IntPtr ret);

	private static readonly System.IntPtr NativeFieldInfoPtr_handle;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Internal_Void_UInt64_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_Valid_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetDescription_Public_Static_ProfilerRecorderDescription_ProfilerRecorderHandle_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetByName__Unmanaged_Internal_Static_ProfilerRecorderHandle_ProfilerCategory_ptr_Byte_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetDescriptionInternal_Private_Static_ProfilerRecorderDescription_ProfilerRecorderHandle_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetByName__Unmanaged_Injected_Private_Static_Void_byref_ProfilerCategory_ptr_Byte_Int32_byref_ProfilerRecorderHandle_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetDescriptionInternal_Injected_Private_Static_Void_byref_ProfilerRecorderHandle_byref_ProfilerRecorderDescription_0;

	[FieldOffset(0)]
	public readonly ulong handle;

	public const ulong k_InvalidHandle = ulong.MaxValue;

	private static readonly GetAvailable_InjectedDelegate GetAvailable_InjectedDelegateField;

	private static readonly GetByName_InjectedDelegate GetByName_InjectedDelegateField;

	private static readonly GetByName_Unsafe_InjectedDelegate GetByName_Unsafe_InjectedDelegateField;

	public unsafe bool Valid
	{
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1164598, RefRangeEnd = 1164600, XrefRangeStart = 1164598, XrefRangeEnd = 1164598, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Valid_Public_get_Boolean_0, (System.IntPtr)(nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	static ProfilerRecorderHandle()
	{
		Il2CppClassPointerStore<ProfilerRecorderHandle>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "Unity.Profiling.LowLevel.Unsafe", "ProfilerRecorderHandle");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ProfilerRecorderHandle>.NativeClassPtr);
		NativeFieldInfoPtr_handle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfilerRecorderHandle>.NativeClassPtr, "handle");
		NativeMethodInfoPtr__ctor_Internal_Void_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfilerRecorderHandle>.NativeClassPtr, 100663444);
		NativeMethodInfoPtr_get_Valid_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfilerRecorderHandle>.NativeClassPtr, 100663445);
		NativeMethodInfoPtr_GetDescription_Public_Static_ProfilerRecorderDescription_ProfilerRecorderHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfilerRecorderHandle>.NativeClassPtr, 100663446);
		NativeMethodInfoPtr_GetByName__Unmanaged_Internal_Static_ProfilerRecorderHandle_ProfilerCategory_ptr_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfilerRecorderHandle>.NativeClassPtr, 100663447);
		NativeMethodInfoPtr_GetDescriptionInternal_Private_Static_ProfilerRecorderDescription_ProfilerRecorderHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfilerRecorderHandle>.NativeClassPtr, 100663448);
		NativeMethodInfoPtr_GetByName__Unmanaged_Injected_Private_Static_Void_byref_ProfilerCategory_ptr_Byte_Int32_byref_ProfilerRecorderHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfilerRecorderHandle>.NativeClassPtr, 100663449);
		NativeMethodInfoPtr_GetDescriptionInternal_Injected_Private_Static_Void_byref_ProfilerRecorderHandle_byref_ProfilerRecorderDescription_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfilerRecorderHandle>.NativeClassPtr, 100663450);
		GetAvailable_InjectedDelegateField = IL2CPP.ResolveICall<GetAvailable_InjectedDelegate>("Unity.Profiling.LowLevel.Unsafe.ProfilerRecorderHandle::GetAvailable_Injected");
		GetByName_InjectedDelegateField = IL2CPP.ResolveICall<GetByName_InjectedDelegate>("Unity.Profiling.LowLevel.Unsafe.ProfilerRecorderHandle::GetByName_Injected");
		GetByName_Unsafe_InjectedDelegateField = IL2CPP.ResolveICall<GetByName_Unsafe_InjectedDelegate>("Unity.Profiling.LowLevel.Unsafe.ProfilerRecorderHandle::GetByName_Unsafe_Injected");
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 687877, RefRangeEnd = 687880, XrefRangeStart = 687877, XrefRangeEnd = 687880, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ProfilerRecorderHandle(ulong handle)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&handle);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Internal_Void_UInt64_0, (System.IntPtr)(nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1164602, RefRangeEnd = 1164604, XrefRangeStart = 1164600, XrefRangeEnd = 1164602, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static ProfilerRecorderDescription GetDescription(ProfilerRecorderHandle handle)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&handle);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetDescription_Public_Static_ProfilerRecorderDescription_ProfilerRecorderHandle_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(ProfilerRecorderDescription*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1164604, XrefRangeEnd = 1164606, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static ProfilerRecorderHandle GetByName__Unmanaged(ProfilerCategory category, byte* name, int nameLen)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&category);
		*(byte**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = name;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &nameLen;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetByName__Unmanaged_Internal_Static_ProfilerRecorderHandle_ProfilerCategory_ptr_Byte_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(ProfilerRecorderHandle*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1164606, XrefRangeEnd = 1164608, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static ProfilerRecorderDescription GetDescriptionInternal(ProfilerRecorderHandle handle)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&handle);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetDescriptionInternal_Private_Static_ProfilerRecorderDescription_ProfilerRecorderHandle_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(ProfilerRecorderDescription*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1164608, XrefRangeEnd = 1164610, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void GetByName__Unmanaged_Injected([In] ref ProfilerCategory category, byte* name, int nameLen, out ProfilerRecorderHandle ret)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref category);
		*(byte**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = name;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &nameLen;
		*(void**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = System.Runtime.CompilerServices.Unsafe.AsPointer(ref ret);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetByName__Unmanaged_Injected_Private_Static_Void_byref_ProfilerCategory_ptr_Byte_Int32_byref_ProfilerRecorderHandle_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1164610, XrefRangeEnd = 1164612, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void GetDescriptionInternal_Injected([In] ref ProfilerRecorderHandle handle, out ProfilerRecorderDescription ret)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref handle);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = System.Runtime.CompilerServices.Unsafe.AsPointer(ref ret);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetDescriptionInternal_Injected_Private_Static_Void_byref_ProfilerRecorderHandle_byref_ProfilerRecorderDescription_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ProfilerRecorderHandle>.NativeClassPtr, (System.IntPtr)(nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref this)));
	}

	public static ProfilerRecorderHandle Get(ProfilerMarker marker)
	{
		return new ProfilerRecorderHandle((ulong)marker.Handle.ToInt64());
	}

	public static ProfilerRecorderHandle Get(ProfilerCategory category, string statName)
	{
		if (Il2CppSystem.String.IsNullOrEmpty(statName))
		{
			throw new Il2CppSystem.ArgumentException("String must be not null or empty", "statName");
		}
		return GetByName(category, statName);
	}

	public static void GetAvailable(List<ProfilerRecorderHandle> outRecorderHandleList)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	public unsafe static ProfilerRecorderHandle GetByName(ProfilerCategory category, string name)
	{
		//IL_001a: Expected O, but got Ref
		//IL_0026: Expected O, but got Ref
		//The blocks IL_002b are reachable both inside and outside the pinned region starting at IL_001a. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
		System.Runtime.CompilerServices.Unsafe.SkipInit(out ProfilerRecorderHandle ret);
		ProfilerRecorderHandle result;
		try
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out ManagedSpanWrapper managedSpanWrapper);
			if (!StringMarshaller.TryMarshalEmptyOrNullString(name, ref managedSpanWrapper))
			{
				Il2CppSystem.ReadOnlySpan<char> readOnlySpan = Il2CppSystem.MemoryExtensions.AsSpan(name);
				fixed (char* begin = &((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan)).GetPinnableReference())
				{
					managedSpanWrapper = new ManagedSpanWrapper(begin, ((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan)).Length);
					GetByName_Injected(ref category, ref managedSpanWrapper, out ret);
				}
			}
			else
			{
				GetByName_Injected(ref category, ref managedSpanWrapper, out ret);
			}
		}
		finally
		{
			result = ret;
		}
		return result;
	}

	public unsafe static ProfilerRecorderHandle GetByName(ProfilerCategory category, char* name, int nameLen)
	{
		return GetByName_Unsafe(category, name, nameLen);
	}

	public unsafe static ProfilerRecorderHandle GetByName_Unsafe(ProfilerCategory category, char* name, int nameLen)
	{
		GetByName_Unsafe_Injected(ref category, name, nameLen, out var ret);
		return ret;
	}

	public unsafe static void GetAvailable_Injected(ref BlittableListWrapper outRecorderHandleList)
	{
		GetAvailable_InjectedDelegateField((nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref outRecorderHandleList));
	}

	public unsafe static void GetByName_Injected([In] ref ProfilerCategory category, ref ManagedSpanWrapper name, out ProfilerRecorderHandle ret)
	{
		GetByName_InjectedDelegateField((nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref category), (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref name), (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref ret));
	}

	public unsafe static void GetByName_Unsafe_Injected([In] ref ProfilerCategory category, char* name, int nameLen, out ProfilerRecorderHandle ret)
	{
		GetByName_Unsafe_InjectedDelegateField((nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref category), (nint)name, nameLen, (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref ret));
	}
}
