using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine.Events;

namespace UnityEngine;

public static class BeforeRenderHelper : Il2CppSystem.Object
{
	public sealed class OrderBlock : Il2CppSystem.ValueType
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_order;

		private static readonly System.IntPtr NativeFieldInfoPtr_callback;

		public unsafe int order
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_order);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_order)) = value;
			}
		}

		public unsafe UnityAction callback
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_callback);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<UnityAction>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_callback)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		static OrderBlock()
		{
			Il2CppClassPointerStore<OrderBlock>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BeforeRenderHelper>.NativeClassPtr, "OrderBlock");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OrderBlock>.NativeClassPtr);
			NativeFieldInfoPtr_order = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OrderBlock>.NativeClassPtr, "order");
			NativeFieldInfoPtr_callback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OrderBlock>.NativeClassPtr, "callback");
		}

		public OrderBlock(System.IntPtr pointer)
			: base(pointer)
		{
		}

		public OrderBlock()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OrderBlock>.NativeClassPtr))
		{
		}
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_s_OrderBlocks;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetUpdateOrder_Private_Static_Int32_UnityAction_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RegisterCallback_Public_Static_Void_UnityAction_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UnregisterCallback_Public_Static_Void_UnityAction_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Static_Void_0;

	public unsafe static List<OrderBlock> s_OrderBlocks
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_OrderBlocks, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<OrderBlock>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_OrderBlocks, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	static BeforeRenderHelper()
	{
		Il2CppClassPointerStore<BeforeRenderHelper>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "BeforeRenderHelper");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BeforeRenderHelper>.NativeClassPtr);
		NativeFieldInfoPtr_s_OrderBlocks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BeforeRenderHelper>.NativeClassPtr, "s_OrderBlocks");
		NativeMethodInfoPtr_GetUpdateOrder_Private_Static_Int32_UnityAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BeforeRenderHelper>.NativeClassPtr, 100664281);
		NativeMethodInfoPtr_RegisterCallback_Public_Static_Void_UnityAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BeforeRenderHelper>.NativeClassPtr, 100664282);
		NativeMethodInfoPtr_UnregisterCallback_Public_Static_Void_UnityAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BeforeRenderHelper>.NativeClassPtr, 100664283);
		NativeMethodInfoPtr_Invoke_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BeforeRenderHelper>.NativeClassPtr, 100664284);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1171936, RefRangeEnd = 1171938, XrefRangeStart = 1171927, XrefRangeEnd = 1171936, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int GetUpdateOrder(UnityAction callback)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)callback);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetUpdateOrder_Private_Static_Int32_UnityAction_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1171989, RefRangeEnd = 1171990, XrefRangeStart = 1171938, XrefRangeEnd = 1171989, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void RegisterCallback(UnityAction callback)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)callback);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RegisterCallback_Public_Static_Void_UnityAction_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1172037, RefRangeEnd = 1172038, XrefRangeStart = 1171990, XrefRangeEnd = 1172037, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void UnregisterCallback(UnityAction callback)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)callback);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UnregisterCallback_Public_Static_Void_UnityAction_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1172056, RefRangeEnd = 1172057, XrefRangeStart = 1172038, XrefRangeEnd = 1172056, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Invoke()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Invoke_Public_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public BeforeRenderHelper(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
