using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSpine.Unity;

public class WaitForSpineAnimationComplete : WaitForSpineAnimation
{
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_TrackEntry_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr_NowWaitFor_Public_WaitForSpineAnimationComplete_TrackEntry_Boolean_0;

	static WaitForSpineAnimationComplete()
	{
		Il2CppClassPointerStore<WaitForSpineAnimationComplete>.NativeClassPtr = IL2CPP.GetIl2CppClass("spine-unity.dll", "Spine.Unity", "WaitForSpineAnimationComplete");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WaitForSpineAnimationComplete>.NativeClassPtr);
		NativeMethodInfoPtr__ctor_Public_Void_TrackEntry_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaitForSpineAnimationComplete>.NativeClassPtr, 100664179);
		NativeMethodInfoPtr_NowWaitFor_Public_WaitForSpineAnimationComplete_TrackEntry_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaitForSpineAnimationComplete>.NativeClassPtr, 100664180);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 857973, XrefRangeEnd = 857975, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe WaitForSpineAnimationComplete(TrackEntry trackEntry, bool includeEndEvent = false)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WaitForSpineAnimationComplete>.NativeClassPtr))
	{
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)trackEntry);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &includeEndEvent;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_TrackEntry_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 857975, XrefRangeEnd = 857976, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe WaitForSpineAnimationComplete NowWaitFor(TrackEntry trackEntry, bool includeEndEvent = false)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)trackEntry);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &includeEndEvent;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_NowWaitFor_Public_WaitForSpineAnimationComplete_TrackEntry_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (IntPtr)0) ? Il2CppObjectPool.Get<WaitForSpineAnimationComplete>(intPtr2) : null;
	}

	public WaitForSpineAnimationComplete(IntPtr pointer)
		: base(pointer)
	{
	}
}
