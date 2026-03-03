using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Rendering;

[StructLayout(LayoutKind.Explicit)]
public struct RendererList
{
	private static readonly System.IntPtr NativeFieldInfoPtr_context;

	private static readonly System.IntPtr NativeFieldInfoPtr_index;

	private static readonly System.IntPtr NativeFieldInfoPtr_frame;

	private static readonly System.IntPtr NativeFieldInfoPtr_type;

	private static readonly System.IntPtr NativeFieldInfoPtr_contextID;

	private static readonly System.IntPtr NativeFieldInfoPtr_nullRendererList;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_isValid_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Internal_Void_UIntPtr_UInt32_0;

	[FieldOffset(0)]
	public System.UIntPtr context;

	[FieldOffset(8)]
	public uint index;

	[FieldOffset(12)]
	public uint frame;

	[FieldOffset(16)]
	public uint type;

	[FieldOffset(20)]
	public uint contextID;

	public unsafe static RendererList nullRendererList
	{
		get
		{
			Unsafe.SkipInit(out RendererList result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_nullRendererList, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_nullRendererList, (void*)(&value));
		}
	}

	public unsafe bool isValid
	{
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1238373, RefRangeEnd = 1238378, XrefRangeStart = 1238371, XrefRangeEnd = 1238373, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_isValid_Public_get_Boolean_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	static RendererList()
	{
		Il2CppClassPointerStore<RendererList>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Rendering", "RendererList");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RendererList>.NativeClassPtr);
		NativeFieldInfoPtr_context = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RendererList>.NativeClassPtr, "context");
		NativeFieldInfoPtr_index = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RendererList>.NativeClassPtr, "index");
		NativeFieldInfoPtr_frame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RendererList>.NativeClassPtr, "frame");
		NativeFieldInfoPtr_type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RendererList>.NativeClassPtr, "type");
		NativeFieldInfoPtr_contextID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RendererList>.NativeClassPtr, "contextID");
		NativeFieldInfoPtr_nullRendererList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RendererList>.NativeClassPtr, "nullRendererList");
		NativeMethodInfoPtr_get_isValid_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RendererList>.NativeClassPtr, 100668531);
		NativeMethodInfoPtr__ctor_Internal_Void_UIntPtr_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RendererList>.NativeClassPtr, 100668532);
	}

	[CallerCount(0)]
	public unsafe RendererList(System.UIntPtr ctx, uint indx)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&ctx);
		*(uint**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &indx;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Internal_Void_UIntPtr_UInt32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RendererList>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}
}
