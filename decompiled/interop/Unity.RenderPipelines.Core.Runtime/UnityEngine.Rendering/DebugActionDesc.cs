using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine.InputSystem;

namespace UnityEngine.Rendering;

public class DebugActionDesc : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_buttonAction;

	private static readonly System.IntPtr NativeFieldInfoPtr_repeatMode;

	private static readonly System.IntPtr NativeFieldInfoPtr_repeatDelay;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe InputAction buttonAction
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_buttonAction);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<InputAction>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_buttonAction)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe DebugActionRepeatMode repeatMode
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_repeatMode);
			return *(DebugActionRepeatMode*)num;
		}
		set
		{
			*(DebugActionRepeatMode*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_repeatMode)) = value;
		}
	}

	public unsafe float repeatDelay
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_repeatDelay);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_repeatDelay)) = value;
		}
	}

	static DebugActionDesc()
	{
		Il2CppClassPointerStore<DebugActionDesc>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Core.Runtime.dll", "UnityEngine.Rendering", "DebugActionDesc");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DebugActionDesc>.NativeClassPtr);
		NativeFieldInfoPtr_buttonAction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugActionDesc>.NativeClassPtr, "buttonAction");
		NativeFieldInfoPtr_repeatMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugActionDesc>.NativeClassPtr, "repeatMode");
		NativeFieldInfoPtr_repeatDelay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugActionDesc>.NativeClassPtr, "repeatDelay");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugActionDesc>.NativeClassPtr, 100664783);
	}

	[CallerCount(1950)]
	[CachedScanResults(RefRangeStart = 20036, RefRangeEnd = 21986, XrefRangeStart = 20036, XrefRangeEnd = 21986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe DebugActionDesc()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DebugActionDesc>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public DebugActionDesc(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
