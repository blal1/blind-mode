using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;

namespace UnityEngine.Rendering;

[StructLayout(LayoutKind.Explicit)]
public struct RenderQueueRange
{
	private static readonly System.IntPtr NativeFieldInfoPtr_m_LowerBound;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_UpperBound;

	private static readonly System.IntPtr NativeFieldInfoPtr_k_MinimumBound;

	private static readonly System.IntPtr NativeFieldInfoPtr_minimumBound;

	private static readonly System.IntPtr NativeFieldInfoPtr_k_MaximumBound;

	private static readonly System.IntPtr NativeFieldInfoPtr_maximumBound;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_all_Public_Static_get_RenderQueueRange_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_opaque_Public_Static_get_RenderQueueRange_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_transparent_Public_Static_get_RenderQueueRange_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_lowerBound_Public_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_upperBound_Public_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_RenderQueueRange_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_RenderQueueRange_RenderQueueRange_0;

	[FieldOffset(0)]
	public int m_LowerBound;

	[FieldOffset(4)]
	public int m_UpperBound;

	public unsafe static int k_MinimumBound
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_k_MinimumBound, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_k_MinimumBound, (void*)(&value));
		}
	}

	public unsafe static int minimumBound
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_minimumBound, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_minimumBound, (void*)(&value));
		}
	}

	public unsafe static int k_MaximumBound
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_k_MaximumBound, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_k_MaximumBound, (void*)(&value));
		}
	}

	public unsafe static int maximumBound
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_maximumBound, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_maximumBound, (void*)(&value));
		}
	}

	public unsafe static RenderQueueRange all
	{
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1239070, RefRangeEnd = 1239072, XrefRangeStart = 1239070, XrefRangeEnd = 1239070, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_all_Public_Static_get_RenderQueueRange_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(RenderQueueRange*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe static RenderQueueRange opaque
	{
		[CallerCount(15)]
		[CachedScanResults(RefRangeStart = 1239072, RefRangeEnd = 1239087, XrefRangeStart = 1239072, XrefRangeEnd = 1239072, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_opaque_Public_Static_get_RenderQueueRange_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(RenderQueueRange*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe static RenderQueueRange transparent
	{
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1239087, RefRangeEnd = 1239090, XrefRangeStart = 1239087, XrefRangeEnd = 1239087, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_transparent_Public_Static_get_RenderQueueRange_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(RenderQueueRange*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe int lowerBound
	{
		[CallerCount(256)]
		[CachedScanResults(RefRangeStart = 1153990, RefRangeEnd = 1154246, XrefRangeStart = 1153990, XrefRangeEnd = 1154246, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_lowerBound_Public_get_Int32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		set
		{
			if (value < 0 || value > 5000)
			{
				throw new Il2CppSystem.ArgumentOutOfRangeException(Il2CppSystem.String.Format("The lower bound must be at least {0} and at most {1}.", (Il2CppSystem.Object)(object)0, (Il2CppSystem.Object)(object)5000));
			}
			m_LowerBound = value;
		}
	}

	public unsafe int upperBound
	{
		[CallerCount(54)]
		[CachedScanResults(RefRangeStart = 1153936, RefRangeEnd = 1153990, XrefRangeStart = 1153936, XrefRangeEnd = 1153990, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_upperBound_Public_get_Int32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		set
		{
			if (value < 0 || value > 5000)
			{
				throw new Il2CppSystem.ArgumentOutOfRangeException(Il2CppSystem.String.Format("The upper bound must be at least {0} and at most {1}.", (Il2CppSystem.Object)(object)0, (Il2CppSystem.Object)(object)5000));
			}
			m_UpperBound = value;
		}
	}

	static RenderQueueRange()
	{
		Il2CppClassPointerStore<RenderQueueRange>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Rendering", "RenderQueueRange");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RenderQueueRange>.NativeClassPtr);
		NativeFieldInfoPtr_m_LowerBound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderQueueRange>.NativeClassPtr, "m_LowerBound");
		NativeFieldInfoPtr_m_UpperBound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderQueueRange>.NativeClassPtr, "m_UpperBound");
		NativeFieldInfoPtr_k_MinimumBound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderQueueRange>.NativeClassPtr, "k_MinimumBound");
		NativeFieldInfoPtr_minimumBound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderQueueRange>.NativeClassPtr, "minimumBound");
		NativeFieldInfoPtr_k_MaximumBound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderQueueRange>.NativeClassPtr, "k_MaximumBound");
		NativeFieldInfoPtr_maximumBound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderQueueRange>.NativeClassPtr, "maximumBound");
		NativeMethodInfoPtr_get_all_Public_Static_get_RenderQueueRange_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderQueueRange>.NativeClassPtr, 100668629);
		NativeMethodInfoPtr_get_opaque_Public_Static_get_RenderQueueRange_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderQueueRange>.NativeClassPtr, 100668630);
		NativeMethodInfoPtr_get_transparent_Public_Static_get_RenderQueueRange_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderQueueRange>.NativeClassPtr, 100668631);
		NativeMethodInfoPtr_get_lowerBound_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderQueueRange>.NativeClassPtr, 100668632);
		NativeMethodInfoPtr_get_upperBound_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderQueueRange>.NativeClassPtr, 100668633);
		NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_RenderQueueRange_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderQueueRange>.NativeClassPtr, 100668634);
		NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderQueueRange>.NativeClassPtr, 100668635);
		NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderQueueRange>.NativeClassPtr, 100668636);
		NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_RenderQueueRange_RenderQueueRange_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderQueueRange>.NativeClassPtr, 100668637);
	}

	[CallerCount(0)]
	public unsafe virtual bool Equals(RenderQueueRange other)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&other);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_RenderQueueRange_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1239090, XrefRangeEnd = 1239095, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool Equals(Il2CppSystem.Object obj)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)obj);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe override int GetHashCode()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 1239098, RefRangeEnd = 1239102, XrefRangeStart = 1239095, XrefRangeEnd = 1239098, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool operator ==(RenderQueueRange left, RenderQueueRange right)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&left);
		*(RenderQueueRange**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &right;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_RenderQueueRange_RenderQueueRange_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RenderQueueRange>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}

	public static bool operator !=(RenderQueueRange left, RenderQueueRange right)
	{
		return !left.Equals(right);
	}
}
