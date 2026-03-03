using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;

namespace UnityEngine.Analytics;

[Serializable]
public class ShaderRuntimeInfoAnalytic : AnalyticsEventBase
{
	private static readonly IntPtr NativeFieldInfoPtr_VariantsRequested;

	private static readonly IntPtr NativeFieldInfoPtr_VariantsRequestedMissing;

	private static readonly IntPtr NativeFieldInfoPtr_VariantsRequestedUnsupported;

	private static readonly IntPtr NativeFieldInfoPtr_VariantsRequestedCompiled;

	private static readonly IntPtr NativeFieldInfoPtr_VariantsRequestedViaWarmup;

	private static readonly IntPtr NativeFieldInfoPtr_VariantsUnused;

	private static readonly IntPtr NativeFieldInfoPtr_VariantsCompilationTimeTotal;

	private static readonly IntPtr NativeFieldInfoPtr_VariantsCompilationTimeMax;

	private static readonly IntPtr NativeFieldInfoPtr_VariantsCompilationTimeMedian;

	private static readonly IntPtr NativeFieldInfoPtr_VariantsWarmupTimeTotal;

	private static readonly IntPtr NativeFieldInfoPtr_VariantsWarmupTimeMax;

	private static readonly IntPtr NativeFieldInfoPtr_VariantsWarmupTimeMedian;

	private static readonly IntPtr NativeFieldInfoPtr_UseProgressiveWarmup;

	private static readonly IntPtr NativeFieldInfoPtr_ShaderChunkSizeMin;

	private static readonly IntPtr NativeFieldInfoPtr_ShaderChunkSizeMax;

	private static readonly IntPtr NativeFieldInfoPtr_ShaderChunkSizeAvg;

	private static readonly IntPtr NativeFieldInfoPtr_ShaderChunkCountMin;

	private static readonly IntPtr NativeFieldInfoPtr_ShaderChunkCountMax;

	private static readonly IntPtr NativeFieldInfoPtr_ShaderChunkCountAvg;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_CreateShaderRuntimeInfoAnalytic_Public_Static_ShaderRuntimeInfoAnalytic_0;

	public unsafe long VariantsRequested
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_VariantsRequested);
			return *(long*)num;
		}
		set
		{
			*(long*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_VariantsRequested)) = value;
		}
	}

	public unsafe long VariantsRequestedMissing
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_VariantsRequestedMissing);
			return *(long*)num;
		}
		set
		{
			*(long*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_VariantsRequestedMissing)) = value;
		}
	}

	public unsafe long VariantsRequestedUnsupported
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_VariantsRequestedUnsupported);
			return *(long*)num;
		}
		set
		{
			*(long*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_VariantsRequestedUnsupported)) = value;
		}
	}

	public unsafe long VariantsRequestedCompiled
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_VariantsRequestedCompiled);
			return *(long*)num;
		}
		set
		{
			*(long*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_VariantsRequestedCompiled)) = value;
		}
	}

	public unsafe long VariantsRequestedViaWarmup
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_VariantsRequestedViaWarmup);
			return *(long*)num;
		}
		set
		{
			*(long*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_VariantsRequestedViaWarmup)) = value;
		}
	}

	public unsafe long VariantsUnused
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_VariantsUnused);
			return *(long*)num;
		}
		set
		{
			*(long*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_VariantsUnused)) = value;
		}
	}

	public unsafe int VariantsCompilationTimeTotal
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_VariantsCompilationTimeTotal);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_VariantsCompilationTimeTotal)) = value;
		}
	}

	public unsafe int VariantsCompilationTimeMax
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_VariantsCompilationTimeMax);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_VariantsCompilationTimeMax)) = value;
		}
	}

	public unsafe int VariantsCompilationTimeMedian
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_VariantsCompilationTimeMedian);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_VariantsCompilationTimeMedian)) = value;
		}
	}

	public unsafe int VariantsWarmupTimeTotal
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_VariantsWarmupTimeTotal);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_VariantsWarmupTimeTotal)) = value;
		}
	}

	public unsafe int VariantsWarmupTimeMax
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_VariantsWarmupTimeMax);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_VariantsWarmupTimeMax)) = value;
		}
	}

	public unsafe int VariantsWarmupTimeMedian
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_VariantsWarmupTimeMedian);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_VariantsWarmupTimeMedian)) = value;
		}
	}

	public unsafe bool UseProgressiveWarmup
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_UseProgressiveWarmup);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_UseProgressiveWarmup)) = value;
		}
	}

	public unsafe int ShaderChunkSizeMin
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ShaderChunkSizeMin);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ShaderChunkSizeMin)) = value;
		}
	}

	public unsafe int ShaderChunkSizeMax
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ShaderChunkSizeMax);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ShaderChunkSizeMax)) = value;
		}
	}

	public unsafe int ShaderChunkSizeAvg
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ShaderChunkSizeAvg);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ShaderChunkSizeAvg)) = value;
		}
	}

	public unsafe int ShaderChunkCountMin
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ShaderChunkCountMin);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ShaderChunkCountMin)) = value;
		}
	}

	public unsafe int ShaderChunkCountMax
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ShaderChunkCountMax);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ShaderChunkCountMax)) = value;
		}
	}

	public unsafe int ShaderChunkCountAvg
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ShaderChunkCountAvg);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ShaderChunkCountAvg)) = value;
		}
	}

	static ShaderRuntimeInfoAnalytic()
	{
		Il2CppClassPointerStore<ShaderRuntimeInfoAnalytic>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Analytics", "ShaderRuntimeInfoAnalytic");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShaderRuntimeInfoAnalytic>.NativeClassPtr);
		NativeFieldInfoPtr_VariantsRequested = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderRuntimeInfoAnalytic>.NativeClassPtr, "VariantsRequested");
		NativeFieldInfoPtr_VariantsRequestedMissing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderRuntimeInfoAnalytic>.NativeClassPtr, "VariantsRequestedMissing");
		NativeFieldInfoPtr_VariantsRequestedUnsupported = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderRuntimeInfoAnalytic>.NativeClassPtr, "VariantsRequestedUnsupported");
		NativeFieldInfoPtr_VariantsRequestedCompiled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderRuntimeInfoAnalytic>.NativeClassPtr, "VariantsRequestedCompiled");
		NativeFieldInfoPtr_VariantsRequestedViaWarmup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderRuntimeInfoAnalytic>.NativeClassPtr, "VariantsRequestedViaWarmup");
		NativeFieldInfoPtr_VariantsUnused = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderRuntimeInfoAnalytic>.NativeClassPtr, "VariantsUnused");
		NativeFieldInfoPtr_VariantsCompilationTimeTotal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderRuntimeInfoAnalytic>.NativeClassPtr, "VariantsCompilationTimeTotal");
		NativeFieldInfoPtr_VariantsCompilationTimeMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderRuntimeInfoAnalytic>.NativeClassPtr, "VariantsCompilationTimeMax");
		NativeFieldInfoPtr_VariantsCompilationTimeMedian = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderRuntimeInfoAnalytic>.NativeClassPtr, "VariantsCompilationTimeMedian");
		NativeFieldInfoPtr_VariantsWarmupTimeTotal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderRuntimeInfoAnalytic>.NativeClassPtr, "VariantsWarmupTimeTotal");
		NativeFieldInfoPtr_VariantsWarmupTimeMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderRuntimeInfoAnalytic>.NativeClassPtr, "VariantsWarmupTimeMax");
		NativeFieldInfoPtr_VariantsWarmupTimeMedian = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderRuntimeInfoAnalytic>.NativeClassPtr, "VariantsWarmupTimeMedian");
		NativeFieldInfoPtr_UseProgressiveWarmup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderRuntimeInfoAnalytic>.NativeClassPtr, "UseProgressiveWarmup");
		NativeFieldInfoPtr_ShaderChunkSizeMin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderRuntimeInfoAnalytic>.NativeClassPtr, "ShaderChunkSizeMin");
		NativeFieldInfoPtr_ShaderChunkSizeMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderRuntimeInfoAnalytic>.NativeClassPtr, "ShaderChunkSizeMax");
		NativeFieldInfoPtr_ShaderChunkSizeAvg = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderRuntimeInfoAnalytic>.NativeClassPtr, "ShaderChunkSizeAvg");
		NativeFieldInfoPtr_ShaderChunkCountMin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderRuntimeInfoAnalytic>.NativeClassPtr, "ShaderChunkCountMin");
		NativeFieldInfoPtr_ShaderChunkCountMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderRuntimeInfoAnalytic>.NativeClassPtr, "ShaderChunkCountMax");
		NativeFieldInfoPtr_ShaderChunkCountAvg = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderRuntimeInfoAnalytic>.NativeClassPtr, "ShaderChunkCountAvg");
		NativeMethodInfoPtr__ctor_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShaderRuntimeInfoAnalytic>.NativeClassPtr, 100667630);
		NativeMethodInfoPtr_CreateShaderRuntimeInfoAnalytic_Public_Static_ShaderRuntimeInfoAnalytic_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShaderRuntimeInfoAnalytic>.NativeClassPtr, 100667631);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1231682, XrefRangeEnd = 1231689, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ShaderRuntimeInfoAnalytic()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShaderRuntimeInfoAnalytic>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1231689, XrefRangeEnd = 1231699, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static ShaderRuntimeInfoAnalytic CreateShaderRuntimeInfoAnalytic()
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateShaderRuntimeInfoAnalytic_Public_Static_ShaderRuntimeInfoAnalytic_0, (IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (IntPtr)0) ? Il2CppObjectPool.Get<ShaderRuntimeInfoAnalytic>(intPtr2) : null;
	}

	public ShaderRuntimeInfoAnalytic(IntPtr pointer)
		: base(pointer)
	{
	}
}
