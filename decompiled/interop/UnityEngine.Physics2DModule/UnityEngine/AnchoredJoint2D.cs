using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using UnityEngine.Bindings;

namespace UnityEngine;

public class AnchoredJoint2D : Joint2D
{
	private delegate void get_anchor_InjectedDelegate(IntPtr _unity_self, [Out] IntPtr ret);

	private delegate void set_anchor_InjectedDelegate(IntPtr _unity_self, [In] IntPtr value);

	private delegate void set_connectedAnchor_InjectedDelegate(IntPtr _unity_self, [In] IntPtr value);

	private delegate bool get_autoConfigureConnectedAnchor_InjectedDelegate(IntPtr _unity_self);

	private delegate void set_autoConfigureConnectedAnchor_InjectedDelegate(IntPtr _unity_self, bool value);

	private static readonly IntPtr NativeMethodInfoPtr_get_connectedAnchor_Public_get_Vector2_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_connectedAnchor_Injected_Private_Static_Void_IntPtr_byref_Vector2_0;

	private static readonly get_anchor_InjectedDelegate get_anchor_InjectedDelegateField;

	private static readonly set_anchor_InjectedDelegate set_anchor_InjectedDelegateField;

	private static readonly set_connectedAnchor_InjectedDelegate set_connectedAnchor_InjectedDelegateField;

	private static readonly get_autoConfigureConnectedAnchor_InjectedDelegate get_autoConfigureConnectedAnchor_InjectedDelegateField;

	private static readonly set_autoConfigureConnectedAnchor_InjectedDelegate set_autoConfigureConnectedAnchor_InjectedDelegateField;

	public unsafe Vector2 connectedAnchor
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1259138, RefRangeEnd = 1259139, XrefRangeStart = 1259134, XrefRangeEnd = 1259138, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_connectedAnchor_Public_get_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(Vector2*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		set
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			set_connectedAnchor_Injected(intPtr, ref value);
		}
	}

	public Vector2 anchor
	{
		get
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			get_anchor_Injected(intPtr, out var ret);
			return ret;
		}
		set
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			set_anchor_Injected(intPtr, ref value);
		}
	}

	public bool autoConfigureConnectedAnchor
	{
		get
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_autoConfigureConnectedAnchor_Injected(intPtr);
		}
		set
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			set_autoConfigureConnectedAnchor_Injected(intPtr, value);
		}
	}

	static AnchoredJoint2D()
	{
		Il2CppClassPointerStore<AnchoredJoint2D>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.Physics2DModule.dll", "UnityEngine", "AnchoredJoint2D");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AnchoredJoint2D>.NativeClassPtr);
		NativeMethodInfoPtr_get_connectedAnchor_Public_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnchoredJoint2D>.NativeClassPtr, 100663389);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnchoredJoint2D>.NativeClassPtr, 100663390);
		NativeMethodInfoPtr_get_connectedAnchor_Injected_Private_Static_Void_IntPtr_byref_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnchoredJoint2D>.NativeClassPtr, 100663391);
		get_anchor_InjectedDelegateField = IL2CPP.ResolveICall<get_anchor_InjectedDelegate>("UnityEngine.AnchoredJoint2D::get_anchor_Injected");
		set_anchor_InjectedDelegateField = IL2CPP.ResolveICall<set_anchor_InjectedDelegate>("UnityEngine.AnchoredJoint2D::set_anchor_Injected");
		set_connectedAnchor_InjectedDelegateField = IL2CPP.ResolveICall<set_connectedAnchor_InjectedDelegate>("UnityEngine.AnchoredJoint2D::set_connectedAnchor_Injected");
		get_autoConfigureConnectedAnchor_InjectedDelegateField = IL2CPP.ResolveICall<get_autoConfigureConnectedAnchor_InjectedDelegate>("UnityEngine.AnchoredJoint2D::get_autoConfigureConnectedAnchor_Injected");
		set_autoConfigureConnectedAnchor_InjectedDelegateField = IL2CPP.ResolveICall<set_autoConfigureConnectedAnchor_InjectedDelegate>("UnityEngine.AnchoredJoint2D::set_autoConfigureConnectedAnchor_Injected");
	}

	[CallerCount(646)]
	[CachedScanResults(RefRangeStart = 1152221, RefRangeEnd = 1152867, XrefRangeStart = 1152221, XrefRangeEnd = 1152867, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe AnchoredJoint2D()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AnchoredJoint2D>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1259139, XrefRangeEnd = 1259141, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void get_connectedAnchor_Injected(IntPtr _unity_self, out Vector2 ret)
	{
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = (nint)(&_unity_self);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = Unsafe.AsPointer(ref ret);
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_connectedAnchor_Injected_Private_Static_Void_IntPtr_byref_Vector2_0, (IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public AnchoredJoint2D(IntPtr pointer)
		: base(pointer)
	{
	}

	public unsafe static void get_anchor_Injected(IntPtr _unity_self, out Vector2 ret)
	{
		get_anchor_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref ret));
	}

	public unsafe static void set_anchor_Injected(IntPtr _unity_self, [In] ref Vector2 value)
	{
		set_anchor_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref value));
	}

	public unsafe static void set_connectedAnchor_Injected(IntPtr _unity_self, [In] ref Vector2 value)
	{
		set_connectedAnchor_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref value));
	}

	public static bool get_autoConfigureConnectedAnchor_Injected(IntPtr _unity_self)
	{
		return get_autoConfigureConnectedAnchor_InjectedDelegateField(_unity_self);
	}

	public static void set_autoConfigureConnectedAnchor_Injected(IntPtr _unity_self, bool value)
	{
		set_autoConfigureConnectedAnchor_InjectedDelegateField(_unity_self, value);
	}
}
