using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine.Animations;
using UnityEngine.Playables;

namespace UnityEngine.Timeline;

public class AnimationOutputWeightProcessor : Il2CppSystem.Object
{
	[StructLayout(LayoutKind.Explicit)]
	public struct WeightInfo
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_mixer;

		private static readonly System.IntPtr NativeFieldInfoPtr_parentMixer;

		private static readonly System.IntPtr NativeFieldInfoPtr_port;

		[FieldOffset(0)]
		public Playable mixer;

		[FieldOffset(16)]
		public Playable parentMixer;

		[FieldOffset(32)]
		public int port;

		static WeightInfo()
		{
			Il2CppClassPointerStore<WeightInfo>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AnimationOutputWeightProcessor>.NativeClassPtr, "WeightInfo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WeightInfo>.NativeClassPtr);
			NativeFieldInfoPtr_mixer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeightInfo>.NativeClassPtr, "mixer");
			NativeFieldInfoPtr_parentMixer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeightInfo>.NativeClassPtr, "parentMixer");
			NativeFieldInfoPtr_port = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeightInfo>.NativeClassPtr, "port");
		}

		public unsafe Il2CppSystem.Object BoxIl2CppObject()
		{
			return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<WeightInfo>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
		}
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_m_Output;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_MotionXPlayable;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_Mixers;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_AnimationPlayableOutput_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FindMixers_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FindMixers_Private_Void_Playable_Int32_Playable_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Evaluate_Public_Virtual_Final_New_Void_0;

	public unsafe AnimationPlayableOutput m_Output
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Output);
			return *(AnimationPlayableOutput*)num;
		}
		set
		{
			*(AnimationPlayableOutput*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Output)) = value;
		}
	}

	public unsafe AnimationMotionXToDeltaPlayable m_MotionXPlayable
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_MotionXPlayable);
			return *(AnimationMotionXToDeltaPlayable*)num;
		}
		set
		{
			*(AnimationMotionXToDeltaPlayable*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_MotionXPlayable)) = value;
		}
	}

	public unsafe List<WeightInfo> m_Mixers
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Mixers);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<WeightInfo>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Mixers)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	static AnimationOutputWeightProcessor()
	{
		Il2CppClassPointerStore<AnimationOutputWeightProcessor>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Timeline.dll", "UnityEngine.Timeline", "AnimationOutputWeightProcessor");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AnimationOutputWeightProcessor>.NativeClassPtr);
		NativeFieldInfoPtr_m_Output = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationOutputWeightProcessor>.NativeClassPtr, "m_Output");
		NativeFieldInfoPtr_m_MotionXPlayable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationOutputWeightProcessor>.NativeClassPtr, "m_MotionXPlayable");
		NativeFieldInfoPtr_m_Mixers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationOutputWeightProcessor>.NativeClassPtr, "m_Mixers");
		NativeMethodInfoPtr__ctor_Public_Void_AnimationPlayableOutput_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationOutputWeightProcessor>.NativeClassPtr, 100663316);
		NativeMethodInfoPtr_FindMixers_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationOutputWeightProcessor>.NativeClassPtr, 100663317);
		NativeMethodInfoPtr_FindMixers_Private_Void_Playable_Int32_Playable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationOutputWeightProcessor>.NativeClassPtr, 100663318);
		NativeMethodInfoPtr_Evaluate_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationOutputWeightProcessor>.NativeClassPtr, 100663319);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1135258, RefRangeEnd = 1135259, XrefRangeStart = 1135236, XrefRangeEnd = 1135258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe AnimationOutputWeightProcessor(AnimationPlayableOutput output)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AnimationOutputWeightProcessor>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&output);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_AnimationPlayableOutput_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1135259, XrefRangeEnd = 1135270, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void FindMixers()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FindMixers_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 1135297, RefRangeEnd = 1135300, XrefRangeStart = 1135270, XrefRangeEnd = 1135297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void FindMixers(Playable parent, int port, Playable node)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&parent);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &port;
		*(Playable**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &node;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FindMixers_Private_Void_Playable_Int32_Playable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1135300, XrefRangeEnd = 1135318, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void Evaluate()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Evaluate_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public AnimationOutputWeightProcessor(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
