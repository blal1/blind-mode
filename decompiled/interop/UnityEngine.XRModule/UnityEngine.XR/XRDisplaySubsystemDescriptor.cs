using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using UnityEngine.Bindings;

namespace UnityEngine.XR;

public class XRDisplaySubsystemDescriptor : IntegratedSubsystemDescriptor<XRDisplaySubsystem>
{
	public static class BindingsMarshaller
	{
	}

	private delegate bool get_disablesLegacyVr_InjectedDelegate(IntPtr _unity_self);

	private delegate bool get_enableBackBufferMSAA_InjectedDelegate(IntPtr _unity_self);

	private delegate int GetAvailableMirrorBlitModeCount_InjectedDelegate(IntPtr _unity_self);

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	private static readonly get_disablesLegacyVr_InjectedDelegate get_disablesLegacyVr_InjectedDelegateField;

	private static readonly get_enableBackBufferMSAA_InjectedDelegate get_enableBackBufferMSAA_InjectedDelegateField;

	private static readonly GetAvailableMirrorBlitModeCount_InjectedDelegate GetAvailableMirrorBlitModeCount_InjectedDelegateField;

	public bool disablesLegacyVr
	{
		get
		{
			IntPtr intPtr = BindingsMarshaller.ConvertToNative(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_disablesLegacyVr_Injected(intPtr);
		}
	}

	public bool enableBackBufferMSAA
	{
		get
		{
			IntPtr intPtr = BindingsMarshaller.ConvertToNative(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_enableBackBufferMSAA_Injected(intPtr);
		}
	}

	static XRDisplaySubsystemDescriptor()
	{
		Il2CppClassPointerStore<XRDisplaySubsystemDescriptor>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.XRModule.dll", "UnityEngine.XR", "XRDisplaySubsystemDescriptor");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XRDisplaySubsystemDescriptor>.NativeClassPtr);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XRDisplaySubsystemDescriptor>.NativeClassPtr, 100663373);
		get_disablesLegacyVr_InjectedDelegateField = IL2CPP.ResolveICall<get_disablesLegacyVr_InjectedDelegate>("UnityEngine.XR.XRDisplaySubsystemDescriptor::get_disablesLegacyVr_Injected");
		get_enableBackBufferMSAA_InjectedDelegateField = IL2CPP.ResolveICall<get_enableBackBufferMSAA_InjectedDelegate>("UnityEngine.XR.XRDisplaySubsystemDescriptor::get_enableBackBufferMSAA_Injected");
		GetAvailableMirrorBlitModeCount_InjectedDelegateField = IL2CPP.ResolveICall<GetAvailableMirrorBlitModeCount_InjectedDelegate>("UnityEngine.XR.XRDisplaySubsystemDescriptor::GetAvailableMirrorBlitModeCount_Injected");
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1411252, XrefRangeEnd = 1411255, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe XRDisplaySubsystemDescriptor()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XRDisplaySubsystemDescriptor>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public XRDisplaySubsystemDescriptor(IntPtr pointer)
		: base(pointer)
	{
	}

	public int GetAvailableMirrorBlitModeCount()
	{
		IntPtr intPtr = BindingsMarshaller.ConvertToNative(this);
		if (intPtr == (IntPtr)0)
		{
			ThrowHelper.ThrowNullReferenceException(this);
		}
		return GetAvailableMirrorBlitModeCount_Injected(intPtr);
	}

	public static bool get_disablesLegacyVr_Injected(IntPtr _unity_self)
	{
		return get_disablesLegacyVr_InjectedDelegateField(_unity_self);
	}

	public static bool get_enableBackBufferMSAA_Injected(IntPtr _unity_self)
	{
		return get_enableBackBufferMSAA_InjectedDelegateField(_unity_self);
	}

	public static int GetAvailableMirrorBlitModeCount_Injected(IntPtr _unity_self)
	{
		return GetAvailableMirrorBlitModeCount_InjectedDelegateField(_unity_self);
	}
}
