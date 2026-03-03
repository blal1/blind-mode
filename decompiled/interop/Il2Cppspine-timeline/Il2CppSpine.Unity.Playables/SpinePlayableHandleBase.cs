using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppSpine.Unity.Playables;

public class SpinePlayableHandleBase : MonoBehaviour
{
	private static readonly IntPtr NativeFieldInfoPtr_AnimationEvents;

	private static readonly IntPtr NativeMethodInfoPtr_get_SkeletonData_Public_Abstract_Virtual_New_get_SkeletonData_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_Skeleton_Public_Abstract_Virtual_New_get_Skeleton_0;

	private static readonly IntPtr NativeMethodInfoPtr_add_AnimationEvents_Public_add_Void_SpineEventDelegate_0;

	private static readonly IntPtr NativeMethodInfoPtr_remove_AnimationEvents_Public_rem_Void_SpineEventDelegate_0;

	private static readonly IntPtr NativeMethodInfoPtr_HandleEvents_Public_Virtual_New_Void_ExposedList_1_Event_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

	public unsafe SpineEventDelegate AnimationEvents
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_AnimationEvents);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<SpineEventDelegate>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_AnimationEvents)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe virtual SkeletonData SkeletonData
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_get_SkeletonData_Public_Abstract_Virtual_New_get_SkeletonData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (IntPtr)0) ? Il2CppObjectPool.Get<SkeletonData>(intPtr2) : null;
		}
	}

	public unsafe virtual Skeleton Skeleton
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_get_Skeleton_Public_Abstract_Virtual_New_get_Skeleton_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (IntPtr)0) ? Il2CppObjectPool.Get<Skeleton>(intPtr2) : null;
		}
	}

	static SpinePlayableHandleBase()
	{
		Il2CppClassPointerStore<SpinePlayableHandleBase>.NativeClassPtr = IL2CPP.GetIl2CppClass("spine-timeline.dll", "Spine.Unity.Playables", "SpinePlayableHandleBase");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpinePlayableHandleBase>.NativeClassPtr);
		NativeFieldInfoPtr_AnimationEvents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpinePlayableHandleBase>.NativeClassPtr, "AnimationEvents");
		NativeMethodInfoPtr_get_SkeletonData_Public_Abstract_Virtual_New_get_SkeletonData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpinePlayableHandleBase>.NativeClassPtr, 100663317);
		NativeMethodInfoPtr_get_Skeleton_Public_Abstract_Virtual_New_get_Skeleton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpinePlayableHandleBase>.NativeClassPtr, 100663318);
		NativeMethodInfoPtr_add_AnimationEvents_Public_add_Void_SpineEventDelegate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpinePlayableHandleBase>.NativeClassPtr, 100663319);
		NativeMethodInfoPtr_remove_AnimationEvents_Public_rem_Void_SpineEventDelegate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpinePlayableHandleBase>.NativeClassPtr, 100663320);
		NativeMethodInfoPtr_HandleEvents_Public_Virtual_New_Void_ExposedList_1_Event_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpinePlayableHandleBase>.NativeClassPtr, 100663321);
		NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpinePlayableHandleBase>.NativeClassPtr, 100663322);
	}

	[SpecialName]
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 849649, XrefRangeEnd = 849653, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void add_AnimationEvents(SpineEventDelegate value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_add_AnimationEvents_Public_add_Void_SpineEventDelegate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[SpecialName]
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 849653, XrefRangeEnd = 849657, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void remove_AnimationEvents(SpineEventDelegate value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_remove_AnimationEvents_Public_rem_Void_SpineEventDelegate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	public unsafe virtual void HandleEvents(ExposedList<Event> eventBuffer)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)eventBuffer);
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_HandleEvents_Public_Virtual_New_Void_ExposedList_1_Event_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(103)]
	[CachedScanResults(RefRangeStart = 22793, RefRangeEnd = 22896, XrefRangeStart = 22793, XrefRangeEnd = 22896, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe SpinePlayableHandleBase()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SpinePlayableHandleBase>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public SpinePlayableHandleBase(IntPtr pointer)
		: base(pointer)
	{
	}
}
