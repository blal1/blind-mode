using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace UnityEngine.XR;

public class XRMeshSubsystemDescriptor : IntegratedSubsystemDescriptor<XRMeshSubsystem>
{
	public static class BindingsMarshaller
	{
	}

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	static XRMeshSubsystemDescriptor()
	{
		Il2CppClassPointerStore<XRMeshSubsystemDescriptor>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.XRModule.dll", "UnityEngine.XR", "XRMeshSubsystemDescriptor");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XRMeshSubsystemDescriptor>.NativeClassPtr);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XRMeshSubsystemDescriptor>.NativeClassPtr, 100663405);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1411324, XrefRangeEnd = 1411327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe XRMeshSubsystemDescriptor()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XRMeshSubsystemDescriptor>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public XRMeshSubsystemDescriptor(IntPtr pointer)
		: base(pointer)
	{
	}
}
