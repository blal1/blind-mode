using System;
using Il2CppInterop.Runtime;
using UnityEngine.Bindings;

namespace UnityEngine;

public sealed class BillboardRenderer : Renderer
{
	private delegate IntPtr get_billboard_InjectedDelegate(IntPtr _unity_self);

	private delegate void set_billboard_InjectedDelegate(IntPtr _unity_self, IntPtr value);

	private static readonly get_billboard_InjectedDelegate get_billboard_InjectedDelegateField = IL2CPP.ResolveICall<get_billboard_InjectedDelegate>("UnityEngine.BillboardRenderer::get_billboard_Injected");

	private static readonly set_billboard_InjectedDelegate set_billboard_InjectedDelegateField = IL2CPP.ResolveICall<set_billboard_InjectedDelegate>("UnityEngine.BillboardRenderer::set_billboard_Injected");

	public BillboardAsset billboard
	{
		get
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			return Unmarshal.UnmarshalUnityObject<BillboardAsset>(get_billboard_Injected(intPtr));
		}
		set
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			set_billboard_Injected(intPtr, MarshalledUnityObject.Marshal(value));
		}
	}

	public static IntPtr get_billboard_Injected(IntPtr _unity_self)
	{
		return get_billboard_InjectedDelegateField(_unity_self);
	}

	public static void set_billboard_Injected(IntPtr _unity_self, IntPtr value)
	{
		set_billboard_InjectedDelegateField(_unity_self, value);
	}
}
