using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;

namespace UnityEngine.XR;

[StructLayout(LayoutKind.Explicit)]
public struct Eyes
{
	private delegate bool Eyes_TryGetEyePosition_InjectedDelegate([In] System.IntPtr eyes, EyeSide chirality, [Out] System.IntPtr position);

	private delegate bool Eyes_TryGetEyeRotation_InjectedDelegate([In] System.IntPtr eyes, EyeSide chirality, [Out] System.IntPtr rotation);

	private delegate bool Eyes_TryGetFixationPoint_InjectedDelegate([In] System.IntPtr eyes, [Out] System.IntPtr fixationPoint);

	private delegate bool Eyes_TryGetEyeOpenAmount_InjectedDelegate([In] System.IntPtr eyes, EyeSide chirality, [Out] System.IntPtr openAmount);

	private static readonly System.IntPtr NativeFieldInfoPtr_m_DeviceId;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_FeatureIndex;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_deviceId_Internal_get_UInt64_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_featureIndex_Internal_get_UInt32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Eyes_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

	[FieldOffset(0)]
	public ulong m_DeviceId;

	[FieldOffset(8)]
	public uint m_FeatureIndex;

	private static readonly Eyes_TryGetEyePosition_InjectedDelegate Eyes_TryGetEyePosition_InjectedDelegateField;

	private static readonly Eyes_TryGetEyeRotation_InjectedDelegate Eyes_TryGetEyeRotation_InjectedDelegateField;

	private static readonly Eyes_TryGetFixationPoint_InjectedDelegate Eyes_TryGetFixationPoint_InjectedDelegateField;

	private static readonly Eyes_TryGetEyeOpenAmount_InjectedDelegate Eyes_TryGetEyeOpenAmount_InjectedDelegateField;

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

	static Eyes()
	{
		Il2CppClassPointerStore<Eyes>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.XRModule.dll", "UnityEngine.XR", "Eyes");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Eyes>.NativeClassPtr);
		NativeFieldInfoPtr_m_DeviceId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Eyes>.NativeClassPtr, "m_DeviceId");
		NativeFieldInfoPtr_m_FeatureIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Eyes>.NativeClassPtr, "m_FeatureIndex");
		NativeMethodInfoPtr_get_deviceId_Internal_get_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Eyes>.NativeClassPtr, 100663316);
		NativeMethodInfoPtr_get_featureIndex_Internal_get_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Eyes>.NativeClassPtr, 100663317);
		NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Eyes>.NativeClassPtr, 100663318);
		NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Eyes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Eyes>.NativeClassPtr, 100663319);
		NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Eyes>.NativeClassPtr, 100663320);
		Eyes_TryGetEyePosition_InjectedDelegateField = IL2CPP.ResolveICall<Eyes_TryGetEyePosition_InjectedDelegate>("UnityEngine.XR.Eyes::Eyes_TryGetEyePosition_Injected");
		Eyes_TryGetEyeRotation_InjectedDelegateField = IL2CPP.ResolveICall<Eyes_TryGetEyeRotation_InjectedDelegate>("UnityEngine.XR.Eyes::Eyes_TryGetEyeRotation_Injected");
		Eyes_TryGetFixationPoint_InjectedDelegateField = IL2CPP.ResolveICall<Eyes_TryGetFixationPoint_InjectedDelegate>("UnityEngine.XR.Eyes::Eyes_TryGetFixationPoint_Injected");
		Eyes_TryGetEyeOpenAmount_InjectedDelegateField = IL2CPP.ResolveICall<Eyes_TryGetEyeOpenAmount_InjectedDelegate>("UnityEngine.XR.Eyes::Eyes_TryGetEyeOpenAmount_Injected");
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1411035, XrefRangeEnd = 1411038, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
	public unsafe virtual bool Equals(Eyes other)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&other);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Eyes_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
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
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Eyes>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}

	public bool TryGetLeftEyePosition(out Vector3 position)
	{
		return Eyes_TryGetEyePosition(this, EyeSide.Left, out position);
	}

	public bool TryGetRightEyePosition(out Vector3 position)
	{
		return Eyes_TryGetEyePosition(this, EyeSide.Right, out position);
	}

	public bool TryGetLeftEyeRotation(out Quaternion rotation)
	{
		return Eyes_TryGetEyeRotation(this, EyeSide.Left, out rotation);
	}

	public bool TryGetRightEyeRotation(out Quaternion rotation)
	{
		return Eyes_TryGetEyeRotation(this, EyeSide.Right, out rotation);
	}

	public static bool Eyes_TryGetEyePosition(Eyes eyes, EyeSide chirality, out Vector3 position)
	{
		return Eyes_TryGetEyePosition_Injected(ref eyes, chirality, out position);
	}

	public static bool Eyes_TryGetEyeRotation(Eyes eyes, EyeSide chirality, out Quaternion rotation)
	{
		return Eyes_TryGetEyeRotation_Injected(ref eyes, chirality, out rotation);
	}

	public bool TryGetFixationPoint(out Vector3 fixationPoint)
	{
		return Eyes_TryGetFixationPoint(this, out fixationPoint);
	}

	public static bool Eyes_TryGetFixationPoint(Eyes eyes, out Vector3 fixationPoint)
	{
		return Eyes_TryGetFixationPoint_Injected(ref eyes, out fixationPoint);
	}

	public bool TryGetLeftEyeOpenAmount(out float openAmount)
	{
		return Eyes_TryGetEyeOpenAmount(this, EyeSide.Left, out openAmount);
	}

	public bool TryGetRightEyeOpenAmount(out float openAmount)
	{
		return Eyes_TryGetEyeOpenAmount(this, EyeSide.Right, out openAmount);
	}

	public static bool Eyes_TryGetEyeOpenAmount(Eyes eyes, EyeSide chirality, out float openAmount)
	{
		return Eyes_TryGetEyeOpenAmount_Injected(ref eyes, chirality, out openAmount);
	}

	public static bool operator ==(Eyes a, Eyes b)
	{
		return a.Equals(b);
	}

	public static bool operator !=(Eyes a, Eyes b)
	{
		return !(a == b);
	}

	public unsafe static bool Eyes_TryGetEyePosition_Injected([In] ref Eyes eyes, EyeSide chirality, out Vector3 position)
	{
		return Eyes_TryGetEyePosition_InjectedDelegateField((nint)Unsafe.AsPointer(ref eyes), chirality, (nint)Unsafe.AsPointer(ref position));
	}

	public unsafe static bool Eyes_TryGetEyeRotation_Injected([In] ref Eyes eyes, EyeSide chirality, out Quaternion rotation)
	{
		return Eyes_TryGetEyeRotation_InjectedDelegateField((nint)Unsafe.AsPointer(ref eyes), chirality, (nint)Unsafe.AsPointer(ref rotation));
	}

	public unsafe static bool Eyes_TryGetFixationPoint_Injected([In] ref Eyes eyes, out Vector3 fixationPoint)
	{
		return Eyes_TryGetFixationPoint_InjectedDelegateField((nint)Unsafe.AsPointer(ref eyes), (nint)Unsafe.AsPointer(ref fixationPoint));
	}

	public unsafe static bool Eyes_TryGetEyeOpenAmount_Injected([In] ref Eyes eyes, EyeSide chirality, out float openAmount)
	{
		return Eyes_TryGetEyeOpenAmount_InjectedDelegateField((nint)Unsafe.AsPointer(ref eyes), chirality, (nint)Unsafe.AsPointer(ref openAmount));
	}
}
