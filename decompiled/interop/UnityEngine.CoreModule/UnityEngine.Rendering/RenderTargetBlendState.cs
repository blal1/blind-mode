using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;

namespace UnityEngine.Rendering;

[StructLayout(LayoutKind.Explicit)]
public struct RenderTargetBlendState
{
	private static readonly System.IntPtr NativeFieldInfoPtr_m_WriteMask;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_SourceColorBlendMode;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_DestinationColorBlendMode;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_SourceAlphaBlendMode;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_DestinationAlphaBlendMode;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_ColorBlendOperation;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_AlphaBlendOperation;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_Padding;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_defaultValue_Public_Static_get_RenderTargetBlendState_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_ColorWriteMask_BlendMode_BlendMode_BlendMode_BlendMode_BlendOp_BlendOp_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_RenderTargetBlendState_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

	[FieldOffset(0)]
	public byte m_WriteMask;

	[FieldOffset(1)]
	public byte m_SourceColorBlendMode;

	[FieldOffset(2)]
	public byte m_DestinationColorBlendMode;

	[FieldOffset(3)]
	public byte m_SourceAlphaBlendMode;

	[FieldOffset(4)]
	public byte m_DestinationAlphaBlendMode;

	[FieldOffset(5)]
	public byte m_ColorBlendOperation;

	[FieldOffset(6)]
	public byte m_AlphaBlendOperation;

	[FieldOffset(7)]
	public byte m_Padding;

	public unsafe static RenderTargetBlendState defaultValue
	{
		[CallerCount(0)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_defaultValue_Public_Static_get_RenderTargetBlendState_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(RenderTargetBlendState*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public ColorWriteMask writeMask
	{
		get
		{
			return (ColorWriteMask)m_WriteMask;
		}
		set
		{
			m_WriteMask = (byte)value;
		}
	}

	public BlendMode sourceColorBlendMode
	{
		get
		{
			return (BlendMode)m_SourceColorBlendMode;
		}
		set
		{
			m_SourceColorBlendMode = (byte)value;
		}
	}

	public BlendMode destinationColorBlendMode
	{
		get
		{
			return (BlendMode)m_DestinationColorBlendMode;
		}
		set
		{
			m_DestinationColorBlendMode = (byte)value;
		}
	}

	public BlendMode sourceAlphaBlendMode
	{
		get
		{
			return (BlendMode)m_SourceAlphaBlendMode;
		}
		set
		{
			m_SourceAlphaBlendMode = (byte)value;
		}
	}

	public BlendMode destinationAlphaBlendMode
	{
		get
		{
			return (BlendMode)m_DestinationAlphaBlendMode;
		}
		set
		{
			m_DestinationAlphaBlendMode = (byte)value;
		}
	}

	public BlendOp colorBlendOperation
	{
		get
		{
			return (BlendOp)m_ColorBlendOperation;
		}
		set
		{
			m_ColorBlendOperation = (byte)value;
		}
	}

	public BlendOp alphaBlendOperation
	{
		get
		{
			return (BlendOp)m_AlphaBlendOperation;
		}
		set
		{
			m_AlphaBlendOperation = (byte)value;
		}
	}

	static RenderTargetBlendState()
	{
		Il2CppClassPointerStore<RenderTargetBlendState>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Rendering", "RenderTargetBlendState");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RenderTargetBlendState>.NativeClassPtr);
		NativeFieldInfoPtr_m_WriteMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderTargetBlendState>.NativeClassPtr, "m_WriteMask");
		NativeFieldInfoPtr_m_SourceColorBlendMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderTargetBlendState>.NativeClassPtr, "m_SourceColorBlendMode");
		NativeFieldInfoPtr_m_DestinationColorBlendMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderTargetBlendState>.NativeClassPtr, "m_DestinationColorBlendMode");
		NativeFieldInfoPtr_m_SourceAlphaBlendMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderTargetBlendState>.NativeClassPtr, "m_SourceAlphaBlendMode");
		NativeFieldInfoPtr_m_DestinationAlphaBlendMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderTargetBlendState>.NativeClassPtr, "m_DestinationAlphaBlendMode");
		NativeFieldInfoPtr_m_ColorBlendOperation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderTargetBlendState>.NativeClassPtr, "m_ColorBlendOperation");
		NativeFieldInfoPtr_m_AlphaBlendOperation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderTargetBlendState>.NativeClassPtr, "m_AlphaBlendOperation");
		NativeFieldInfoPtr_m_Padding = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderTargetBlendState>.NativeClassPtr, "m_Padding");
		NativeMethodInfoPtr_get_defaultValue_Public_Static_get_RenderTargetBlendState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTargetBlendState>.NativeClassPtr, 100668653);
		NativeMethodInfoPtr__ctor_Public_Void_ColorWriteMask_BlendMode_BlendMode_BlendMode_BlendMode_BlendOp_BlendOp_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTargetBlendState>.NativeClassPtr, 100668654);
		NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_RenderTargetBlendState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTargetBlendState>.NativeClassPtr, 100668655);
		NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTargetBlendState>.NativeClassPtr, 100668656);
		NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTargetBlendState>.NativeClassPtr, 100668657);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1239162, RefRangeEnd = 1239163, XrefRangeStart = 1239162, XrefRangeEnd = 1239162, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe RenderTargetBlendState(ColorWriteMask writeMask = ColorWriteMask.All, BlendMode sourceColorBlendMode = BlendMode.One, BlendMode destinationColorBlendMode = BlendMode.Zero, BlendMode sourceAlphaBlendMode = BlendMode.One, BlendMode destinationAlphaBlendMode = BlendMode.Zero, BlendOp colorBlendOperation = BlendOp.Add, BlendOp alphaBlendOperation = BlendOp.Add)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[7];
		*ptr = (nint)(&writeMask);
		*(BlendMode**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &sourceColorBlendMode;
		*(BlendMode**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &destinationColorBlendMode;
		*(BlendMode**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &sourceAlphaBlendMode;
		*(BlendMode**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &destinationAlphaBlendMode;
		*(BlendOp**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &colorBlendOperation;
		*(BlendOp**)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = &alphaBlendOperation;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_ColorWriteMask_BlendMode_BlendMode_BlendMode_BlendMode_BlendOp_BlendOp_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 1239163, RefRangeEnd = 1239168, XrefRangeStart = 1239163, XrefRangeEnd = 1239163, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual bool Equals(RenderTargetBlendState other)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&other);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_RenderTargetBlendState_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1239168, XrefRangeEnd = 1239171, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool Equals(Il2CppSystem.Object obj)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)obj);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1239178, RefRangeEnd = 1239180, XrefRangeStart = 1239171, XrefRangeEnd = 1239178, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override int GetHashCode()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RenderTargetBlendState>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}

	public static bool operator ==(RenderTargetBlendState left, RenderTargetBlendState right)
	{
		return left.Equals(right);
	}

	public static bool operator !=(RenderTargetBlendState left, RenderTargetBlendState right)
	{
		return !left.Equals(right);
	}
}
