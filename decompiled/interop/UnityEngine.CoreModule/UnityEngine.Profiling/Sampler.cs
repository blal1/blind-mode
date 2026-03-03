using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Unity.Profiling.LowLevel.Unsafe;

namespace UnityEngine.Profiling;

public class Sampler : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_m_Ptr;

	private static readonly System.IntPtr NativeFieldInfoPtr_s_InvalidSampler;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Internal_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_isValid_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetRecorder_Public_Recorder_0;

	public unsafe System.IntPtr m_Ptr
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Ptr);
			return *(System.IntPtr*)num;
		}
		set
		{
			*(System.IntPtr*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Ptr)) = value;
		}
	}

	public unsafe static Sampler s_InvalidSampler
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_InvalidSampler, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Sampler>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_InvalidSampler, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe bool isValid
	{
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1184679, RefRangeEnd = 1184681, XrefRangeStart = 1184679, XrefRangeEnd = 1184681, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_isValid_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public string name => ProfilerUnsafeUtility.Internal_GetName(m_Ptr);

	static Sampler()
	{
		Il2CppClassPointerStore<Sampler>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Profiling", "Sampler");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Sampler>.NativeClassPtr);
		NativeFieldInfoPtr_m_Ptr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sampler>.NativeClassPtr, "m_Ptr");
		NativeFieldInfoPtr_s_InvalidSampler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sampler>.NativeClassPtr, "s_InvalidSampler");
		NativeMethodInfoPtr__ctor_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sampler>.NativeClassPtr, 100666963);
		NativeMethodInfoPtr_get_isValid_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sampler>.NativeClassPtr, 100666965);
		NativeMethodInfoPtr_GetRecorder_Public_Recorder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sampler>.NativeClassPtr, 100666966);
	}

	[CallerCount(1950)]
	[CachedScanResults(RefRangeStart = 20036, RefRangeEnd = 21986, XrefRangeStart = 20036, XrefRangeEnd = 21986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Sampler()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Sampler>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 1222010, RefRangeEnd = 1222014, XrefRangeStart = 1222000, XrefRangeEnd = 1222010, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Recorder GetRecorder()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetRecorder_Public_Recorder_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Recorder>(intPtr2) : null;
	}

	public Sampler(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public static Sampler Get(string name)
	{
		System.IntPtr marker = ProfilerUnsafeUtility.GetMarker(name);
		if (marker == Il2CppSystem.IntPtr.Zero)
		{
			return s_InvalidSampler;
		}
		return new Sampler(marker);
	}

	public unsafe static int GetNames(List<string> names)
	{
		//IL_00af: Expected O, but got Ref
		//IL_009e: Expected O, but got Ref
		//IL_0077: Expected O, but got Ref
		List<ProfilerRecorderHandle> list = new List<ProfilerRecorderHandle>();
		ProfilerRecorderHandle.GetAvailable(list);
		if (names != null)
		{
			if (names.Count < list.Count)
			{
				names.Capacity = list.Count;
				for (int i = names.Count; i < list.Count; i++)
				{
					names.Add(null);
				}
			}
			int num = 0;
			List<ProfilerRecorderHandle>.Enumerator enumerator = list.GetEnumerator();
			try
			{
				while (((List<ProfilerRecorderHandle>.Enumerator)(&enumerator)).MoveNext())
				{
					ProfilerRecorderHandle current = ((List<ProfilerRecorderHandle>.Enumerator)(&enumerator)).Current;
					names[num] = ProfilerRecorderHandle.GetDescription(current).Name;
					num++;
				}
			}
			finally
			{
				((Il2CppSystem.IDisposable)(object)(List<ProfilerRecorderHandle>.Enumerator)(&enumerator)).Dispose();
			}
		}
		return list.Count;
	}
}
