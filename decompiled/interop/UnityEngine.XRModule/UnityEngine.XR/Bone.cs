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
public struct Bone
{
	private delegate bool Bone_TryGetPosition_InjectedDelegate([In] System.IntPtr bone, [Out] System.IntPtr position);

	private delegate bool Bone_TryGetRotation_InjectedDelegate([In] System.IntPtr bone, [Out] System.IntPtr rotation);

	private delegate bool Bone_TryGetParentBone_InjectedDelegate([In] System.IntPtr bone, [Out] System.IntPtr parentBone);

	private delegate bool Bone_TryGetChildBones_InjectedDelegate([In] System.IntPtr bone, System.IntPtr childBones);

	private static readonly System.IntPtr NativeFieldInfoPtr_m_DeviceId;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_FeatureIndex;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_deviceId_Internal_get_UInt64_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_featureIndex_Internal_get_UInt32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Bone_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

	[FieldOffset(0)]
	public ulong m_DeviceId;

	[FieldOffset(8)]
	public uint m_FeatureIndex;

	private static readonly Bone_TryGetPosition_InjectedDelegate Bone_TryGetPosition_InjectedDelegateField;

	private static readonly Bone_TryGetRotation_InjectedDelegate Bone_TryGetRotation_InjectedDelegateField;

	private static readonly Bone_TryGetParentBone_InjectedDelegate Bone_TryGetParentBone_InjectedDelegateField;

	private static readonly Bone_TryGetChildBones_InjectedDelegate Bone_TryGetChildBones_InjectedDelegateField;

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

	static Bone()
	{
		Il2CppClassPointerStore<Bone>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.XRModule.dll", "UnityEngine.XR", "Bone");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Bone>.NativeClassPtr);
		NativeFieldInfoPtr_m_DeviceId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Bone>.NativeClassPtr, "m_DeviceId");
		NativeFieldInfoPtr_m_FeatureIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Bone>.NativeClassPtr, "m_FeatureIndex");
		NativeMethodInfoPtr_get_deviceId_Internal_get_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Bone>.NativeClassPtr, 100663321);
		NativeMethodInfoPtr_get_featureIndex_Internal_get_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Bone>.NativeClassPtr, 100663322);
		NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Bone>.NativeClassPtr, 100663323);
		NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Bone_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Bone>.NativeClassPtr, 100663324);
		NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Bone>.NativeClassPtr, 100663325);
		Bone_TryGetPosition_InjectedDelegateField = IL2CPP.ResolveICall<Bone_TryGetPosition_InjectedDelegate>("UnityEngine.XR.Bone::Bone_TryGetPosition_Injected");
		Bone_TryGetRotation_InjectedDelegateField = IL2CPP.ResolveICall<Bone_TryGetRotation_InjectedDelegate>("UnityEngine.XR.Bone::Bone_TryGetRotation_Injected");
		Bone_TryGetParentBone_InjectedDelegateField = IL2CPP.ResolveICall<Bone_TryGetParentBone_InjectedDelegate>("UnityEngine.XR.Bone::Bone_TryGetParentBone_Injected");
		Bone_TryGetChildBones_InjectedDelegateField = IL2CPP.ResolveICall<Bone_TryGetChildBones_InjectedDelegate>("UnityEngine.XR.Bone::Bone_TryGetChildBones_Injected");
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1411038, XrefRangeEnd = 1411041, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
	public unsafe virtual bool Equals(Bone other)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&other);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Bone_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
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
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Bone>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}

	public bool TryGetPosition(out Vector3 position)
	{
		return Bone_TryGetPosition(this, out position);
	}

	public static bool Bone_TryGetPosition(Bone bone, out Vector3 position)
	{
		return Bone_TryGetPosition_Injected(ref bone, out position);
	}

	public bool TryGetRotation(out Quaternion rotation)
	{
		return Bone_TryGetRotation(this, out rotation);
	}

	public static bool Bone_TryGetRotation(Bone bone, out Quaternion rotation)
	{
		return Bone_TryGetRotation_Injected(ref bone, out rotation);
	}

	public bool TryGetParentBone(out Bone parentBone)
	{
		return Bone_TryGetParentBone(this, out parentBone);
	}

	public static bool Bone_TryGetParentBone(Bone bone, out Bone parentBone)
	{
		return Bone_TryGetParentBone_Injected(ref bone, out parentBone);
	}

	public bool TryGetChildBones(List<Bone> childBones)
	{
		return Bone_TryGetChildBones(this, childBones);
	}

	public static bool Bone_TryGetChildBones(Bone bone, List<Bone> childBones)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	public static bool operator ==(Bone a, Bone b)
	{
		return a.Equals(b);
	}

	public static bool operator !=(Bone a, Bone b)
	{
		return !(a == b);
	}

	public unsafe static bool Bone_TryGetPosition_Injected([In] ref Bone bone, out Vector3 position)
	{
		return Bone_TryGetPosition_InjectedDelegateField((nint)Unsafe.AsPointer(ref bone), (nint)Unsafe.AsPointer(ref position));
	}

	public unsafe static bool Bone_TryGetRotation_Injected([In] ref Bone bone, out Quaternion rotation)
	{
		return Bone_TryGetRotation_InjectedDelegateField((nint)Unsafe.AsPointer(ref bone), (nint)Unsafe.AsPointer(ref rotation));
	}

	public unsafe static bool Bone_TryGetParentBone_Injected([In] ref Bone bone, out Bone parentBone)
	{
		return Bone_TryGetParentBone_InjectedDelegateField((nint)Unsafe.AsPointer(ref bone), (nint)Unsafe.AsPointer(ref parentBone));
	}

	public unsafe static bool Bone_TryGetChildBones_Injected([In] ref Bone bone, ref BlittableListWrapper childBones)
	{
		return Bone_TryGetChildBones_InjectedDelegateField((nint)Unsafe.AsPointer(ref bone), (nint)Unsafe.AsPointer(ref childBones));
	}
}
