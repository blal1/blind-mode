using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;

namespace Unity.IntegerTime;

[System.Serializable]
[StructLayout(LayoutKind.Explicit)]
public struct RationalTime
{
	[System.Serializable]
	[StructLayout(LayoutKind.Explicit)]
	public struct TicksPerSecond
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_m_Numerator;

		private static readonly System.IntPtr NativeFieldInfoPtr_m_Denominator;

		private static readonly System.IntPtr NativeFieldInfoPtr_DefaultTicksPerSecond;

		private static readonly System.IntPtr NativeFieldInfoPtr_TicksPerSecond24;

		private static readonly System.IntPtr NativeFieldInfoPtr_TicksPerSecond25;

		private static readonly System.IntPtr NativeFieldInfoPtr_TicksPerSecond30;

		private static readonly System.IntPtr NativeFieldInfoPtr_TicksPerSecond50;

		private static readonly System.IntPtr NativeFieldInfoPtr_TicksPerSecond60;

		private static readonly System.IntPtr NativeFieldInfoPtr_TicksPerSecond120;

		private static readonly System.IntPtr NativeFieldInfoPtr_TicksPerSecond2397;

		private static readonly System.IntPtr NativeFieldInfoPtr_TicksPerSecond2425;

		private static readonly System.IntPtr NativeFieldInfoPtr_TicksPerSecond2997;

		private static readonly System.IntPtr NativeFieldInfoPtr_TicksPerSecond5994;

		private static readonly System.IntPtr NativeFieldInfoPtr_TicksPerSecond11988;

		private static readonly System.IntPtr NativeFieldInfoPtr_DiscreteTimeRate;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_UInt32_UInt32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_TicksPerSecond_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_Simplify_Private_Static_Void_byref_UInt32_byref_UInt32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_Gcd_Private_Static_UInt32_UInt32_UInt32_0;

		[FieldOffset(0)]
		public uint m_Numerator;

		[FieldOffset(4)]
		public uint m_Denominator;

		public unsafe static TicksPerSecond DefaultTicksPerSecond
		{
			get
			{
				Unsafe.SkipInit(out TicksPerSecond result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_DefaultTicksPerSecond, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_DefaultTicksPerSecond, (void*)(&value));
			}
		}

		public unsafe static TicksPerSecond TicksPerSecond24
		{
			get
			{
				Unsafe.SkipInit(out TicksPerSecond result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_TicksPerSecond24, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_TicksPerSecond24, (void*)(&value));
			}
		}

		public unsafe static TicksPerSecond TicksPerSecond25
		{
			get
			{
				Unsafe.SkipInit(out TicksPerSecond result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_TicksPerSecond25, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_TicksPerSecond25, (void*)(&value));
			}
		}

		public unsafe static TicksPerSecond TicksPerSecond30
		{
			get
			{
				Unsafe.SkipInit(out TicksPerSecond result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_TicksPerSecond30, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_TicksPerSecond30, (void*)(&value));
			}
		}

		public unsafe static TicksPerSecond TicksPerSecond50
		{
			get
			{
				Unsafe.SkipInit(out TicksPerSecond result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_TicksPerSecond50, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_TicksPerSecond50, (void*)(&value));
			}
		}

		public unsafe static TicksPerSecond TicksPerSecond60
		{
			get
			{
				Unsafe.SkipInit(out TicksPerSecond result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_TicksPerSecond60, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_TicksPerSecond60, (void*)(&value));
			}
		}

		public unsafe static TicksPerSecond TicksPerSecond120
		{
			get
			{
				Unsafe.SkipInit(out TicksPerSecond result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_TicksPerSecond120, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_TicksPerSecond120, (void*)(&value));
			}
		}

		public unsafe static TicksPerSecond TicksPerSecond2397
		{
			get
			{
				Unsafe.SkipInit(out TicksPerSecond result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_TicksPerSecond2397, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_TicksPerSecond2397, (void*)(&value));
			}
		}

		public unsafe static TicksPerSecond TicksPerSecond2425
		{
			get
			{
				Unsafe.SkipInit(out TicksPerSecond result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_TicksPerSecond2425, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_TicksPerSecond2425, (void*)(&value));
			}
		}

		public unsafe static TicksPerSecond TicksPerSecond2997
		{
			get
			{
				Unsafe.SkipInit(out TicksPerSecond result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_TicksPerSecond2997, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_TicksPerSecond2997, (void*)(&value));
			}
		}

		public unsafe static TicksPerSecond TicksPerSecond5994
		{
			get
			{
				Unsafe.SkipInit(out TicksPerSecond result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_TicksPerSecond5994, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_TicksPerSecond5994, (void*)(&value));
			}
		}

		public unsafe static TicksPerSecond TicksPerSecond11988
		{
			get
			{
				Unsafe.SkipInit(out TicksPerSecond result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_TicksPerSecond11988, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_TicksPerSecond11988, (void*)(&value));
			}
		}

		public unsafe static TicksPerSecond DiscreteTimeRate
		{
			get
			{
				Unsafe.SkipInit(out TicksPerSecond result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_DiscreteTimeRate, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_DiscreteTimeRate, (void*)(&value));
			}
		}

		static TicksPerSecond()
		{
			Il2CppClassPointerStore<TicksPerSecond>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RationalTime>.NativeClassPtr, "TicksPerSecond");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TicksPerSecond>.NativeClassPtr);
			NativeFieldInfoPtr_m_Numerator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TicksPerSecond>.NativeClassPtr, "m_Numerator");
			NativeFieldInfoPtr_m_Denominator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TicksPerSecond>.NativeClassPtr, "m_Denominator");
			NativeFieldInfoPtr_DefaultTicksPerSecond = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TicksPerSecond>.NativeClassPtr, "DefaultTicksPerSecond");
			NativeFieldInfoPtr_TicksPerSecond24 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TicksPerSecond>.NativeClassPtr, "TicksPerSecond24");
			NativeFieldInfoPtr_TicksPerSecond25 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TicksPerSecond>.NativeClassPtr, "TicksPerSecond25");
			NativeFieldInfoPtr_TicksPerSecond30 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TicksPerSecond>.NativeClassPtr, "TicksPerSecond30");
			NativeFieldInfoPtr_TicksPerSecond50 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TicksPerSecond>.NativeClassPtr, "TicksPerSecond50");
			NativeFieldInfoPtr_TicksPerSecond60 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TicksPerSecond>.NativeClassPtr, "TicksPerSecond60");
			NativeFieldInfoPtr_TicksPerSecond120 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TicksPerSecond>.NativeClassPtr, "TicksPerSecond120");
			NativeFieldInfoPtr_TicksPerSecond2397 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TicksPerSecond>.NativeClassPtr, "TicksPerSecond2397");
			NativeFieldInfoPtr_TicksPerSecond2425 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TicksPerSecond>.NativeClassPtr, "TicksPerSecond2425");
			NativeFieldInfoPtr_TicksPerSecond2997 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TicksPerSecond>.NativeClassPtr, "TicksPerSecond2997");
			NativeFieldInfoPtr_TicksPerSecond5994 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TicksPerSecond>.NativeClassPtr, "TicksPerSecond5994");
			NativeFieldInfoPtr_TicksPerSecond11988 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TicksPerSecond>.NativeClassPtr, "TicksPerSecond11988");
			NativeFieldInfoPtr_DiscreteTimeRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TicksPerSecond>.NativeClassPtr, "DiscreteTimeRate");
			NativeMethodInfoPtr__ctor_Public_Void_UInt32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TicksPerSecond>.NativeClassPtr, 100663393);
			NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_TicksPerSecond_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TicksPerSecond>.NativeClassPtr, 100663394);
			NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TicksPerSecond>.NativeClassPtr, 100663395);
			NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TicksPerSecond>.NativeClassPtr, 100663396);
			NativeMethodInfoPtr_Simplify_Private_Static_Void_byref_UInt32_byref_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TicksPerSecond>.NativeClassPtr, 100663397);
			NativeMethodInfoPtr_Gcd_Private_Static_UInt32_UInt32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TicksPerSecond>.NativeClassPtr, 100663398);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1164459, XrefRangeEnd = 1164465, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TicksPerSecond(uint num, uint den = 1u)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = (nint)(&num);
			*(uint**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &den;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_UInt32_UInt32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(0)]
		public unsafe virtual bool Equals(TicksPerSecond rhs)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&rhs);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_TicksPerSecond_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1164465, XrefRangeEnd = 1164470, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Equals(Il2CppSystem.Object rhs)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)rhs);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1164470, XrefRangeEnd = 1164476, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1164476, XrefRangeEnd = 1164479, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Simplify(ref uint num, ref uint den)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = (nint)Unsafe.AsPointer(ref num);
			*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref den);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Simplify_Private_Static_Void_byref_UInt32_byref_UInt32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(0)]
		public unsafe static uint Gcd(uint a, uint b)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = (nint)(&a);
			*(uint**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &b;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Gcd_Private_Static_UInt32_UInt32_UInt32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(uint*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		public unsafe Il2CppSystem.Object BoxIl2CppObject()
		{
			return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TicksPerSecond>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
		}
	}

	private delegate void FromDouble_InjectedDelegate(double t, [In] System.IntPtr ticksPerSecond, [Out] System.IntPtr ret);

	private static readonly System.IntPtr NativeFieldInfoPtr_m_Count;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_TicksPerSecond;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_Count_Public_get_Int64_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_DiscreteTime_RationalTime_0;

	[FieldOffset(0)]
	public long m_Count;

	[FieldOffset(8)]
	public TicksPerSecond m_TicksPerSecond;

	private static readonly FromDouble_InjectedDelegate FromDouble_InjectedDelegateField;

	public unsafe long Count
	{
		[CallerCount(98)]
		[CachedScanResults(RefRangeStart = 110111, RefRangeEnd = 110209, XrefRangeStart = 110111, XrefRangeEnd = 110209, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Count_Public_get_Int64_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(long*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public TicksPerSecond Ticks => m_TicksPerSecond;

	static RationalTime()
	{
		Il2CppClassPointerStore<RationalTime>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "Unity.IntegerTime", "RationalTime");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RationalTime>.NativeClassPtr);
		NativeFieldInfoPtr_m_Count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RationalTime>.NativeClassPtr, "m_Count");
		NativeFieldInfoPtr_m_TicksPerSecond = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RationalTime>.NativeClassPtr, "m_TicksPerSecond");
		NativeMethodInfoPtr_get_Count_Public_get_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RationalTime>.NativeClassPtr, 100663391);
		NativeMethodInfoPtr_op_Explicit_Public_Static_DiscreteTime_RationalTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RationalTime>.NativeClassPtr, 100663392);
		FromDouble_InjectedDelegateField = IL2CPP.ResolveICall<FromDouble_InjectedDelegate>("Unity.IntegerTime.RationalTime::FromDouble_Injected");
	}

	[CallerCount(14)]
	[CachedScanResults(RefRangeStart = 1164488, RefRangeEnd = 1164502, XrefRangeStart = 1164479, XrefRangeEnd = 1164488, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static explicit operator DiscreteTime(RationalTime t)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&t);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_op_Explicit_Public_Static_DiscreteTime_RationalTime_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(DiscreteTime*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RationalTime>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}

	public static RationalTime FromDouble(double t, TicksPerSecond ticksPerSecond)
	{
		FromDouble_Injected(t, ref ticksPerSecond, out var ret);
		return ret;
	}

	public unsafe static void FromDouble_Injected(double t, [In] ref TicksPerSecond ticksPerSecond, out RationalTime ret)
	{
		FromDouble_InjectedDelegateField(t, (nint)Unsafe.AsPointer(ref ticksPerSecond), (nint)Unsafe.AsPointer(ref ret));
	}
}
