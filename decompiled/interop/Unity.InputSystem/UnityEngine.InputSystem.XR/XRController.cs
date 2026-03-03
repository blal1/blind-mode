using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;

namespace UnityEngine.InputSystem.XR;

public class XRController : TrackedDevice
{
	private static readonly IntPtr NativeMethodInfoPtr_get_leftHand_Public_Static_get_XRController_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_rightHand_Public_Static_get_XRController_0;

	private static readonly IntPtr NativeMethodInfoPtr_FinishSetup_Protected_Virtual_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe static XRController leftHand
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 999321, XrefRangeEnd = 999331, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_leftHand_Public_Static_get_XRController_0, (IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (IntPtr)0) ? Il2CppObjectPool.Get<XRController>(intPtr2) : null;
		}
	}

	public unsafe static XRController rightHand
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 999331, XrefRangeEnd = 999341, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_rightHand_Public_Static_get_XRController_0, (IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (IntPtr)0) ? Il2CppObjectPool.Get<XRController>(intPtr2) : null;
		}
	}

	static XRController()
	{
		Il2CppClassPointerStore<XRController>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.InputSystem.dll", "UnityEngine.InputSystem.XR", "XRController");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XRController>.NativeClassPtr);
		NativeMethodInfoPtr_get_leftHand_Public_Static_get_XRController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XRController>.NativeClassPtr, 100666402);
		NativeMethodInfoPtr_get_rightHand_Public_Static_get_XRController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XRController>.NativeClassPtr, 100666403);
		NativeMethodInfoPtr_FinishSetup_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XRController>.NativeClassPtr, 100666404);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XRController>.NativeClassPtr, 100666405);
	}

	[CallerCount(8)]
	[CachedScanResults(RefRangeStart = 999357, RefRangeEnd = 999365, XrefRangeStart = 999341, XrefRangeEnd = 999357, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void FinishSetup()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_FinishSetup_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(14)]
	[CachedScanResults(RefRangeStart = 962989, RefRangeEnd = 963003, XrefRangeStart = 962989, XrefRangeEnd = 963003, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe XRController()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XRController>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public XRController(IntPtr pointer)
		: base(pointer)
	{
	}
}
