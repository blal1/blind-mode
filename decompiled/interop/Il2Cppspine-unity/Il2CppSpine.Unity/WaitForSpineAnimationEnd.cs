using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSpine.Unity;

public class WaitForSpineAnimationEnd : WaitForSpineAnimation
{
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_TrackEntry_0;

	private static readonly IntPtr NativeMethodInfoPtr_NowWaitFor_Public_WaitForSpineAnimationEnd_TrackEntry_0;

	static WaitForSpineAnimationEnd()
	{
		Il2CppClassPointerStore<WaitForSpineAnimationEnd>.NativeClassPtr = IL2CPP.GetIl2CppClass("spine-unity.dll", "Spine.Unity", "WaitForSpineAnimationEnd");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WaitForSpineAnimationEnd>.NativeClassPtr);
		NativeMethodInfoPtr__ctor_Public_Void_TrackEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaitForSpineAnimationEnd>.NativeClassPtr, 100664181);
		NativeMethodInfoPtr_NowWaitFor_Public_WaitForSpineAnimationEnd_TrackEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaitForSpineAnimationEnd>.NativeClassPtr, 100664182);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 857976, XrefRangeEnd = 857978, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe WaitForSpineAnimationEnd(TrackEntry trackEntry)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WaitForSpineAnimationEnd>.NativeClassPtr))
	{
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)trackEntry);
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_TrackEntry_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 857978, XrefRangeEnd = 857979, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe WaitForSpineAnimationEnd NowWaitFor(TrackEntry trackEntry)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)trackEntry);
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_NowWaitFor_Public_WaitForSpineAnimationEnd_TrackEntry_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (IntPtr)0) ? Il2CppObjectPool.Get<WaitForSpineAnimationEnd>(intPtr2) : null;
	}

	public WaitForSpineAnimationEnd(IntPtr pointer)
		: base(pointer)
	{
	}
}
