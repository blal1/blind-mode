using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using Unity.Profiling.LowLevel.Unsafe;
using UnityEngine;

namespace Unity.Profiling;

[StructLayout(LayoutKind.Explicit)]
public struct ProfilerMarker
{
	[StructLayout(LayoutKind.Explicit)]
	public struct AutoScope
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_m_Ptr;

		private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

		[FieldOffset(0)]
		public readonly System.IntPtr m_Ptr;

		static AutoScope()
		{
			Il2CppClassPointerStore<AutoScope>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ProfilerMarker>.NativeClassPtr, "AutoScope");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AutoScope>.NativeClassPtr);
			NativeFieldInfoPtr_m_Ptr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AutoScope>.NativeClassPtr, "m_Ptr");
			NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AutoScope>.NativeClassPtr, 100663413);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1164519, XrefRangeEnd = 1164521, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Dispose()
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		public unsafe Il2CppSystem.Object BoxIl2CppObject()
		{
			return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AutoScope>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
		}
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_m_Ptr;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_ProfilerCategory_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Auto_Public_AutoScope_0;

	[FieldOffset(0)]
	[System.NonSerialized]
	public readonly System.IntPtr m_Ptr;

	public System.IntPtr Handle => m_Ptr;

	static ProfilerMarker()
	{
		Il2CppClassPointerStore<ProfilerMarker>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "Unity.Profiling", "ProfilerMarker");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ProfilerMarker>.NativeClassPtr);
		NativeFieldInfoPtr_m_Ptr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfilerMarker>.NativeClassPtr, "m_Ptr");
		NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfilerMarker>.NativeClassPtr, 100663409);
		NativeMethodInfoPtr__ctor_Public_Void_ProfilerCategory_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfilerMarker>.NativeClassPtr, 100663410);
		NativeMethodInfoPtr_Auto_Public_AutoScope_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfilerMarker>.NativeClassPtr, 100663411);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1164521, XrefRangeEnd = 1164522, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ProfilerMarker(string name)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_String_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1164522, XrefRangeEnd = 1164523, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ProfilerMarker(ProfilerCategory category, string name)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&category);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(name);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_ProfilerCategory_String_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1164523, XrefRangeEnd = 1164525, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe AutoScope Auto()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Auto_Public_AutoScope_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(AutoScope*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ProfilerMarker>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}

	public void Begin()
	{
		ProfilerUnsafeUtility.BeginSample(m_Ptr);
	}

	public void Begin(UnityEngine.Object contextUnityObject)
	{
		ProfilerUnsafeUtility.Internal_BeginWithObject(m_Ptr, contextUnityObject);
	}

	public void End()
	{
		ProfilerUnsafeUtility.EndSample(m_Ptr);
	}

	public void GetName(ref string name)
	{
		name = ProfilerUnsafeUtility.Internal_GetName(m_Ptr);
	}
}
