using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;

namespace UnityEngine.Rendering;

[StructLayout(LayoutKind.Explicit)]
public struct BlendState
{
	private static readonly System.IntPtr NativeFieldInfoPtr_m_BlendState0;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_BlendState1;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_BlendState2;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_BlendState3;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_BlendState4;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_BlendState5;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_BlendState6;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_BlendState7;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_SeparateMRTBlendStates;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_AlphaToMask;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_Padding;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_defaultValue_Public_Static_get_BlendState_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Boolean_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_blendState0_Public_set_Void_RenderTargetBlendState_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_BlendState_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

	[FieldOffset(0)]
	public RenderTargetBlendState m_BlendState0;

	[FieldOffset(8)]
	public RenderTargetBlendState m_BlendState1;

	[FieldOffset(16)]
	public RenderTargetBlendState m_BlendState2;

	[FieldOffset(24)]
	public RenderTargetBlendState m_BlendState3;

	[FieldOffset(32)]
	public RenderTargetBlendState m_BlendState4;

	[FieldOffset(40)]
	public RenderTargetBlendState m_BlendState5;

	[FieldOffset(48)]
	public RenderTargetBlendState m_BlendState6;

	[FieldOffset(56)]
	public RenderTargetBlendState m_BlendState7;

	[FieldOffset(64)]
	public byte m_SeparateMRTBlendStates;

	[FieldOffset(65)]
	public byte m_AlphaToMask;

	[FieldOffset(66)]
	public short m_Padding;

	public unsafe static BlendState defaultValue
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1237888, XrefRangeEnd = 1237889, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_defaultValue_Public_Static_get_BlendState_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(BlendState*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe RenderTargetBlendState blendState0
	{
		get
		{
			return m_BlendState0;
		}
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 687877, RefRangeEnd = 687880, XrefRangeStart = 687877, XrefRangeEnd = 687880, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_blendState0_Public_set_Void_RenderTargetBlendState_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public bool separateMRTBlendStates
	{
		get
		{
			return Il2CppSystem.Convert.ToBoolean(m_SeparateMRTBlendStates);
		}
		set
		{
			m_SeparateMRTBlendStates = Il2CppSystem.Convert.ToByte(value);
		}
	}

	public bool alphaToMask
	{
		get
		{
			return Il2CppSystem.Convert.ToBoolean(m_AlphaToMask);
		}
		set
		{
			m_AlphaToMask = Il2CppSystem.Convert.ToByte(value);
		}
	}

	public RenderTargetBlendState blendState1
	{
		get
		{
			return m_BlendState1;
		}
		set
		{
			m_BlendState1 = value;
		}
	}

	public RenderTargetBlendState blendState2
	{
		get
		{
			return m_BlendState2;
		}
		set
		{
			m_BlendState2 = value;
		}
	}

	public RenderTargetBlendState blendState3
	{
		get
		{
			return m_BlendState3;
		}
		set
		{
			m_BlendState3 = value;
		}
	}

	public RenderTargetBlendState blendState4
	{
		get
		{
			return m_BlendState4;
		}
		set
		{
			m_BlendState4 = value;
		}
	}

	public RenderTargetBlendState blendState5
	{
		get
		{
			return m_BlendState5;
		}
		set
		{
			m_BlendState5 = value;
		}
	}

	public RenderTargetBlendState blendState6
	{
		get
		{
			return m_BlendState6;
		}
		set
		{
			m_BlendState6 = value;
		}
	}

	public RenderTargetBlendState blendState7
	{
		get
		{
			return m_BlendState7;
		}
		set
		{
			m_BlendState7 = value;
		}
	}

	static BlendState()
	{
		Il2CppClassPointerStore<BlendState>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Rendering", "BlendState");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BlendState>.NativeClassPtr);
		NativeFieldInfoPtr_m_BlendState0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlendState>.NativeClassPtr, "m_BlendState0");
		NativeFieldInfoPtr_m_BlendState1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlendState>.NativeClassPtr, "m_BlendState1");
		NativeFieldInfoPtr_m_BlendState2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlendState>.NativeClassPtr, "m_BlendState2");
		NativeFieldInfoPtr_m_BlendState3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlendState>.NativeClassPtr, "m_BlendState3");
		NativeFieldInfoPtr_m_BlendState4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlendState>.NativeClassPtr, "m_BlendState4");
		NativeFieldInfoPtr_m_BlendState5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlendState>.NativeClassPtr, "m_BlendState5");
		NativeFieldInfoPtr_m_BlendState6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlendState>.NativeClassPtr, "m_BlendState6");
		NativeFieldInfoPtr_m_BlendState7 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlendState>.NativeClassPtr, "m_BlendState7");
		NativeFieldInfoPtr_m_SeparateMRTBlendStates = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlendState>.NativeClassPtr, "m_SeparateMRTBlendStates");
		NativeFieldInfoPtr_m_AlphaToMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlendState>.NativeClassPtr, "m_AlphaToMask");
		NativeFieldInfoPtr_m_Padding = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlendState>.NativeClassPtr, "m_Padding");
		NativeMethodInfoPtr_get_defaultValue_Public_Static_get_BlendState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlendState>.NativeClassPtr, 100668429);
		NativeMethodInfoPtr__ctor_Public_Void_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlendState>.NativeClassPtr, 100668430);
		NativeMethodInfoPtr_set_blendState0_Public_set_Void_RenderTargetBlendState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlendState>.NativeClassPtr, 100668431);
		NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_BlendState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlendState>.NativeClassPtr, 100668432);
		NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlendState>.NativeClassPtr, 100668433);
		NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlendState>.NativeClassPtr, 100668434);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1237894, RefRangeEnd = 1237896, XrefRangeStart = 1237889, XrefRangeEnd = 1237894, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe BlendState(bool separateMRTBlend = false, bool alphaToMask = false)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&separateMRTBlend);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &alphaToMask;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Boolean_Boolean_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1237901, RefRangeEnd = 1237903, XrefRangeStart = 1237896, XrefRangeEnd = 1237901, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual bool Equals(BlendState other)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&other);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_BlendState_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1237903, XrefRangeEnd = 1237907, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool Equals(Il2CppSystem.Object obj)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)obj);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1237953, RefRangeEnd = 1237954, XrefRangeStart = 1237907, XrefRangeEnd = 1237953, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BlendState>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}

	public static bool operator ==(BlendState left, BlendState right)
	{
		return left.Equals(right);
	}

	public static bool operator !=(BlendState left, BlendState right)
	{
		return !left.Equals(right);
	}
}
