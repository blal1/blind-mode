using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;

namespace UnityEngine.TextCore.Text;

[StructLayout(LayoutKind.Explicit)]
public struct Offset
{
	private static readonly System.IntPtr NativeFieldInfoPtr_m_Left;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_Right;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_Top;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_Bottom;

	private static readonly System.IntPtr NativeFieldInfoPtr_k_ZeroOffset;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_left_Public_get_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_right_Public_get_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_top_Public_get_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_bottom_Public_get_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_zero_Public_Static_get_Offset_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Single_Single_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_Offset_Offset_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_op_Multiply_Public_Static_Offset_Offset_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

	[FieldOffset(0)]
	public float m_Left;

	[FieldOffset(4)]
	public float m_Right;

	[FieldOffset(8)]
	public float m_Top;

	[FieldOffset(12)]
	public float m_Bottom;

	public unsafe static Offset k_ZeroOffset
	{
		get
		{
			Unsafe.SkipInit(out Offset result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_k_ZeroOffset, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_k_ZeroOffset, (void*)(&value));
		}
	}

	public unsafe float left
	{
		[CallerCount(79)]
		[CachedScanResults(RefRangeStart = 1167165, RefRangeEnd = 1167244, XrefRangeStart = 1167165, XrefRangeEnd = 1167244, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_left_Public_get_Single_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		set
		{
			m_Left = value;
		}
	}

	public unsafe float right
	{
		[CallerCount(90)]
		[CachedScanResults(RefRangeStart = 1153785, RefRangeEnd = 1153875, XrefRangeStart = 1153785, XrefRangeEnd = 1153875, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_right_Public_get_Single_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		set
		{
			m_Right = value;
		}
	}

	public unsafe float top
	{
		[CallerCount(46)]
		[CachedScanResults(RefRangeStart = 1161205, RefRangeEnd = 1161251, XrefRangeStart = 1161205, XrefRangeEnd = 1161251, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_top_Public_get_Single_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		set
		{
			m_Top = value;
		}
	}

	public unsafe float bottom
	{
		[CallerCount(40)]
		[CachedScanResults(RefRangeStart = 1154246, RefRangeEnd = 1154286, XrefRangeStart = 1154246, XrefRangeEnd = 1154286, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_bottom_Public_get_Single_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		set
		{
			m_Bottom = value;
		}
	}

	public unsafe static Offset zero
	{
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1282523, RefRangeEnd = 1282526, XrefRangeStart = 1282519, XrefRangeEnd = 1282523, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_zero_Public_Static_get_Offset_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(Offset*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	static Offset()
	{
		Il2CppClassPointerStore<Offset>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.TextCoreTextEngineModule.dll", "UnityEngine.TextCore.Text", "Offset");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Offset>.NativeClassPtr);
		NativeFieldInfoPtr_m_Left = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Offset>.NativeClassPtr, "m_Left");
		NativeFieldInfoPtr_m_Right = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Offset>.NativeClassPtr, "m_Right");
		NativeFieldInfoPtr_m_Top = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Offset>.NativeClassPtr, "m_Top");
		NativeFieldInfoPtr_m_Bottom = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Offset>.NativeClassPtr, "m_Bottom");
		NativeFieldInfoPtr_k_ZeroOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Offset>.NativeClassPtr, "k_ZeroOffset");
		NativeMethodInfoPtr_get_left_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Offset>.NativeClassPtr, 100663800);
		NativeMethodInfoPtr_get_right_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Offset>.NativeClassPtr, 100663801);
		NativeMethodInfoPtr_get_top_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Offset>.NativeClassPtr, 100663802);
		NativeMethodInfoPtr_get_bottom_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Offset>.NativeClassPtr, 100663803);
		NativeMethodInfoPtr_get_zero_Public_Static_get_Offset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Offset>.NativeClassPtr, 100663804);
		NativeMethodInfoPtr__ctor_Public_Void_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Offset>.NativeClassPtr, 100663805);
		NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_Offset_Offset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Offset>.NativeClassPtr, 100663806);
		NativeMethodInfoPtr_op_Multiply_Public_Static_Offset_Offset_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Offset>.NativeClassPtr, 100663807);
		NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Offset>.NativeClassPtr, 100663808);
		NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Offset>.NativeClassPtr, 100663809);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 1023627, RefRangeEnd = 1023632, XrefRangeStart = 1023627, XrefRangeEnd = 1023632, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Offset(float left, float right, float top, float bottom)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&left);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &right;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &top;
		*(float**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &bottom;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Single_Single_Single_Single_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	public unsafe static bool operator ==(Offset lhs, Offset rhs)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&lhs);
		*(Offset**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &rhs;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_Offset_Offset_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe static Offset operator *(Offset a, float b)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&a);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &b;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_op_Multiply_Public_Static_Offset_Offset_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(Offset*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1282526, XrefRangeEnd = 1282530, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override int GetHashCode()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1282530, XrefRangeEnd = 1282534, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool Equals(Il2CppSystem.Object obj)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)obj);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Offset>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}

	public static bool operator !=(Offset lhs, Offset rhs)
	{
		return !(lhs == rhs);
	}

	public bool Equals(Offset other)
	{
		return ((Il2CppSystem.ValueType)(object)this).Equals((Il2CppSystem.Object)(object)other);
	}
}
