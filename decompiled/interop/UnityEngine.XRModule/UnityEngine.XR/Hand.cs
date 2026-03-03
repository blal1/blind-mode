using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine.Bindings;

namespace UnityEngine.XR;

[StructLayout(LayoutKind.Explicit)]
public struct Hand
{
	private delegate bool Hand_TryGetRootBone_InjectedDelegate([In] System.IntPtr hand, [Out] System.IntPtr boneOut);

	private delegate bool Hand_TryGetFingerBonesAsList_InjectedDelegate([In] System.IntPtr hand, HandFinger finger, System.IntPtr bonesOut);

	private static readonly System.IntPtr NativeFieldInfoPtr_m_DeviceId;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_FeatureIndex;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_deviceId_Internal_get_UInt64_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_featureIndex_Internal_get_UInt32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Hand_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

	[FieldOffset(0)]
	public ulong m_DeviceId;

	[FieldOffset(8)]
	public uint m_FeatureIndex;

	private static readonly Hand_TryGetRootBone_InjectedDelegate Hand_TryGetRootBone_InjectedDelegateField;

	private static readonly Hand_TryGetFingerBonesAsList_InjectedDelegate Hand_TryGetFingerBonesAsList_InjectedDelegateField;

	public unsafe ulong deviceId
	{
		[CallerCount(255)]
		[CachedScanResults(RefRangeStart = 761723, RefRangeEnd = 761978, XrefRangeStart = 761723, XrefRangeEnd = 761978, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_deviceId_Internal_get_UInt64_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(ulong*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe uint featureIndex
	{
		[CallerCount(46)]
		[CachedScanResults(RefRangeStart = 1153890, RefRangeEnd = 1153936, XrefRangeStart = 1153890, XrefRangeEnd = 1153936, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_featureIndex_Internal_get_UInt32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(uint*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	static Hand()
	{
		Il2CppClassPointerStore<Hand>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.XRModule.dll", "UnityEngine.XR", "Hand");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Hand>.NativeClassPtr);
		NativeFieldInfoPtr_m_DeviceId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Hand>.NativeClassPtr, "m_DeviceId");
		NativeFieldInfoPtr_m_FeatureIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Hand>.NativeClassPtr, "m_FeatureIndex");
		NativeMethodInfoPtr_get_deviceId_Internal_get_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hand>.NativeClassPtr, 100663311);
		NativeMethodInfoPtr_get_featureIndex_Internal_get_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hand>.NativeClassPtr, 100663312);
		NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hand>.NativeClassPtr, 100663313);
		NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Hand_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hand>.NativeClassPtr, 100663314);
		NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hand>.NativeClassPtr, 100663315);
		Hand_TryGetRootBone_InjectedDelegateField = IL2CPP.ResolveICall<Hand_TryGetRootBone_InjectedDelegate>("UnityEngine.XR.Hand::Hand_TryGetRootBone_Injected");
		Hand_TryGetFingerBonesAsList_InjectedDelegateField = IL2CPP.ResolveICall<Hand_TryGetFingerBonesAsList_InjectedDelegate>("UnityEngine.XR.Hand::Hand_TryGetFingerBonesAsList_Injected");
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1411030, XrefRangeEnd = 1411033, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool Equals(Il2CppSystem.Object obj)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)obj);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe virtual bool Equals(Hand other)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&other);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Hand_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1411033, XrefRangeEnd = 1411035, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Hand>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}

	public bool TryGetRootBone(out Bone boneOut)
	{
		return Hand_TryGetRootBone(this, out boneOut);
	}

	public static bool Hand_TryGetRootBone(Hand hand, out Bone boneOut)
	{
		return Hand_TryGetRootBone_Injected(ref hand, out boneOut);
	}

	public bool TryGetFingerBones(HandFinger finger, List<Bone> bonesOut)
	{
		if (bonesOut == null)
		{
			throw new Il2CppSystem.ArgumentNullException("bonesOut");
		}
		return Hand_TryGetFingerBonesAsList(this, finger, bonesOut);
	}

	public static bool Hand_TryGetFingerBonesAsList(Hand hand, HandFinger finger, List<Bone> bonesOut)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	public static bool operator ==(Hand a, Hand b)
	{
		return a.Equals(b);
	}

	public static bool operator !=(Hand a, Hand b)
	{
		return !(a == b);
	}

	public unsafe static bool Hand_TryGetRootBone_Injected([In] ref Hand hand, out Bone boneOut)
	{
		return Hand_TryGetRootBone_InjectedDelegateField((nint)Unsafe.AsPointer(ref hand), (nint)Unsafe.AsPointer(ref boneOut));
	}

	public unsafe static bool Hand_TryGetFingerBonesAsList_Injected([In] ref Hand hand, HandFinger finger, ref BlittableListWrapper bonesOut)
	{
		return Hand_TryGetFingerBonesAsList_InjectedDelegateField((nint)Unsafe.AsPointer(ref hand), finger, (nint)Unsafe.AsPointer(ref bonesOut));
	}
}
