using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using UnityEngine.Bindings;

namespace UnityEngine.XR;

public class XRInputSubsystemDescriptor : IntegratedSubsystemDescriptor<XRInputSubsystem>
{
	public static class BindingsMarshaller
	{
	}

	private delegate bool get_disablesLegacyInput_InjectedDelegate(IntPtr _unity_self);

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	private static readonly get_disablesLegacyInput_InjectedDelegate get_disablesLegacyInput_InjectedDelegateField;

	public bool disablesLegacyInput
	{
		get
		{
			IntPtr intPtr = BindingsMarshaller.ConvertToNative(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_disablesLegacyInput_Injected(intPtr);
		}
	}

	static XRInputSubsystemDescriptor()
	{
		Il2CppClassPointerStore<XRInputSubsystemDescriptor>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.XRModule.dll", "UnityEngine.XR", "XRInputSubsystemDescriptor");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XRInputSubsystemDescriptor>.NativeClassPtr);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XRInputSubsystemDescriptor>.NativeClassPtr, 100663377);
		get_disablesLegacyInput_InjectedDelegateField = IL2CPP.ResolveICall<get_disablesLegacyInput_InjectedDelegate>("UnityEngine.XR.XRInputSubsystemDescriptor::get_disablesLegacyInput_Injected");
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1411270, XrefRangeEnd = 1411273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe XRInputSubsystemDescriptor()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XRInputSubsystemDescriptor>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public XRInputSubsystemDescriptor(IntPtr pointer)
		: base(pointer)
	{
	}

	public static bool get_disablesLegacyInput_Injected(IntPtr _unity_self)
	{
		return get_disablesLegacyInput_InjectedDelegateField(_unity_self);
	}
}
