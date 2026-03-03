using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;
using Il2CppSystem.Runtime.InteropServices;
using Unity.Profiling;
using UnityEngine.InputSystem.LowLevel;
using UnityEngine.InputSystem.Utilities;

namespace UnityEngine.InputSystem;

public class InputActionState : Il2CppSystem.Object
{
	[StructLayout(LayoutKind.Explicit)]
	public struct InteractionState
	{
		[OriginalName("Unity.InputSystem.dll", "", "Flags")]
		[System.Flags]
		public enum Flags
		{
			TimerRunning = 1
		}

		private static readonly System.IntPtr NativeFieldInfoPtr_m_TriggerControlIndex;

		private static readonly System.IntPtr NativeFieldInfoPtr_m_Phase;

		private static readonly System.IntPtr NativeFieldInfoPtr_m_Flags;

		private static readonly System.IntPtr NativeFieldInfoPtr_m_TimerDuration;

		private static readonly System.IntPtr NativeFieldInfoPtr_m_StartTime;

		private static readonly System.IntPtr NativeFieldInfoPtr_m_TimerStartTime;

		private static readonly System.IntPtr NativeFieldInfoPtr_m_PerformedTime;

		private static readonly System.IntPtr NativeFieldInfoPtr_m_TotalTimeoutCompletionTimeDone;

		private static readonly System.IntPtr NativeFieldInfoPtr_m_TotalTimeoutCompletionTimeRemaining;

		private static readonly System.IntPtr NativeFieldInfoPtr_m_TimerMonitorIndex;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_triggerControlIndex_Public_get_Int32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_set_triggerControlIndex_Public_set_Void_Int32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_startTime_Public_get_Double_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_set_startTime_Public_set_Void_Double_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_performedTime_Public_get_Double_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_set_performedTime_Public_set_Void_Double_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_timerStartTime_Public_get_Double_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_set_timerStartTime_Public_set_Void_Double_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_timerDuration_Public_get_Single_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_set_timerDuration_Public_set_Void_Single_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_totalTimeoutCompletionDone_Public_get_Single_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_set_totalTimeoutCompletionDone_Public_set_Void_Single_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_totalTimeoutCompletionTimeRemaining_Public_get_Single_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_set_totalTimeoutCompletionTimeRemaining_Public_set_Void_Single_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_timerMonitorIndex_Public_get_Int64_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_set_timerMonitorIndex_Public_set_Void_Int64_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_isTimerRunning_Public_get_Boolean_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_set_isTimerRunning_Public_set_Void_Boolean_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_phase_Public_get_InputActionPhase_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_set_phase_Public_set_Void_InputActionPhase_0;

		[System.Runtime.InteropServices.FieldOffset(0)]
		public ushort m_TriggerControlIndex;

		[System.Runtime.InteropServices.FieldOffset(2)]
		public byte m_Phase;

		[System.Runtime.InteropServices.FieldOffset(3)]
		public byte m_Flags;

		[System.Runtime.InteropServices.FieldOffset(4)]
		public float m_TimerDuration;

		[System.Runtime.InteropServices.FieldOffset(8)]
		public double m_StartTime;

		[System.Runtime.InteropServices.FieldOffset(16)]
		public double m_TimerStartTime;

		[System.Runtime.InteropServices.FieldOffset(24)]
		public double m_PerformedTime;

		[System.Runtime.InteropServices.FieldOffset(32)]
		public float m_TotalTimeoutCompletionTimeDone;

		[System.Runtime.InteropServices.FieldOffset(36)]
		public float m_TotalTimeoutCompletionTimeRemaining;

		[System.Runtime.InteropServices.FieldOffset(40)]
		public long m_TimerMonitorIndex;

		public unsafe int triggerControlIndex
		{
			[CallerCount(0)]
			get
			{
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_triggerControlIndex_Public_get_Int32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 968552, RefRangeEnd = 968555, XrefRangeStart = 968552, XrefRangeEnd = 968552, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				System.IntPtr* ptr = stackalloc System.IntPtr[1];
				*ptr = (nint)(&value);
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_triggerControlIndex_Public_set_Void_Int32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
			}
		}

		public unsafe double startTime
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 968555, RefRangeEnd = 968557, XrefRangeStart = 968555, XrefRangeEnd = 968555, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_startTime_Public_get_Double_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return *(double*)IL2CPP.il2cpp_object_unbox(intPtr2);
			}
			[CallerCount(0)]
			set
			{
				System.IntPtr* ptr = stackalloc System.IntPtr[1];
				*ptr = (nint)(&value);
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_startTime_Public_set_Void_Double_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
			}
		}

		public unsafe double performedTime
		{
			[CallerCount(0)]
			get
			{
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_performedTime_Public_get_Double_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return *(double*)IL2CPP.il2cpp_object_unbox(intPtr2);
			}
			[CallerCount(0)]
			set
			{
				System.IntPtr* ptr = stackalloc System.IntPtr[1];
				*ptr = (nint)(&value);
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_performedTime_Public_set_Void_Double_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
			}
		}

		public unsafe double timerStartTime
		{
			[CallerCount(0)]
			get
			{
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_timerStartTime_Public_get_Double_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return *(double*)IL2CPP.il2cpp_object_unbox(intPtr2);
			}
			[CallerCount(0)]
			set
			{
				System.IntPtr* ptr = stackalloc System.IntPtr[1];
				*ptr = (nint)(&value);
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_timerStartTime_Public_set_Void_Double_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
			}
		}

		public unsafe float timerDuration
		{
			[CallerCount(0)]
			get
			{
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_timerDuration_Public_get_Single_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
			}
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 968557, RefRangeEnd = 968572, XrefRangeStart = 968557, XrefRangeEnd = 968557, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				System.IntPtr* ptr = stackalloc System.IntPtr[1];
				*ptr = (nint)(&value);
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_timerDuration_Public_set_Void_Single_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
			}
		}

		public unsafe float totalTimeoutCompletionDone
		{
			[CallerCount(0)]
			get
			{
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_totalTimeoutCompletionDone_Public_get_Single_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
			}
			[CallerCount(0)]
			set
			{
				System.IntPtr* ptr = stackalloc System.IntPtr[1];
				*ptr = (nint)(&value);
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_totalTimeoutCompletionDone_Public_set_Void_Single_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
			}
		}

		public unsafe float totalTimeoutCompletionTimeRemaining
		{
			[CallerCount(0)]
			get
			{
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_totalTimeoutCompletionTimeRemaining_Public_get_Single_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
			}
			[CallerCount(0)]
			set
			{
				System.IntPtr* ptr = stackalloc System.IntPtr[1];
				*ptr = (nint)(&value);
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_totalTimeoutCompletionTimeRemaining_Public_set_Void_Single_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
			}
		}

		public unsafe long timerMonitorIndex
		{
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 42604, RefRangeEnd = 42610, XrefRangeStart = 42604, XrefRangeEnd = 42610, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_timerMonitorIndex_Public_get_Int64_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return *(long*)IL2CPP.il2cpp_object_unbox(intPtr2);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 327185, RefRangeEnd = 327186, XrefRangeStart = 327185, XrefRangeEnd = 327186, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				System.IntPtr* ptr = stackalloc System.IntPtr[1];
				*ptr = (nint)(&value);
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_timerMonitorIndex_Public_set_Void_Int64_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
			}
		}

		public unsafe bool isTimerRunning
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 968572, RefRangeEnd = 968573, XrefRangeStart = 968572, XrefRangeEnd = 968572, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_isTimerRunning_Public_get_Boolean_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
			}
			[CallerCount(0)]
			set
			{
				System.IntPtr* ptr = stackalloc System.IntPtr[1];
				*ptr = (nint)(&value);
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_isTimerRunning_Public_set_Void_Boolean_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
			}
		}

		public unsafe InputActionPhase phase
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 766084, RefRangeEnd = 766085, XrefRangeStart = 766084, XrefRangeEnd = 766085, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_phase_Public_get_InputActionPhase_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return *(InputActionPhase*)IL2CPP.il2cpp_object_unbox(intPtr2);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 968573, RefRangeEnd = 968575, XrefRangeStart = 968573, XrefRangeEnd = 968573, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				System.IntPtr* ptr = stackalloc System.IntPtr[1];
				*ptr = (nint)(&value);
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_phase_Public_set_Void_InputActionPhase_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
			}
		}

		static InteractionState()
		{
			Il2CppClassPointerStore<InteractionState>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<InputActionState>.NativeClassPtr, "InteractionState");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InteractionState>.NativeClassPtr);
			NativeFieldInfoPtr_m_TriggerControlIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractionState>.NativeClassPtr, "m_TriggerControlIndex");
			NativeFieldInfoPtr_m_Phase = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractionState>.NativeClassPtr, "m_Phase");
			NativeFieldInfoPtr_m_Flags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractionState>.NativeClassPtr, "m_Flags");
			NativeFieldInfoPtr_m_TimerDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractionState>.NativeClassPtr, "m_TimerDuration");
			NativeFieldInfoPtr_m_StartTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractionState>.NativeClassPtr, "m_StartTime");
			NativeFieldInfoPtr_m_TimerStartTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractionState>.NativeClassPtr, "m_TimerStartTime");
			NativeFieldInfoPtr_m_PerformedTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractionState>.NativeClassPtr, "m_PerformedTime");
			NativeFieldInfoPtr_m_TotalTimeoutCompletionTimeDone = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractionState>.NativeClassPtr, "m_TotalTimeoutCompletionTimeDone");
			NativeFieldInfoPtr_m_TotalTimeoutCompletionTimeRemaining = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractionState>.NativeClassPtr, "m_TotalTimeoutCompletionTimeRemaining");
			NativeFieldInfoPtr_m_TimerMonitorIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractionState>.NativeClassPtr, "m_TimerMonitorIndex");
			NativeMethodInfoPtr_get_triggerControlIndex_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractionState>.NativeClassPtr, 100664167);
			NativeMethodInfoPtr_set_triggerControlIndex_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractionState>.NativeClassPtr, 100664168);
			NativeMethodInfoPtr_get_startTime_Public_get_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractionState>.NativeClassPtr, 100664169);
			NativeMethodInfoPtr_set_startTime_Public_set_Void_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractionState>.NativeClassPtr, 100664170);
			NativeMethodInfoPtr_get_performedTime_Public_get_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractionState>.NativeClassPtr, 100664171);
			NativeMethodInfoPtr_set_performedTime_Public_set_Void_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractionState>.NativeClassPtr, 100664172);
			NativeMethodInfoPtr_get_timerStartTime_Public_get_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractionState>.NativeClassPtr, 100664173);
			NativeMethodInfoPtr_set_timerStartTime_Public_set_Void_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractionState>.NativeClassPtr, 100664174);
			NativeMethodInfoPtr_get_timerDuration_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractionState>.NativeClassPtr, 100664175);
			NativeMethodInfoPtr_set_timerDuration_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractionState>.NativeClassPtr, 100664176);
			NativeMethodInfoPtr_get_totalTimeoutCompletionDone_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractionState>.NativeClassPtr, 100664177);
			NativeMethodInfoPtr_set_totalTimeoutCompletionDone_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractionState>.NativeClassPtr, 100664178);
			NativeMethodInfoPtr_get_totalTimeoutCompletionTimeRemaining_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractionState>.NativeClassPtr, 100664179);
			NativeMethodInfoPtr_set_totalTimeoutCompletionTimeRemaining_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractionState>.NativeClassPtr, 100664180);
			NativeMethodInfoPtr_get_timerMonitorIndex_Public_get_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractionState>.NativeClassPtr, 100664181);
			NativeMethodInfoPtr_set_timerMonitorIndex_Public_set_Void_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractionState>.NativeClassPtr, 100664182);
			NativeMethodInfoPtr_get_isTimerRunning_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractionState>.NativeClassPtr, 100664183);
			NativeMethodInfoPtr_set_isTimerRunning_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractionState>.NativeClassPtr, 100664184);
			NativeMethodInfoPtr_get_phase_Public_get_InputActionPhase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractionState>.NativeClassPtr, 100664185);
			NativeMethodInfoPtr_set_phase_Public_set_Void_InputActionPhase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractionState>.NativeClassPtr, 100664186);
		}

		public unsafe Il2CppSystem.Object BoxIl2CppObject()
		{
			return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<InteractionState>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
		}
	}

	[StructLayout(LayoutKind.Explicit)]
	public struct BindingState
	{
		[OriginalName("Unity.InputSystem.dll", "", "Flags")]
		[System.Flags]
		public enum Flags
		{
			ChainsWithNext = 1,
			EndOfChain = 2,
			Composite = 4,
			PartOfComposite = 8,
			InitialStateCheckPending = 0x10,
			WantsInitialStateCheck = 0x20
		}

		private static readonly System.IntPtr NativeFieldInfoPtr_m_ControlCount;

		private static readonly System.IntPtr NativeFieldInfoPtr_m_InteractionCount;

		private static readonly System.IntPtr NativeFieldInfoPtr_m_ProcessorCount;

		private static readonly System.IntPtr NativeFieldInfoPtr_m_MapIndex;

		private static readonly System.IntPtr NativeFieldInfoPtr_m_Flags;

		private static readonly System.IntPtr NativeFieldInfoPtr_m_PartIndex;

		private static readonly System.IntPtr NativeFieldInfoPtr_m_ActionIndex;

		private static readonly System.IntPtr NativeFieldInfoPtr_m_CompositeOrCompositeBindingIndex;

		private static readonly System.IntPtr NativeFieldInfoPtr_m_ProcessorStartIndex;

		private static readonly System.IntPtr NativeFieldInfoPtr_m_InteractionStartIndex;

		private static readonly System.IntPtr NativeFieldInfoPtr_m_ControlStartIndex;

		private static readonly System.IntPtr NativeFieldInfoPtr_m_PressTime;

		private static readonly System.IntPtr NativeFieldInfoPtr_m_TriggerEventIdForComposite;

		private static readonly System.IntPtr NativeFieldInfoPtr___padding;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_controlStartIndex_Public_get_Int32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_set_controlStartIndex_Public_set_Void_Int32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_controlCount_Public_get_Int32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_set_controlCount_Public_set_Void_Int32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_interactionStartIndex_Public_get_Int32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_set_interactionStartIndex_Public_set_Void_Int32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_interactionCount_Public_get_Int32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_set_interactionCount_Public_set_Void_Int32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_processorStartIndex_Public_get_Int32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_set_processorStartIndex_Public_set_Void_Int32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_processorCount_Public_get_Int32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_set_processorCount_Public_set_Void_Int32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_actionIndex_Public_get_Int32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_set_actionIndex_Public_set_Void_Int32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_mapIndex_Public_get_Int32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_set_mapIndex_Public_set_Void_Int32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_compositeOrCompositeBindingIndex_Public_get_Int32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_set_compositeOrCompositeBindingIndex_Public_set_Void_Int32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_triggerEventIdForComposite_Public_get_Int32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_set_triggerEventIdForComposite_Public_set_Void_Int32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_pressTime_Public_get_Double_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_set_pressTime_Public_set_Void_Double_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_flags_Public_get_Flags_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_set_flags_Public_set_Void_Flags_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_chainsWithNext_Public_get_Boolean_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_set_chainsWithNext_Public_set_Void_Boolean_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_isEndOfChain_Public_get_Boolean_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_set_isEndOfChain_Public_set_Void_Boolean_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_isPartOfChain_Public_get_Boolean_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_isComposite_Public_get_Boolean_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_set_isComposite_Public_set_Void_Boolean_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_isPartOfComposite_Public_get_Boolean_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_set_isPartOfComposite_Public_set_Void_Boolean_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_initialStateCheckPending_Public_get_Boolean_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_set_initialStateCheckPending_Public_set_Void_Boolean_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_wantsInitialStateCheck_Public_get_Boolean_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_set_wantsInitialStateCheck_Public_set_Void_Boolean_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_partIndex_Public_get_Int32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_set_partIndex_Public_set_Void_Int32_0;

		[System.Runtime.InteropServices.FieldOffset(0)]
		public byte m_ControlCount;

		[System.Runtime.InteropServices.FieldOffset(1)]
		public byte m_InteractionCount;

		[System.Runtime.InteropServices.FieldOffset(2)]
		public byte m_ProcessorCount;

		[System.Runtime.InteropServices.FieldOffset(3)]
		public byte m_MapIndex;

		[System.Runtime.InteropServices.FieldOffset(4)]
		public byte m_Flags;

		[System.Runtime.InteropServices.FieldOffset(5)]
		public byte m_PartIndex;

		[System.Runtime.InteropServices.FieldOffset(6)]
		public ushort m_ActionIndex;

		[System.Runtime.InteropServices.FieldOffset(8)]
		public ushort m_CompositeOrCompositeBindingIndex;

		[System.Runtime.InteropServices.FieldOffset(10)]
		public ushort m_ProcessorStartIndex;

		[System.Runtime.InteropServices.FieldOffset(12)]
		public ushort m_InteractionStartIndex;

		[System.Runtime.InteropServices.FieldOffset(14)]
		public ushort m_ControlStartIndex;

		[System.Runtime.InteropServices.FieldOffset(16)]
		public double m_PressTime;

		[System.Runtime.InteropServices.FieldOffset(24)]
		public int m_TriggerEventIdForComposite;

		[System.Runtime.InteropServices.FieldOffset(28)]
		public int __padding;

		public unsafe int controlStartIndex
		{
			[CallerCount(0)]
			get
			{
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_controlStartIndex_Public_get_Int32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 968575, RefRangeEnd = 968576, XrefRangeStart = 968575, XrefRangeEnd = 968575, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				System.IntPtr* ptr = stackalloc System.IntPtr[1];
				*ptr = (nint)(&value);
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_controlStartIndex_Public_set_Void_Int32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
			}
		}

		public unsafe int controlCount
		{
			[CallerCount(90)]
			[CachedScanResults(RefRangeStart = 720416, RefRangeEnd = 720506, XrefRangeStart = 720416, XrefRangeEnd = 720506, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_controlCount_Public_get_Int32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 968576, RefRangeEnd = 968578, XrefRangeStart = 968576, XrefRangeEnd = 968576, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				System.IntPtr* ptr = stackalloc System.IntPtr[1];
				*ptr = (nint)(&value);
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_controlCount_Public_set_Void_Int32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
			}
		}

		public unsafe int interactionStartIndex
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 968578, RefRangeEnd = 968581, XrefRangeStart = 968578, XrefRangeEnd = 968578, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_interactionStartIndex_Public_get_Int32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 968581, RefRangeEnd = 968582, XrefRangeStart = 968581, XrefRangeEnd = 968581, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				System.IntPtr* ptr = stackalloc System.IntPtr[1];
				*ptr = (nint)(&value);
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_interactionStartIndex_Public_set_Void_Int32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
			}
		}

		public unsafe int interactionCount
		{
			[CallerCount(0)]
			get
			{
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_interactionCount_Public_get_Int32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 968582, RefRangeEnd = 968583, XrefRangeStart = 968582, XrefRangeEnd = 968582, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				System.IntPtr* ptr = stackalloc System.IntPtr[1];
				*ptr = (nint)(&value);
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_interactionCount_Public_set_Void_Int32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
			}
		}

		public unsafe int processorStartIndex
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 968583, RefRangeEnd = 968586, XrefRangeStart = 968583, XrefRangeEnd = 968583, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_processorStartIndex_Public_get_Int32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 968586, RefRangeEnd = 968587, XrefRangeStart = 968586, XrefRangeEnd = 968586, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				System.IntPtr* ptr = stackalloc System.IntPtr[1];
				*ptr = (nint)(&value);
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_processorStartIndex_Public_set_Void_Int32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
			}
		}

		public unsafe int processorCount
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 766084, RefRangeEnd = 766085, XrefRangeStart = 766084, XrefRangeEnd = 766085, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_processorCount_Public_get_Int32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 968587, RefRangeEnd = 968588, XrefRangeStart = 968587, XrefRangeEnd = 968587, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				System.IntPtr* ptr = stackalloc System.IntPtr[1];
				*ptr = (nint)(&value);
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_processorCount_Public_set_Void_Int32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
			}
		}

		public unsafe int actionIndex
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 968588, RefRangeEnd = 968592, XrefRangeStart = 968588, XrefRangeEnd = 968588, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_actionIndex_Public_get_Int32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 968592, RefRangeEnd = 968593, XrefRangeStart = 968592, XrefRangeEnd = 968592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				System.IntPtr* ptr = stackalloc System.IntPtr[1];
				*ptr = (nint)(&value);
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_actionIndex_Public_set_Void_Int32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
			}
		}

		public unsafe int mapIndex
		{
			[CallerCount(0)]
			get
			{
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_mapIndex_Public_get_Int32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 968593, RefRangeEnd = 968594, XrefRangeStart = 968593, XrefRangeEnd = 968593, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				System.IntPtr* ptr = stackalloc System.IntPtr[1];
				*ptr = (nint)(&value);
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_mapIndex_Public_set_Void_Int32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
			}
		}

		public unsafe int compositeOrCompositeBindingIndex
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 968594, RefRangeEnd = 968598, XrefRangeStart = 968594, XrefRangeEnd = 968594, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_compositeOrCompositeBindingIndex_Public_get_Int32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 968598, RefRangeEnd = 968599, XrefRangeStart = 968598, XrefRangeEnd = 968598, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				System.IntPtr* ptr = stackalloc System.IntPtr[1];
				*ptr = (nint)(&value);
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_compositeOrCompositeBindingIndex_Public_set_Void_Int32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
			}
		}

		public unsafe int triggerEventIdForComposite
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 54510, RefRangeEnd = 54511, XrefRangeStart = 54510, XrefRangeEnd = 54511, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_triggerEventIdForComposite_Public_get_Int32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 155401, RefRangeEnd = 155404, XrefRangeStart = 155401, XrefRangeEnd = 155404, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				System.IntPtr* ptr = stackalloc System.IntPtr[1];
				*ptr = (nint)(&value);
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_triggerEventIdForComposite_Public_set_Void_Int32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
			}
		}

		public unsafe double pressTime
		{
			[CallerCount(0)]
			get
			{
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_pressTime_Public_get_Double_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return *(double*)IL2CPP.il2cpp_object_unbox(intPtr2);
			}
			[CallerCount(0)]
			set
			{
				System.IntPtr* ptr = stackalloc System.IntPtr[1];
				*ptr = (nint)(&value);
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_pressTime_Public_set_Void_Double_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
			}
		}

		public unsafe Flags flags
		{
			[CallerCount(0)]
			get
			{
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_flags_Public_get_Flags_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return *(Flags*)IL2CPP.il2cpp_object_unbox(intPtr2);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 584882, RefRangeEnd = 584883, XrefRangeStart = 584882, XrefRangeEnd = 584883, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				System.IntPtr* ptr = stackalloc System.IntPtr[1];
				*ptr = (nint)(&value);
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_flags_Public_set_Void_Flags_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
			}
		}

		public unsafe bool chainsWithNext
		{
			[CallerCount(0)]
			get
			{
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_chainsWithNext_Public_get_Boolean_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
			}
			[CallerCount(0)]
			set
			{
				System.IntPtr* ptr = stackalloc System.IntPtr[1];
				*ptr = (nint)(&value);
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_chainsWithNext_Public_set_Void_Boolean_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
			}
		}

		public unsafe bool isEndOfChain
		{
			[CallerCount(0)]
			get
			{
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_isEndOfChain_Public_get_Boolean_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
			}
			[CallerCount(0)]
			set
			{
				System.IntPtr* ptr = stackalloc System.IntPtr[1];
				*ptr = (nint)(&value);
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_isEndOfChain_Public_set_Void_Boolean_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
			}
		}

		public unsafe bool isPartOfChain
		{
			[CallerCount(0)]
			get
			{
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_isPartOfChain_Public_get_Boolean_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
			}
		}

		public unsafe bool isComposite
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 968599, RefRangeEnd = 968601, XrefRangeStart = 968599, XrefRangeEnd = 968599, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_isComposite_Public_get_Boolean_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 968601, RefRangeEnd = 968602, XrefRangeStart = 968601, XrefRangeEnd = 968601, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				System.IntPtr* ptr = stackalloc System.IntPtr[1];
				*ptr = (nint)(&value);
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_isComposite_Public_set_Void_Boolean_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
			}
		}

		public unsafe bool isPartOfComposite
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 968602, RefRangeEnd = 968607, XrefRangeStart = 968602, XrefRangeEnd = 968602, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_isPartOfComposite_Public_get_Boolean_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 968607, RefRangeEnd = 968608, XrefRangeStart = 968607, XrefRangeEnd = 968607, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				System.IntPtr* ptr = stackalloc System.IntPtr[1];
				*ptr = (nint)(&value);
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_isPartOfComposite_Public_set_Void_Boolean_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
			}
		}

		public unsafe bool initialStateCheckPending
		{
			[CallerCount(0)]
			get
			{
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_initialStateCheckPending_Public_get_Boolean_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
			}
			[CallerCount(0)]
			set
			{
				System.IntPtr* ptr = stackalloc System.IntPtr[1];
				*ptr = (nint)(&value);
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_initialStateCheckPending_Public_set_Void_Boolean_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
			}
		}

		public unsafe bool wantsInitialStateCheck
		{
			[CallerCount(0)]
			get
			{
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_wantsInitialStateCheck_Public_get_Boolean_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 968608, RefRangeEnd = 968609, XrefRangeStart = 968608, XrefRangeEnd = 968608, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				System.IntPtr* ptr = stackalloc System.IntPtr[1];
				*ptr = (nint)(&value);
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_wantsInitialStateCheck_Public_set_Void_Boolean_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
			}
		}

		public unsafe int partIndex
		{
			[CallerCount(8)]
			[CachedScanResults(RefRangeStart = 52442, RefRangeEnd = 52450, XrefRangeStart = 52442, XrefRangeEnd = 52450, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_partIndex_Public_get_Int32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 968609, RefRangeEnd = 968610, XrefRangeStart = 968609, XrefRangeEnd = 968609, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				System.IntPtr* ptr = stackalloc System.IntPtr[1];
				*ptr = (nint)(&value);
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_partIndex_Public_set_Void_Int32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
			}
		}

		static BindingState()
		{
			Il2CppClassPointerStore<BindingState>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<InputActionState>.NativeClassPtr, "BindingState");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BindingState>.NativeClassPtr);
			NativeFieldInfoPtr_m_ControlCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BindingState>.NativeClassPtr, "m_ControlCount");
			NativeFieldInfoPtr_m_InteractionCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BindingState>.NativeClassPtr, "m_InteractionCount");
			NativeFieldInfoPtr_m_ProcessorCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BindingState>.NativeClassPtr, "m_ProcessorCount");
			NativeFieldInfoPtr_m_MapIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BindingState>.NativeClassPtr, "m_MapIndex");
			NativeFieldInfoPtr_m_Flags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BindingState>.NativeClassPtr, "m_Flags");
			NativeFieldInfoPtr_m_PartIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BindingState>.NativeClassPtr, "m_PartIndex");
			NativeFieldInfoPtr_m_ActionIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BindingState>.NativeClassPtr, "m_ActionIndex");
			NativeFieldInfoPtr_m_CompositeOrCompositeBindingIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BindingState>.NativeClassPtr, "m_CompositeOrCompositeBindingIndex");
			NativeFieldInfoPtr_m_ProcessorStartIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BindingState>.NativeClassPtr, "m_ProcessorStartIndex");
			NativeFieldInfoPtr_m_InteractionStartIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BindingState>.NativeClassPtr, "m_InteractionStartIndex");
			NativeFieldInfoPtr_m_ControlStartIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BindingState>.NativeClassPtr, "m_ControlStartIndex");
			NativeFieldInfoPtr_m_PressTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BindingState>.NativeClassPtr, "m_PressTime");
			NativeFieldInfoPtr_m_TriggerEventIdForComposite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BindingState>.NativeClassPtr, "m_TriggerEventIdForComposite");
			NativeFieldInfoPtr___padding = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BindingState>.NativeClassPtr, "__padding");
			NativeMethodInfoPtr_get_controlStartIndex_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BindingState>.NativeClassPtr, 100664187);
			NativeMethodInfoPtr_set_controlStartIndex_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BindingState>.NativeClassPtr, 100664188);
			NativeMethodInfoPtr_get_controlCount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BindingState>.NativeClassPtr, 100664189);
			NativeMethodInfoPtr_set_controlCount_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BindingState>.NativeClassPtr, 100664190);
			NativeMethodInfoPtr_get_interactionStartIndex_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BindingState>.NativeClassPtr, 100664191);
			NativeMethodInfoPtr_set_interactionStartIndex_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BindingState>.NativeClassPtr, 100664192);
			NativeMethodInfoPtr_get_interactionCount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BindingState>.NativeClassPtr, 100664193);
			NativeMethodInfoPtr_set_interactionCount_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BindingState>.NativeClassPtr, 100664194);
			NativeMethodInfoPtr_get_processorStartIndex_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BindingState>.NativeClassPtr, 100664195);
			NativeMethodInfoPtr_set_processorStartIndex_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BindingState>.NativeClassPtr, 100664196);
			NativeMethodInfoPtr_get_processorCount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BindingState>.NativeClassPtr, 100664197);
			NativeMethodInfoPtr_set_processorCount_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BindingState>.NativeClassPtr, 100664198);
			NativeMethodInfoPtr_get_actionIndex_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BindingState>.NativeClassPtr, 100664199);
			NativeMethodInfoPtr_set_actionIndex_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BindingState>.NativeClassPtr, 100664200);
			NativeMethodInfoPtr_get_mapIndex_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BindingState>.NativeClassPtr, 100664201);
			NativeMethodInfoPtr_set_mapIndex_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BindingState>.NativeClassPtr, 100664202);
			NativeMethodInfoPtr_get_compositeOrCompositeBindingIndex_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BindingState>.NativeClassPtr, 100664203);
			NativeMethodInfoPtr_set_compositeOrCompositeBindingIndex_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BindingState>.NativeClassPtr, 100664204);
			NativeMethodInfoPtr_get_triggerEventIdForComposite_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BindingState>.NativeClassPtr, 100664205);
			NativeMethodInfoPtr_set_triggerEventIdForComposite_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BindingState>.NativeClassPtr, 100664206);
			NativeMethodInfoPtr_get_pressTime_Public_get_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BindingState>.NativeClassPtr, 100664207);
			NativeMethodInfoPtr_set_pressTime_Public_set_Void_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BindingState>.NativeClassPtr, 100664208);
			NativeMethodInfoPtr_get_flags_Public_get_Flags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BindingState>.NativeClassPtr, 100664209);
			NativeMethodInfoPtr_set_flags_Public_set_Void_Flags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BindingState>.NativeClassPtr, 100664210);
			NativeMethodInfoPtr_get_chainsWithNext_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BindingState>.NativeClassPtr, 100664211);
			NativeMethodInfoPtr_set_chainsWithNext_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BindingState>.NativeClassPtr, 100664212);
			NativeMethodInfoPtr_get_isEndOfChain_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BindingState>.NativeClassPtr, 100664213);
			NativeMethodInfoPtr_set_isEndOfChain_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BindingState>.NativeClassPtr, 100664214);
			NativeMethodInfoPtr_get_isPartOfChain_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BindingState>.NativeClassPtr, 100664215);
			NativeMethodInfoPtr_get_isComposite_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BindingState>.NativeClassPtr, 100664216);
			NativeMethodInfoPtr_set_isComposite_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BindingState>.NativeClassPtr, 100664217);
			NativeMethodInfoPtr_get_isPartOfComposite_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BindingState>.NativeClassPtr, 100664218);
			NativeMethodInfoPtr_set_isPartOfComposite_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BindingState>.NativeClassPtr, 100664219);
			NativeMethodInfoPtr_get_initialStateCheckPending_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BindingState>.NativeClassPtr, 100664220);
			NativeMethodInfoPtr_set_initialStateCheckPending_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BindingState>.NativeClassPtr, 100664221);
			NativeMethodInfoPtr_get_wantsInitialStateCheck_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BindingState>.NativeClassPtr, 100664222);
			NativeMethodInfoPtr_set_wantsInitialStateCheck_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BindingState>.NativeClassPtr, 100664223);
			NativeMethodInfoPtr_get_partIndex_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BindingState>.NativeClassPtr, 100664224);
			NativeMethodInfoPtr_set_partIndex_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BindingState>.NativeClassPtr, 100664225);
		}

		public unsafe Il2CppSystem.Object BoxIl2CppObject()
		{
			return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BindingState>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
		}
	}

	[StructLayout(LayoutKind.Explicit)]
	public struct TriggerState
	{
		[OriginalName("Unity.InputSystem.dll", "", "Flags")]
		[System.Flags]
		public enum Flags
		{
			HaveMagnitude = 1,
			PassThrough = 2,
			MayNeedConflictResolution = 4,
			HasMultipleConcurrentActuations = 8,
			InProcessing = 0x10,
			Button = 0x20,
			Pressed = 0x40
		}

		private static readonly System.IntPtr NativeFieldInfoPtr_kMaxNumMaps;

		private static readonly System.IntPtr NativeFieldInfoPtr_kMaxNumControls;

		private static readonly System.IntPtr NativeFieldInfoPtr_kMaxNumBindings;

		private static readonly System.IntPtr NativeFieldInfoPtr_m_Phase;

		private static readonly System.IntPtr NativeFieldInfoPtr_m_Flags;

		private static readonly System.IntPtr NativeFieldInfoPtr_m_MapIndex;

		private static readonly System.IntPtr NativeFieldInfoPtr_m_ControlIndex;

		private static readonly System.IntPtr NativeFieldInfoPtr_m_Time;

		private static readonly System.IntPtr NativeFieldInfoPtr_m_StartTime;

		private static readonly System.IntPtr NativeFieldInfoPtr_m_BindingIndex;

		private static readonly System.IntPtr NativeFieldInfoPtr_m_InteractionIndex;

		private static readonly System.IntPtr NativeFieldInfoPtr_m_Magnitude;

		private static readonly System.IntPtr NativeFieldInfoPtr_m_LastPerformedInUpdate;

		private static readonly System.IntPtr NativeFieldInfoPtr_m_LastCanceledInUpdate;

		private static readonly System.IntPtr NativeFieldInfoPtr_m_PressedInUpdate;

		private static readonly System.IntPtr NativeFieldInfoPtr_m_ReleasedInUpdate;

		private static readonly System.IntPtr NativeFieldInfoPtr_m_LastCompletedInUpdate;

		private static readonly System.IntPtr NativeFieldInfoPtr_framePerformed;

		private static readonly System.IntPtr NativeFieldInfoPtr_framePressed;

		private static readonly System.IntPtr NativeFieldInfoPtr_frameReleased;

		private static readonly System.IntPtr NativeFieldInfoPtr_frameCompleted;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_phase_Public_get_InputActionPhase_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_set_phase_Public_set_Void_InputActionPhase_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_isDisabled_Public_get_Boolean_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_isWaiting_Public_get_Boolean_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_isStarted_Public_get_Boolean_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_isPerformed_Public_get_Boolean_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_isCanceled_Public_get_Boolean_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_time_Public_get_Double_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_set_time_Public_set_Void_Double_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_startTime_Public_get_Double_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_set_startTime_Public_set_Void_Double_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_magnitude_Public_get_Single_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_set_magnitude_Public_set_Void_Single_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_haveMagnitude_Public_get_Boolean_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_mapIndex_Public_get_Int32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_set_mapIndex_Public_set_Void_Int32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_controlIndex_Public_get_Int32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_set_controlIndex_Public_set_Void_Int32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_bindingIndex_Public_get_Int32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_set_bindingIndex_Public_set_Void_Int32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_interactionIndex_Public_get_Int32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_set_interactionIndex_Public_set_Void_Int32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_lastPerformedInUpdate_Public_get_UInt32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_set_lastPerformedInUpdate_Public_set_Void_UInt32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_lastCompletedInUpdate_Public_get_UInt32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_set_lastCompletedInUpdate_Public_set_Void_UInt32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_lastCanceledInUpdate_Public_get_UInt32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_set_lastCanceledInUpdate_Public_set_Void_UInt32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_pressedInUpdate_Public_get_UInt32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_set_pressedInUpdate_Public_set_Void_UInt32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_releasedInUpdate_Public_get_UInt32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_set_releasedInUpdate_Public_set_Void_UInt32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_isPassThrough_Public_get_Boolean_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_set_isPassThrough_Public_set_Void_Boolean_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_isButton_Public_get_Boolean_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_set_isButton_Public_set_Void_Boolean_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_isPressed_Public_get_Boolean_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_set_isPressed_Public_set_Void_Boolean_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_mayNeedConflictResolution_Public_get_Boolean_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_set_mayNeedConflictResolution_Public_set_Void_Boolean_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_hasMultipleConcurrentActuations_Public_get_Boolean_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_set_hasMultipleConcurrentActuations_Public_set_Void_Boolean_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_inProcessing_Public_get_Boolean_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_set_inProcessing_Public_set_Void_Boolean_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_flags_Public_get_Flags_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_set_flags_Public_set_Void_Flags_0;

		[System.Runtime.InteropServices.FieldOffset(0)]
		public byte m_Phase;

		[System.Runtime.InteropServices.FieldOffset(1)]
		public byte m_Flags;

		[System.Runtime.InteropServices.FieldOffset(2)]
		public byte m_MapIndex;

		[System.Runtime.InteropServices.FieldOffset(4)]
		public ushort m_ControlIndex;

		[System.Runtime.InteropServices.FieldOffset(8)]
		public double m_Time;

		[System.Runtime.InteropServices.FieldOffset(16)]
		public double m_StartTime;

		[System.Runtime.InteropServices.FieldOffset(24)]
		public ushort m_BindingIndex;

		[System.Runtime.InteropServices.FieldOffset(26)]
		public ushort m_InteractionIndex;

		[System.Runtime.InteropServices.FieldOffset(28)]
		public float m_Magnitude;

		[System.Runtime.InteropServices.FieldOffset(32)]
		public uint m_LastPerformedInUpdate;

		[System.Runtime.InteropServices.FieldOffset(36)]
		public uint m_LastCanceledInUpdate;

		[System.Runtime.InteropServices.FieldOffset(40)]
		public uint m_PressedInUpdate;

		[System.Runtime.InteropServices.FieldOffset(44)]
		public uint m_ReleasedInUpdate;

		[System.Runtime.InteropServices.FieldOffset(48)]
		public uint m_LastCompletedInUpdate;

		[System.Runtime.InteropServices.FieldOffset(52)]
		public int framePerformed;

		[System.Runtime.InteropServices.FieldOffset(56)]
		public int framePressed;

		[System.Runtime.InteropServices.FieldOffset(60)]
		public int frameReleased;

		[System.Runtime.InteropServices.FieldOffset(64)]
		public int frameCompleted;

		public unsafe static int kMaxNumMaps
		{
			get
			{
				Unsafe.SkipInit(out int result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_kMaxNumMaps, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_kMaxNumMaps, (void*)(&value));
			}
		}

		public unsafe static int kMaxNumControls
		{
			get
			{
				Unsafe.SkipInit(out int result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_kMaxNumControls, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_kMaxNumControls, (void*)(&value));
			}
		}

		public unsafe static int kMaxNumBindings
		{
			get
			{
				Unsafe.SkipInit(out int result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_kMaxNumBindings, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_kMaxNumBindings, (void*)(&value));
			}
		}

		public unsafe InputActionPhase phase
		{
			[CallerCount(90)]
			[CachedScanResults(RefRangeStart = 720416, RefRangeEnd = 720506, XrefRangeStart = 720416, XrefRangeEnd = 720506, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_phase_Public_get_InputActionPhase_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return *(InputActionPhase*)IL2CPP.il2cpp_object_unbox(intPtr2);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 745346, RefRangeEnd = 745347, XrefRangeStart = 745346, XrefRangeEnd = 745347, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				System.IntPtr* ptr = stackalloc System.IntPtr[1];
				*ptr = (nint)(&value);
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_phase_Public_set_Void_InputActionPhase_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
			}
		}

		public unsafe bool isDisabled
		{
			[CallerCount(0)]
			get
			{
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_isDisabled_Public_get_Boolean_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
			}
		}

		public unsafe bool isWaiting
		{
			[CallerCount(0)]
			get
			{
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_isWaiting_Public_get_Boolean_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
			}
		}

		public unsafe bool isStarted
		{
			[CallerCount(0)]
			get
			{
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_isStarted_Public_get_Boolean_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
			}
		}

		public unsafe bool isPerformed
		{
			[CallerCount(0)]
			get
			{
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_isPerformed_Public_get_Boolean_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
			}
		}

		public unsafe bool isCanceled
		{
			[CallerCount(0)]
			get
			{
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_isCanceled_Public_get_Boolean_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
			}
		}

		public unsafe double time
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 968555, RefRangeEnd = 968557, XrefRangeStart = 968555, XrefRangeEnd = 968557, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_time_Public_get_Double_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return *(double*)IL2CPP.il2cpp_object_unbox(intPtr2);
			}
			[CallerCount(0)]
			set
			{
				System.IntPtr* ptr = stackalloc System.IntPtr[1];
				*ptr = (nint)(&value);
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_time_Public_set_Void_Double_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
			}
		}

		public unsafe double startTime
		{
			[CallerCount(0)]
			get
			{
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_startTime_Public_get_Double_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return *(double*)IL2CPP.il2cpp_object_unbox(intPtr2);
			}
			[CallerCount(0)]
			set
			{
				System.IntPtr* ptr = stackalloc System.IntPtr[1];
				*ptr = (nint)(&value);
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_startTime_Public_set_Void_Double_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
			}
		}

		public unsafe float magnitude
		{
			[CallerCount(0)]
			get
			{
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_magnitude_Public_get_Single_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
			}
			[CallerCount(0)]
			set
			{
				System.IntPtr* ptr = stackalloc System.IntPtr[1];
				*ptr = (nint)(&value);
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_magnitude_Public_set_Void_Single_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
			}
		}

		public unsafe bool haveMagnitude
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 968610, RefRangeEnd = 968611, XrefRangeStart = 968610, XrefRangeEnd = 968610, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_haveMagnitude_Public_get_Boolean_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
			}
		}

		public unsafe int mapIndex
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 766084, RefRangeEnd = 766085, XrefRangeStart = 766084, XrefRangeEnd = 766085, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_mapIndex_Public_get_Int32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 968611, RefRangeEnd = 968612, XrefRangeStart = 968611, XrefRangeEnd = 968611, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				System.IntPtr* ptr = stackalloc System.IntPtr[1];
				*ptr = (nint)(&value);
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_mapIndex_Public_set_Void_Int32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
			}
		}

		public unsafe int controlIndex
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 968612, RefRangeEnd = 968627, XrefRangeStart = 968612, XrefRangeEnd = 968612, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_controlIndex_Public_get_Int32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
			}
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 968627, RefRangeEnd = 968634, XrefRangeStart = 968627, XrefRangeEnd = 968627, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				System.IntPtr* ptr = stackalloc System.IntPtr[1];
				*ptr = (nint)(&value);
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_controlIndex_Public_set_Void_Int32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
			}
		}

		public unsafe int bindingIndex
		{
			[CallerCount(0)]
			get
			{
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_bindingIndex_Public_get_Int32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 968634, RefRangeEnd = 968637, XrefRangeStart = 968634, XrefRangeEnd = 968634, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				System.IntPtr* ptr = stackalloc System.IntPtr[1];
				*ptr = (nint)(&value);
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_bindingIndex_Public_set_Void_Int32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
			}
		}

		public unsafe int interactionIndex
		{
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 968637, RefRangeEnd = 968643, XrefRangeStart = 968637, XrefRangeEnd = 968637, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_interactionIndex_Public_get_Int32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
			}
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 968643, RefRangeEnd = 968650, XrefRangeStart = 968643, XrefRangeEnd = 968643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				System.IntPtr* ptr = stackalloc System.IntPtr[1];
				*ptr = (nint)(&value);
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_interactionIndex_Public_set_Void_Int32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
			}
		}

		public unsafe uint lastPerformedInUpdate
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 63233, RefRangeEnd = 63234, XrefRangeStart = 63233, XrefRangeEnd = 63234, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_lastPerformedInUpdate_Public_get_UInt32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return *(uint*)IL2CPP.il2cpp_object_unbox(intPtr2);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 102244, RefRangeEnd = 102245, XrefRangeStart = 102244, XrefRangeEnd = 102245, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				System.IntPtr* ptr = stackalloc System.IntPtr[1];
				*ptr = (nint)(&value);
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_lastPerformedInUpdate_Public_set_Void_UInt32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
			}
		}

		public unsafe uint lastCompletedInUpdate
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 66330, RefRangeEnd = 66331, XrefRangeStart = 66330, XrefRangeEnd = 66331, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_lastCompletedInUpdate_Public_get_UInt32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return *(uint*)IL2CPP.il2cpp_object_unbox(intPtr2);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 243941, RefRangeEnd = 243942, XrefRangeStart = 243941, XrefRangeEnd = 243942, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				System.IntPtr* ptr = stackalloc System.IntPtr[1];
				*ptr = (nint)(&value);
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_lastCompletedInUpdate_Public_set_Void_UInt32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
			}
		}

		public unsafe uint lastCanceledInUpdate
		{
			[CallerCount(0)]
			get
			{
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_lastCanceledInUpdate_Public_get_UInt32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return *(uint*)IL2CPP.il2cpp_object_unbox(intPtr2);
			}
			[CallerCount(0)]
			set
			{
				System.IntPtr* ptr = stackalloc System.IntPtr[1];
				*ptr = (nint)(&value);
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_lastCanceledInUpdate_Public_set_Void_UInt32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
			}
		}

		public unsafe uint pressedInUpdate
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 80842, RefRangeEnd = 80843, XrefRangeStart = 80842, XrefRangeEnd = 80843, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_pressedInUpdate_Public_get_UInt32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return *(uint*)IL2CPP.il2cpp_object_unbox(intPtr2);
			}
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 84616, RefRangeEnd = 84621, XrefRangeStart = 84616, XrefRangeEnd = 84621, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				System.IntPtr* ptr = stackalloc System.IntPtr[1];
				*ptr = (nint)(&value);
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_pressedInUpdate_Public_set_Void_UInt32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
			}
		}

		public unsafe uint releasedInUpdate
		{
			[CallerCount(0)]
			get
			{
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_releasedInUpdate_Public_get_UInt32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return *(uint*)IL2CPP.il2cpp_object_unbox(intPtr2);
			}
			[CallerCount(0)]
			set
			{
				System.IntPtr* ptr = stackalloc System.IntPtr[1];
				*ptr = (nint)(&value);
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_releasedInUpdate_Public_set_Void_UInt32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
			}
		}

		public unsafe bool isPassThrough
		{
			[CallerCount(0)]
			get
			{
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_isPassThrough_Public_get_Boolean_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 968650, RefRangeEnd = 968651, XrefRangeStart = 968650, XrefRangeEnd = 968650, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				System.IntPtr* ptr = stackalloc System.IntPtr[1];
				*ptr = (nint)(&value);
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_isPassThrough_Public_set_Void_Boolean_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
			}
		}

		public unsafe bool isButton
		{
			[CallerCount(0)]
			get
			{
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_isButton_Public_get_Boolean_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 968651, RefRangeEnd = 968652, XrefRangeStart = 968651, XrefRangeEnd = 968651, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				System.IntPtr* ptr = stackalloc System.IntPtr[1];
				*ptr = (nint)(&value);
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_isButton_Public_set_Void_Boolean_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
			}
		}

		public unsafe bool isPressed
		{
			[CallerCount(0)]
			get
			{
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_isPressed_Public_get_Boolean_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
			}
			[CallerCount(0)]
			set
			{
				System.IntPtr* ptr = stackalloc System.IntPtr[1];
				*ptr = (nint)(&value);
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_isPressed_Public_set_Void_Boolean_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
			}
		}

		public unsafe bool mayNeedConflictResolution
		{
			[CallerCount(0)]
			get
			{
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_mayNeedConflictResolution_Public_get_Boolean_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 968652, RefRangeEnd = 968653, XrefRangeStart = 968652, XrefRangeEnd = 968652, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				System.IntPtr* ptr = stackalloc System.IntPtr[1];
				*ptr = (nint)(&value);
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_mayNeedConflictResolution_Public_set_Void_Boolean_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
			}
		}

		public unsafe bool hasMultipleConcurrentActuations
		{
			[CallerCount(0)]
			get
			{
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_hasMultipleConcurrentActuations_Public_get_Boolean_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
			}
			[CallerCount(0)]
			set
			{
				System.IntPtr* ptr = stackalloc System.IntPtr[1];
				*ptr = (nint)(&value);
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_hasMultipleConcurrentActuations_Public_set_Void_Boolean_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
			}
		}

		public unsafe bool inProcessing
		{
			[CallerCount(0)]
			get
			{
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_inProcessing_Public_get_Boolean_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
			}
			[CallerCount(0)]
			set
			{
				System.IntPtr* ptr = stackalloc System.IntPtr[1];
				*ptr = (nint)(&value);
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_inProcessing_Public_set_Void_Boolean_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
			}
		}

		public unsafe Flags flags
		{
			[CallerCount(0)]
			get
			{
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_flags_Public_get_Flags_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return *(Flags*)IL2CPP.il2cpp_object_unbox(intPtr2);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 968653, RefRangeEnd = 968654, XrefRangeStart = 968653, XrefRangeEnd = 968653, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				System.IntPtr* ptr = stackalloc System.IntPtr[1];
				*ptr = (nint)(&value);
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_flags_Public_set_Void_Flags_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
			}
		}

		static TriggerState()
		{
			Il2CppClassPointerStore<TriggerState>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<InputActionState>.NativeClassPtr, "TriggerState");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TriggerState>.NativeClassPtr);
			NativeFieldInfoPtr_kMaxNumMaps = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TriggerState>.NativeClassPtr, "kMaxNumMaps");
			NativeFieldInfoPtr_kMaxNumControls = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TriggerState>.NativeClassPtr, "kMaxNumControls");
			NativeFieldInfoPtr_kMaxNumBindings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TriggerState>.NativeClassPtr, "kMaxNumBindings");
			NativeFieldInfoPtr_m_Phase = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TriggerState>.NativeClassPtr, "m_Phase");
			NativeFieldInfoPtr_m_Flags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TriggerState>.NativeClassPtr, "m_Flags");
			NativeFieldInfoPtr_m_MapIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TriggerState>.NativeClassPtr, "m_MapIndex");
			NativeFieldInfoPtr_m_ControlIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TriggerState>.NativeClassPtr, "m_ControlIndex");
			NativeFieldInfoPtr_m_Time = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TriggerState>.NativeClassPtr, "m_Time");
			NativeFieldInfoPtr_m_StartTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TriggerState>.NativeClassPtr, "m_StartTime");
			NativeFieldInfoPtr_m_BindingIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TriggerState>.NativeClassPtr, "m_BindingIndex");
			NativeFieldInfoPtr_m_InteractionIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TriggerState>.NativeClassPtr, "m_InteractionIndex");
			NativeFieldInfoPtr_m_Magnitude = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TriggerState>.NativeClassPtr, "m_Magnitude");
			NativeFieldInfoPtr_m_LastPerformedInUpdate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TriggerState>.NativeClassPtr, "m_LastPerformedInUpdate");
			NativeFieldInfoPtr_m_LastCanceledInUpdate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TriggerState>.NativeClassPtr, "m_LastCanceledInUpdate");
			NativeFieldInfoPtr_m_PressedInUpdate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TriggerState>.NativeClassPtr, "m_PressedInUpdate");
			NativeFieldInfoPtr_m_ReleasedInUpdate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TriggerState>.NativeClassPtr, "m_ReleasedInUpdate");
			NativeFieldInfoPtr_m_LastCompletedInUpdate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TriggerState>.NativeClassPtr, "m_LastCompletedInUpdate");
			NativeFieldInfoPtr_framePerformed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TriggerState>.NativeClassPtr, "framePerformed");
			NativeFieldInfoPtr_framePressed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TriggerState>.NativeClassPtr, "framePressed");
			NativeFieldInfoPtr_frameReleased = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TriggerState>.NativeClassPtr, "frameReleased");
			NativeFieldInfoPtr_frameCompleted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TriggerState>.NativeClassPtr, "frameCompleted");
			NativeMethodInfoPtr_get_phase_Public_get_InputActionPhase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TriggerState>.NativeClassPtr, 100664226);
			NativeMethodInfoPtr_set_phase_Public_set_Void_InputActionPhase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TriggerState>.NativeClassPtr, 100664227);
			NativeMethodInfoPtr_get_isDisabled_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TriggerState>.NativeClassPtr, 100664228);
			NativeMethodInfoPtr_get_isWaiting_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TriggerState>.NativeClassPtr, 100664229);
			NativeMethodInfoPtr_get_isStarted_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TriggerState>.NativeClassPtr, 100664230);
			NativeMethodInfoPtr_get_isPerformed_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TriggerState>.NativeClassPtr, 100664231);
			NativeMethodInfoPtr_get_isCanceled_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TriggerState>.NativeClassPtr, 100664232);
			NativeMethodInfoPtr_get_time_Public_get_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TriggerState>.NativeClassPtr, 100664233);
			NativeMethodInfoPtr_set_time_Public_set_Void_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TriggerState>.NativeClassPtr, 100664234);
			NativeMethodInfoPtr_get_startTime_Public_get_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TriggerState>.NativeClassPtr, 100664235);
			NativeMethodInfoPtr_set_startTime_Public_set_Void_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TriggerState>.NativeClassPtr, 100664236);
			NativeMethodInfoPtr_get_magnitude_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TriggerState>.NativeClassPtr, 100664237);
			NativeMethodInfoPtr_set_magnitude_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TriggerState>.NativeClassPtr, 100664238);
			NativeMethodInfoPtr_get_haveMagnitude_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TriggerState>.NativeClassPtr, 100664239);
			NativeMethodInfoPtr_get_mapIndex_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TriggerState>.NativeClassPtr, 100664240);
			NativeMethodInfoPtr_set_mapIndex_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TriggerState>.NativeClassPtr, 100664241);
			NativeMethodInfoPtr_get_controlIndex_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TriggerState>.NativeClassPtr, 100664242);
			NativeMethodInfoPtr_set_controlIndex_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TriggerState>.NativeClassPtr, 100664243);
			NativeMethodInfoPtr_get_bindingIndex_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TriggerState>.NativeClassPtr, 100664244);
			NativeMethodInfoPtr_set_bindingIndex_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TriggerState>.NativeClassPtr, 100664245);
			NativeMethodInfoPtr_get_interactionIndex_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TriggerState>.NativeClassPtr, 100664246);
			NativeMethodInfoPtr_set_interactionIndex_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TriggerState>.NativeClassPtr, 100664247);
			NativeMethodInfoPtr_get_lastPerformedInUpdate_Public_get_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TriggerState>.NativeClassPtr, 100664248);
			NativeMethodInfoPtr_set_lastPerformedInUpdate_Public_set_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TriggerState>.NativeClassPtr, 100664249);
			NativeMethodInfoPtr_get_lastCompletedInUpdate_Public_get_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TriggerState>.NativeClassPtr, 100664250);
			NativeMethodInfoPtr_set_lastCompletedInUpdate_Public_set_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TriggerState>.NativeClassPtr, 100664251);
			NativeMethodInfoPtr_get_lastCanceledInUpdate_Public_get_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TriggerState>.NativeClassPtr, 100664252);
			NativeMethodInfoPtr_set_lastCanceledInUpdate_Public_set_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TriggerState>.NativeClassPtr, 100664253);
			NativeMethodInfoPtr_get_pressedInUpdate_Public_get_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TriggerState>.NativeClassPtr, 100664254);
			NativeMethodInfoPtr_set_pressedInUpdate_Public_set_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TriggerState>.NativeClassPtr, 100664255);
			NativeMethodInfoPtr_get_releasedInUpdate_Public_get_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TriggerState>.NativeClassPtr, 100664256);
			NativeMethodInfoPtr_set_releasedInUpdate_Public_set_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TriggerState>.NativeClassPtr, 100664257);
			NativeMethodInfoPtr_get_isPassThrough_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TriggerState>.NativeClassPtr, 100664258);
			NativeMethodInfoPtr_set_isPassThrough_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TriggerState>.NativeClassPtr, 100664259);
			NativeMethodInfoPtr_get_isButton_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TriggerState>.NativeClassPtr, 100664260);
			NativeMethodInfoPtr_set_isButton_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TriggerState>.NativeClassPtr, 100664261);
			NativeMethodInfoPtr_get_isPressed_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TriggerState>.NativeClassPtr, 100664262);
			NativeMethodInfoPtr_set_isPressed_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TriggerState>.NativeClassPtr, 100664263);
			NativeMethodInfoPtr_get_mayNeedConflictResolution_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TriggerState>.NativeClassPtr, 100664264);
			NativeMethodInfoPtr_set_mayNeedConflictResolution_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TriggerState>.NativeClassPtr, 100664265);
			NativeMethodInfoPtr_get_hasMultipleConcurrentActuations_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TriggerState>.NativeClassPtr, 100664266);
			NativeMethodInfoPtr_set_hasMultipleConcurrentActuations_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TriggerState>.NativeClassPtr, 100664267);
			NativeMethodInfoPtr_get_inProcessing_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TriggerState>.NativeClassPtr, 100664268);
			NativeMethodInfoPtr_set_inProcessing_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TriggerState>.NativeClassPtr, 100664269);
			NativeMethodInfoPtr_get_flags_Public_get_Flags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TriggerState>.NativeClassPtr, 100664270);
			NativeMethodInfoPtr_set_flags_Public_set_Void_Flags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TriggerState>.NativeClassPtr, 100664271);
		}

		public unsafe Il2CppSystem.Object BoxIl2CppObject()
		{
			return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TriggerState>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
		}
	}

	[StructLayout(LayoutKind.Explicit)]
	public struct ActionMapIndices
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_actionStartIndex;

		private static readonly System.IntPtr NativeFieldInfoPtr_actionCount;

		private static readonly System.IntPtr NativeFieldInfoPtr_controlStartIndex;

		private static readonly System.IntPtr NativeFieldInfoPtr_controlCount;

		private static readonly System.IntPtr NativeFieldInfoPtr_bindingStartIndex;

		private static readonly System.IntPtr NativeFieldInfoPtr_bindingCount;

		private static readonly System.IntPtr NativeFieldInfoPtr_interactionStartIndex;

		private static readonly System.IntPtr NativeFieldInfoPtr_interactionCount;

		private static readonly System.IntPtr NativeFieldInfoPtr_processorStartIndex;

		private static readonly System.IntPtr NativeFieldInfoPtr_processorCount;

		private static readonly System.IntPtr NativeFieldInfoPtr_compositeStartIndex;

		private static readonly System.IntPtr NativeFieldInfoPtr_compositeCount;

		[System.Runtime.InteropServices.FieldOffset(0)]
		public int actionStartIndex;

		[System.Runtime.InteropServices.FieldOffset(4)]
		public int actionCount;

		[System.Runtime.InteropServices.FieldOffset(8)]
		public int controlStartIndex;

		[System.Runtime.InteropServices.FieldOffset(12)]
		public int controlCount;

		[System.Runtime.InteropServices.FieldOffset(16)]
		public int bindingStartIndex;

		[System.Runtime.InteropServices.FieldOffset(20)]
		public int bindingCount;

		[System.Runtime.InteropServices.FieldOffset(24)]
		public int interactionStartIndex;

		[System.Runtime.InteropServices.FieldOffset(28)]
		public int interactionCount;

		[System.Runtime.InteropServices.FieldOffset(32)]
		public int processorStartIndex;

		[System.Runtime.InteropServices.FieldOffset(36)]
		public int processorCount;

		[System.Runtime.InteropServices.FieldOffset(40)]
		public int compositeStartIndex;

		[System.Runtime.InteropServices.FieldOffset(44)]
		public int compositeCount;

		static ActionMapIndices()
		{
			Il2CppClassPointerStore<ActionMapIndices>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<InputActionState>.NativeClassPtr, "ActionMapIndices");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ActionMapIndices>.NativeClassPtr);
			NativeFieldInfoPtr_actionStartIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActionMapIndices>.NativeClassPtr, "actionStartIndex");
			NativeFieldInfoPtr_actionCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActionMapIndices>.NativeClassPtr, "actionCount");
			NativeFieldInfoPtr_controlStartIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActionMapIndices>.NativeClassPtr, "controlStartIndex");
			NativeFieldInfoPtr_controlCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActionMapIndices>.NativeClassPtr, "controlCount");
			NativeFieldInfoPtr_bindingStartIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActionMapIndices>.NativeClassPtr, "bindingStartIndex");
			NativeFieldInfoPtr_bindingCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActionMapIndices>.NativeClassPtr, "bindingCount");
			NativeFieldInfoPtr_interactionStartIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActionMapIndices>.NativeClassPtr, "interactionStartIndex");
			NativeFieldInfoPtr_interactionCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActionMapIndices>.NativeClassPtr, "interactionCount");
			NativeFieldInfoPtr_processorStartIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActionMapIndices>.NativeClassPtr, "processorStartIndex");
			NativeFieldInfoPtr_processorCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActionMapIndices>.NativeClassPtr, "processorCount");
			NativeFieldInfoPtr_compositeStartIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActionMapIndices>.NativeClassPtr, "compositeStartIndex");
			NativeFieldInfoPtr_compositeCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActionMapIndices>.NativeClassPtr, "compositeCount");
		}

		public unsafe Il2CppSystem.Object BoxIl2CppObject()
		{
			return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ActionMapIndices>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
		}
	}

	[StructLayout(LayoutKind.Explicit)]
	public struct UnmanagedMemory
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_basePtr;

		private static readonly System.IntPtr NativeFieldInfoPtr_mapCount;

		private static readonly System.IntPtr NativeFieldInfoPtr_actionCount;

		private static readonly System.IntPtr NativeFieldInfoPtr_interactionCount;

		private static readonly System.IntPtr NativeFieldInfoPtr_bindingCount;

		private static readonly System.IntPtr NativeFieldInfoPtr_controlCount;

		private static readonly System.IntPtr NativeFieldInfoPtr_compositeCount;

		private static readonly System.IntPtr NativeFieldInfoPtr_actionStates;

		private static readonly System.IntPtr NativeFieldInfoPtr_bindingStates;

		private static readonly System.IntPtr NativeFieldInfoPtr_interactionStates;

		private static readonly System.IntPtr NativeFieldInfoPtr_controlMagnitudes;

		private static readonly System.IntPtr NativeFieldInfoPtr_compositeMagnitudes;

		private static readonly System.IntPtr NativeFieldInfoPtr_enabledControls;

		private static readonly System.IntPtr NativeFieldInfoPtr_actionBindingIndicesAndCounts;

		private static readonly System.IntPtr NativeFieldInfoPtr_actionBindingIndices;

		private static readonly System.IntPtr NativeFieldInfoPtr_controlIndexToBindingIndex;

		private static readonly System.IntPtr NativeFieldInfoPtr_controlGroupingAndComplexity;

		private static readonly System.IntPtr NativeFieldInfoPtr_controlGroupingInitialized;

		private static readonly System.IntPtr NativeFieldInfoPtr_mapIndices;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_isAllocated_Public_get_Boolean_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_sizeInBytes_Public_get_Int32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_AllocFromBlob_Private_Static_ptr_Byte_byref_ptr_Byte_Int32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_Allocate_Public_Void_Int32_Int32_Int32_Int32_Int32_Int32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_CopyDataFrom_Public_Void_UnmanagedMemory_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_Clone_Public_UnmanagedMemory_0;

		[System.Runtime.InteropServices.FieldOffset(0)]
		public System.IntPtr basePtr;

		[System.Runtime.InteropServices.FieldOffset(8)]
		public int mapCount;

		[System.Runtime.InteropServices.FieldOffset(12)]
		public int actionCount;

		[System.Runtime.InteropServices.FieldOffset(16)]
		public int interactionCount;

		[System.Runtime.InteropServices.FieldOffset(20)]
		public int bindingCount;

		[System.Runtime.InteropServices.FieldOffset(24)]
		public int controlCount;

		[System.Runtime.InteropServices.FieldOffset(28)]
		public int compositeCount;

		[System.Runtime.InteropServices.FieldOffset(32)]
		public System.IntPtr actionStates;

		[System.Runtime.InteropServices.FieldOffset(40)]
		public System.IntPtr bindingStates;

		[System.Runtime.InteropServices.FieldOffset(48)]
		public System.IntPtr interactionStates;

		[System.Runtime.InteropServices.FieldOffset(56)]
		public System.IntPtr controlMagnitudes;

		[System.Runtime.InteropServices.FieldOffset(64)]
		public System.IntPtr compositeMagnitudes;

		[System.Runtime.InteropServices.FieldOffset(72)]
		public System.IntPtr enabledControls;

		[System.Runtime.InteropServices.FieldOffset(80)]
		public System.IntPtr actionBindingIndicesAndCounts;

		[System.Runtime.InteropServices.FieldOffset(88)]
		public System.IntPtr actionBindingIndices;

		[System.Runtime.InteropServices.FieldOffset(96)]
		public System.IntPtr controlIndexToBindingIndex;

		[System.Runtime.InteropServices.FieldOffset(104)]
		public System.IntPtr controlGroupingAndComplexity;

		[System.Runtime.InteropServices.FieldOffset(112)]
		[System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.U1)]
		public bool controlGroupingInitialized;

		[System.Runtime.InteropServices.FieldOffset(120)]
		public System.IntPtr mapIndices;

		public unsafe bool isAllocated
		{
			[CallerCount(18)]
			[CachedScanResults(RefRangeStart = 804380, RefRangeEnd = 804398, XrefRangeStart = 804380, XrefRangeEnd = 804398, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_isAllocated_Public_get_Boolean_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
			}
		}

		public unsafe int sizeInBytes
		{
			[CallerCount(0)]
			get
			{
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_sizeInBytes_Public_get_Int32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
			}
		}

		static UnmanagedMemory()
		{
			Il2CppClassPointerStore<UnmanagedMemory>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<InputActionState>.NativeClassPtr, "UnmanagedMemory");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnmanagedMemory>.NativeClassPtr);
			NativeFieldInfoPtr_basePtr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnmanagedMemory>.NativeClassPtr, "basePtr");
			NativeFieldInfoPtr_mapCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnmanagedMemory>.NativeClassPtr, "mapCount");
			NativeFieldInfoPtr_actionCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnmanagedMemory>.NativeClassPtr, "actionCount");
			NativeFieldInfoPtr_interactionCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnmanagedMemory>.NativeClassPtr, "interactionCount");
			NativeFieldInfoPtr_bindingCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnmanagedMemory>.NativeClassPtr, "bindingCount");
			NativeFieldInfoPtr_controlCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnmanagedMemory>.NativeClassPtr, "controlCount");
			NativeFieldInfoPtr_compositeCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnmanagedMemory>.NativeClassPtr, "compositeCount");
			NativeFieldInfoPtr_actionStates = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnmanagedMemory>.NativeClassPtr, "actionStates");
			NativeFieldInfoPtr_bindingStates = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnmanagedMemory>.NativeClassPtr, "bindingStates");
			NativeFieldInfoPtr_interactionStates = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnmanagedMemory>.NativeClassPtr, "interactionStates");
			NativeFieldInfoPtr_controlMagnitudes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnmanagedMemory>.NativeClassPtr, "controlMagnitudes");
			NativeFieldInfoPtr_compositeMagnitudes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnmanagedMemory>.NativeClassPtr, "compositeMagnitudes");
			NativeFieldInfoPtr_enabledControls = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnmanagedMemory>.NativeClassPtr, "enabledControls");
			NativeFieldInfoPtr_actionBindingIndicesAndCounts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnmanagedMemory>.NativeClassPtr, "actionBindingIndicesAndCounts");
			NativeFieldInfoPtr_actionBindingIndices = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnmanagedMemory>.NativeClassPtr, "actionBindingIndices");
			NativeFieldInfoPtr_controlIndexToBindingIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnmanagedMemory>.NativeClassPtr, "controlIndexToBindingIndex");
			NativeFieldInfoPtr_controlGroupingAndComplexity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnmanagedMemory>.NativeClassPtr, "controlGroupingAndComplexity");
			NativeFieldInfoPtr_controlGroupingInitialized = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnmanagedMemory>.NativeClassPtr, "controlGroupingInitialized");
			NativeFieldInfoPtr_mapIndices = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnmanagedMemory>.NativeClassPtr, "mapIndices");
			NativeMethodInfoPtr_get_isAllocated_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnmanagedMemory>.NativeClassPtr, 100664272);
			NativeMethodInfoPtr_get_sizeInBytes_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnmanagedMemory>.NativeClassPtr, 100664273);
			NativeMethodInfoPtr_AllocFromBlob_Private_Static_ptr_Byte_byref_ptr_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnmanagedMemory>.NativeClassPtr, 100664274);
			NativeMethodInfoPtr_Allocate_Public_Void_Int32_Int32_Int32_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnmanagedMemory>.NativeClassPtr, 100664275);
			NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnmanagedMemory>.NativeClassPtr, 100664276);
			NativeMethodInfoPtr_CopyDataFrom_Public_Void_UnmanagedMemory_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnmanagedMemory>.NativeClassPtr, 100664277);
			NativeMethodInfoPtr_Clone_Public_UnmanagedMemory_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnmanagedMemory>.NativeClassPtr, 100664278);
		}

		[CallerCount(0)]
		public unsafe static byte* AllocFromBlob(ref byte* top, int size)
		{
			//IL_004a->IL004c: Incompatible stack types: I vs O
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)Unsafe.As<byte*, object>(ref top));
			*ptr = (nint)(&intPtr);
			*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &size;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr result = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AllocFromBlob_Private_Static_ptr_Byte_byref_ptr_Byte_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			System.IntPtr intPtr3 = intPtr;
			Unsafe.As<byte*, object>(ref top) = ((intPtr3 == (System.IntPtr)0) ? null : ((object)new byte*(intPtr3)));
			return (byte*)result;
		}

		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 968658, RefRangeEnd = 968661, XrefRangeStart = 968654, XrefRangeEnd = 968658, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Allocate(int mapCount, int actionCount, int bindingCount, int controlCount, int interactionCount, int compositeCount)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[6];
			*ptr = (nint)(&mapCount);
			*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &actionCount;
			*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &bindingCount;
			*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &controlCount;
			*(int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &interactionCount;
			*(int**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &compositeCount;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Allocate_Public_Void_Int32_Int32_Int32_Int32_Int32_Int32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 968662, RefRangeEnd = 968668, XrefRangeStart = 968661, XrefRangeEnd = 968662, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Dispose()
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 968679, RefRangeEnd = 968682, XrefRangeStart = 968668, XrefRangeEnd = 968679, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CopyDataFrom(UnmanagedMemory memory)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&memory);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CopyDataFrom_Public_Void_UnmanagedMemory_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 968685, RefRangeEnd = 968688, XrefRangeStart = 968682, XrefRangeEnd = 968685, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UnmanagedMemory Clone()
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Clone_Public_UnmanagedMemory_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(UnmanagedMemory*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		public unsafe Il2CppSystem.Object BoxIl2CppObject()
		{
			return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UnmanagedMemory>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
		}
	}

	public sealed class GlobalState : Il2CppSystem.ValueType
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_globalList;

		private static readonly System.IntPtr NativeFieldInfoPtr_onActionChange;

		private static readonly System.IntPtr NativeFieldInfoPtr_onActionControlsChanged;

		public unsafe InlinedArray<Il2CppSystem.Runtime.InteropServices.GCHandle> globalList
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_globalList);
				return new InlinedArray<Il2CppSystem.Runtime.InteropServices.GCHandle>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<InlinedArray<Il2CppSystem.Runtime.InteropServices.GCHandle>>.NativeClassPtr, (System.IntPtr)num));
			}
			set
			{
				// IL cpblk instruction
				Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_globalList), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<InlinedArray<Il2CppSystem.Runtime.InteropServices.GCHandle>>.NativeClassPtr, ref *(uint*)null));
			}
		}

		public unsafe CallbackArray<Il2CppSystem.Action<Il2CppSystem.Object, InputActionChange>> onActionChange
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_onActionChange);
				return new CallbackArray<Il2CppSystem.Action<Il2CppSystem.Object, InputActionChange>>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CallbackArray<Il2CppSystem.Action<Il2CppSystem.Object, InputActionChange>>>.NativeClassPtr, (System.IntPtr)num));
			}
			set
			{
				// IL cpblk instruction
				Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_onActionChange), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CallbackArray<Il2CppSystem.Action<Il2CppSystem.Object, InputActionChange>>>.NativeClassPtr, ref *(uint*)null));
			}
		}

		public unsafe CallbackArray<Il2CppSystem.Action<Il2CppSystem.Object>> onActionControlsChanged
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_onActionControlsChanged);
				return new CallbackArray<Il2CppSystem.Action<Il2CppSystem.Object>>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CallbackArray<Il2CppSystem.Action<Il2CppSystem.Object>>>.NativeClassPtr, (System.IntPtr)num));
			}
			set
			{
				// IL cpblk instruction
				Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_onActionControlsChanged), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CallbackArray<Il2CppSystem.Action<Il2CppSystem.Object>>>.NativeClassPtr, ref *(uint*)null));
			}
		}

		static GlobalState()
		{
			Il2CppClassPointerStore<GlobalState>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<InputActionState>.NativeClassPtr, "GlobalState");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GlobalState>.NativeClassPtr);
			NativeFieldInfoPtr_globalList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalState>.NativeClassPtr, "globalList");
			NativeFieldInfoPtr_onActionChange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalState>.NativeClassPtr, "onActionChange");
			NativeFieldInfoPtr_onActionControlsChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalState>.NativeClassPtr, "onActionControlsChanged");
		}

		public GlobalState(System.IntPtr pointer)
			: base(pointer)
		{
		}

		public GlobalState()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GlobalState>.NativeClassPtr))
		{
		}
	}

	[System.Serializable]
	[ObfuscatedName("UnityEngine.InputSystem.InputActionState+<>c")]
	public sealed class __c : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr___9;

		private static readonly System.IntPtr NativeFieldInfoPtr___9__140_0;

		private static readonly System.IntPtr NativeFieldInfoPtr___9__140_1;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__SaveAndResetState_b__140_0_Internal_Void_byref_GlobalState_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__SaveAndResetState_b__140_1_Internal_Void_0;

		public unsafe static __c __9
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<__c>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe static SavedStructState<GlobalState>.TypedRestore __9__140_0
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9__140_0, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<SavedStructState<GlobalState>.TypedRestore>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9__140_0, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe static Il2CppSystem.Action __9__140_1
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9__140_1, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Action>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9__140_1, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		static __c()
		{
			Il2CppClassPointerStore<__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<InputActionState>.NativeClassPtr, "<>c");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c>.NativeClassPtr);
			NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9");
			NativeFieldInfoPtr___9__140_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9__140_0");
			NativeFieldInfoPtr___9__140_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9__140_1");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100664280);
			NativeMethodInfoPtr__SaveAndResetState_b__140_0_Internal_Void_byref_GlobalState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100664281);
			NativeMethodInfoPtr__SaveAndResetState_b__140_1_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100664282);
		}

		[CallerCount(1950)]
		[CachedScanResults(RefRangeStart = 20036, RefRangeEnd = 21986, XrefRangeStart = 20036, XrefRangeEnd = 21986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__c>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 968688, XrefRangeEnd = 968694, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _SaveAndResetState_b__140_0(ref GlobalState state)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)state);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__SaveAndResetState_b__140_0_Internal_Void_byref_GlobalState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 968694, XrefRangeEnd = 968698, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _SaveAndResetState_b__140_1()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__SaveAndResetState_b__140_1_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		public __c(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	private sealed class MethodInfoStoreGeneric_ReadValue_Internal_TValue_Int32_Int32_Boolean_0<TValue>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_ReadValue_Internal_TValue_Int32_Int32_Boolean_0, Il2CppClassPointerStore<InputActionState>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TValue>.NativeClassPtr)) }))));
	}

	private sealed class MethodInfoStoreGeneric_ApplyProcessors_Internal_TValue_Int32_TValue_InputControl_1_TValue_0<TValue>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_ApplyProcessors_Internal_TValue_Int32_TValue_InputControl_1_TValue_0, Il2CppClassPointerStore<InputActionState>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TValue>.NativeClassPtr)) }))));
	}

	private sealed class MethodInfoStoreGeneric_ReadCompositePartValue_Internal_TValue_Int32_Int32_ptr_Boolean_byref_Int32_TComparer_0<TValue, TComparer>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_ReadCompositePartValue_Internal_TValue_Int32_Int32_ptr_Boolean_byref_Int32_TComparer_0, Il2CppClassPointerStore<InputActionState>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[2]
		{
			Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TValue>.NativeClassPtr)),
			Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TComparer>.NativeClassPtr))
		}))));
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_kInvalidIndex;

	private static readonly System.IntPtr NativeFieldInfoPtr_maps;

	private static readonly System.IntPtr NativeFieldInfoPtr_controls;

	private static readonly System.IntPtr NativeFieldInfoPtr_interactions;

	private static readonly System.IntPtr NativeFieldInfoPtr_processors;

	private static readonly System.IntPtr NativeFieldInfoPtr_composites;

	private static readonly System.IntPtr NativeFieldInfoPtr_totalProcessorCount;

	private static readonly System.IntPtr NativeFieldInfoPtr_memory;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_OnBeforeUpdateHooked;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_OnAfterUpdateHooked;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_InProcessControlStateChange;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_CurrentlyProcessingThisEvent;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_OnBeforeUpdateDelegate;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_OnAfterUpdateDelegate;

	private static readonly System.IntPtr NativeFieldInfoPtr_k_InputInitialActionStateCheckMarker;

	private static readonly System.IntPtr NativeFieldInfoPtr_k_InputActionResolveConflictMarker;

	private static readonly System.IntPtr NativeFieldInfoPtr_k_InputActionCallbackMarker;

	private static readonly System.IntPtr NativeFieldInfoPtr_k_InputOnActionChangeMarker;

	private static readonly System.IntPtr NativeFieldInfoPtr_k_InputOnDeviceChangeMarker;

	private static readonly System.IntPtr NativeFieldInfoPtr_s_GlobalState;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_totalCompositeCount_Public_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_totalMapCount_Public_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_totalActionCount_Public_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_totalBindingCount_Public_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_totalInteractionCount_Public_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_totalControlCount_Public_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_mapIndices_Public_get_ptr_ActionMapIndices_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_actionStates_Public_get_ptr_TriggerState_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_bindingStates_Public_get_ptr_BindingState_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_interactionStates_Public_get_ptr_InteractionState_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_controlIndexToBindingIndex_Public_get_ptr_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_controlGroupingAndComplexity_Public_get_ptr_UInt16_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_controlMagnitudes_Public_get_ptr_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_enabledControls_Public_get_ptr_UInt32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_isProcessingControlStateChange_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Initialize_Public_Void_InputBindingResolver_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ComputeControlGroupingIfNecessary_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ClaimDataFrom_Public_Void_InputBindingResolver_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Destroy_Private_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Clone_Public_InputActionState_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_System_ICloneable_Clone_Private_Virtual_Final_New_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsUsingDevice_Private_Boolean_InputDevice_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CanUseDevice_Private_Boolean_InputDevice_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_HasEnabledActions_Public_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FinishBindingCompositeSetups_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PrepareForBindingReResolution_Internal_Void_Boolean_byref_InputControlList_1_InputControl_byref_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FinishBindingResolution_Public_Void_Boolean_UnmanagedMemory_InputControlList_1_InputControl_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RestoreActionStatesAfterReResolvingBindings_Private_Void_UnmanagedMemory_InputControlList_1_InputControl_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsActiveControl_Private_Boolean_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FindControlIndexOnBinding_Private_Int32_Int32_InputControl_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ResetActionStatesDrivenBy_Private_Void_InputDevice_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsActionBoundToControlFromDevice_Private_Boolean_InputDevice_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ResetActionState_Public_Void_Int32_InputActionPhase_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FetchActionState_Public_byref_TriggerState_InputAction_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FetchMapIndices_Public_ActionMapIndices_InputActionMap_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_EnableAllActions_Public_Void_InputActionMap_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_EnableControls_Private_Void_InputActionMap_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_EnableSingleAction_Public_Void_InputAction_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_EnableControls_Private_Void_InputAction_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DisableAllActions_Public_Void_InputActionMap_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DisableControls_Public_Void_InputActionMap_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DisableSingleAction_Public_Void_InputAction_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DisableControls_Private_Void_InputAction_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_EnableControls_Private_Void_Int32_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DisableControls_Private_Void_Int32_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetInitialStateCheckPending_Public_Void_Int32_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetInitialStateCheckPending_Private_Void_ptr_BindingState_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsControlEnabled_Private_Boolean_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetControlEnabled_Private_Void_Int32_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_HookOnBeforeUpdate_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UnhookOnBeforeUpdate_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnBeforeInitialUpdate_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UnityEngine_InputSystem_LowLevel_IInputStateChangeMonitor_NotifyControlStateChanged_Private_Virtual_Final_New_Void_InputControl_Double_InputEventPtr_Int64_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UnityEngine_InputSystem_LowLevel_IInputStateChangeMonitor_NotifyTimerExpired_Private_Virtual_Final_New_Void_InputControl_Double_Int64_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToCombinedMapAndControlAndBindingIndex_Private_Int64_Int32_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SplitUpMapAndControlAndBindingIndex_Private_Void_Int64_byref_Int32_byref_Int32_byref_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetComplexityFromMonitorIndex_Internal_Static_Int32_Int64_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ProcessControlStateChange_Private_Void_Int32_Int32_Int32_Double_InputEventPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ProcessButtonState_Private_Void_byref_TriggerState_Int32_ptr_BindingState_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ShouldIgnoreInputOnCompositeBinding_Private_Static_Boolean_ptr_BindingState_ptr_InputEvent_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsConflictingInput_Private_Boolean_byref_TriggerState_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetActionBindingStartIndexAndCount_Private_UInt16_Int32_byref_UInt16_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ProcessDefaultInteraction_Private_Void_byref_TriggerState_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ProcessInteractions_Private_Void_byref_TriggerState_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ProcessTimeout_Private_Void_Double_Int32_Int32_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetTotalTimeoutCompletionTime_Internal_Void_Single_byref_TriggerState_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_StartTimeout_Internal_Void_Single_byref_TriggerState_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_StopTimeout_Private_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ChangePhaseOfInteraction_Internal_Void_InputActionPhase_byref_TriggerState_InputActionPhase_InputActionPhase_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ChangePhaseOfAction_Private_Boolean_InputActionPhase_byref_TriggerState_InputActionPhase_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ChangePhaseOfActionInternal_Private_Void_Int32_ptr_TriggerState_InputActionPhase_byref_TriggerState_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CallActionListeners_Private_Void_Int32_InputActionMap_InputActionPhase_byref_CallbackArray_1_Action_1_CallbackContext_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetActionOrNoneString_Private_Object_byref_TriggerState_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetActionOrNull_Internal_InputAction_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetActionOrNull_Internal_InputAction_byref_TriggerState_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetControl_Internal_InputControl_byref_TriggerState_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetInteractionOrNull_Private_IInputInteraction_byref_TriggerState_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetBindingIndexInMap_Internal_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetBindingIndexInState_Internal_Int32_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetBindingState_Internal_byref_BindingState_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetBinding_Internal_byref_InputBinding_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetActionMap_Internal_InputActionMap_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ResetInteractionStateAndCancelIfNecessary_Private_Void_Int32_Int32_Int32_InputActionPhase_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ResetInteractionState_Private_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetValueSizeInBytes_Internal_Int32_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetValueType_Internal_Type_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsActuated_Internal_Static_Boolean_byref_TriggerState_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ReadValue_Internal_Void_Int32_Int32_ptr_Void_Int32_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ReadValue_Internal_TValue_Int32_Int32_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ApplyProcessors_Internal_TValue_Int32_TValue_InputControl_1_TValue_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_EvaluateCompositePartMagnitude_Public_Single_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetCompositePartPressTime_Internal_Double_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ReadCompositePartValue_Internal_TValue_Int32_Int32_ptr_Boolean_byref_Int32_TComparer_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ReadCompositePartValue_Internal_Boolean_Int32_Int32_ptr_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ReadCompositePartValueAsObject_Internal_Object_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ReadValueAsObject_Internal_Object_Int32_Int32_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ReadValueAsButton_Internal_Boolean_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SaveAndResetState_Internal_Static_ISavedState_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddToGlobalList_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RemoveMapFromGlobalList_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CompactGlobalList_Private_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_NotifyListenersOfActionChange_Internal_Void_InputActionChange_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_NotifyListenersOfActionChange_Internal_Static_Void_InputActionChange_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ResetGlobals_Private_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FindAllEnabledActions_Internal_Static_Int32_List_1_InputAction_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnDeviceChange_Internal_Static_Void_InputDevice_InputDeviceChange_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DeferredResolutionOfBindings_Internal_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DisableAllActions_Internal_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DestroyAllActionMapStates_Internal_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe static int kInvalidIndex
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_kInvalidIndex, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_kInvalidIndex, (void*)(&value));
		}
	}

	public unsafe Il2CppReferenceArray<InputActionMap> maps
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maps);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<InputActionMap>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maps)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe Il2CppReferenceArray<InputControl> controls
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_controls);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<InputControl>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_controls)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe Il2CppReferenceArray<IInputInteraction> interactions
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_interactions);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<IInputInteraction>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_interactions)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe Il2CppReferenceArray<InputProcessor> processors
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_processors);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<InputProcessor>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_processors)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe Il2CppReferenceArray<InputBindingComposite> composites
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_composites);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<InputBindingComposite>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_composites)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe int totalProcessorCount
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_totalProcessorCount);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_totalProcessorCount)) = value;
		}
	}

	public unsafe UnmanagedMemory memory
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_memory);
			return *(UnmanagedMemory*)num;
		}
		set
		{
			*(UnmanagedMemory*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_memory)) = value;
		}
	}

	public unsafe bool m_OnBeforeUpdateHooked
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_OnBeforeUpdateHooked);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_OnBeforeUpdateHooked)) = value;
		}
	}

	public unsafe bool m_OnAfterUpdateHooked
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_OnAfterUpdateHooked);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_OnAfterUpdateHooked)) = value;
		}
	}

	public unsafe bool m_InProcessControlStateChange
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_InProcessControlStateChange);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_InProcessControlStateChange)) = value;
		}
	}

	public unsafe InputEventPtr m_CurrentlyProcessingThisEvent
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_CurrentlyProcessingThisEvent);
			return *(InputEventPtr*)num;
		}
		set
		{
			*(InputEventPtr*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_CurrentlyProcessingThisEvent)) = value;
		}
	}

	public unsafe Il2CppSystem.Action m_OnBeforeUpdateDelegate
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_OnBeforeUpdateDelegate);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Action>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_OnBeforeUpdateDelegate)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe Il2CppSystem.Action m_OnAfterUpdateDelegate
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_OnAfterUpdateDelegate);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Action>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_OnAfterUpdateDelegate)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static ProfilerMarker k_InputInitialActionStateCheckMarker
	{
		get
		{
			Unsafe.SkipInit(out ProfilerMarker result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_k_InputInitialActionStateCheckMarker, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_k_InputInitialActionStateCheckMarker, (void*)(&value));
		}
	}

	public unsafe static ProfilerMarker k_InputActionResolveConflictMarker
	{
		get
		{
			Unsafe.SkipInit(out ProfilerMarker result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_k_InputActionResolveConflictMarker, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_k_InputActionResolveConflictMarker, (void*)(&value));
		}
	}

	public unsafe static ProfilerMarker k_InputActionCallbackMarker
	{
		get
		{
			Unsafe.SkipInit(out ProfilerMarker result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_k_InputActionCallbackMarker, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_k_InputActionCallbackMarker, (void*)(&value));
		}
	}

	public unsafe static ProfilerMarker k_InputOnActionChangeMarker
	{
		get
		{
			Unsafe.SkipInit(out ProfilerMarker result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_k_InputOnActionChangeMarker, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_k_InputOnActionChangeMarker, (void*)(&value));
		}
	}

	public unsafe static ProfilerMarker k_InputOnDeviceChangeMarker
	{
		get
		{
			Unsafe.SkipInit(out ProfilerMarker result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_k_InputOnDeviceChangeMarker, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_k_InputOnDeviceChangeMarker, (void*)(&value));
		}
	}

	public unsafe static GlobalState s_GlobalState
	{
		get
		{
			System.IntPtr intPtr = (nint)stackalloc byte[(int)(uint)IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<GlobalState>.NativeClassPtr, ref *(uint*)null)];
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_GlobalState, (void*)intPtr);
			return new GlobalState(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GlobalState>.NativeClassPtr, intPtr));
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_GlobalState, (void*)IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)value)));
		}
	}

	public unsafe int totalCompositeCount
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 87098, RefRangeEnd = 87099, XrefRangeStart = 87098, XrefRangeEnd = 87099, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_totalCompositeCount_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe int totalMapCount
	{
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 174524, RefRangeEnd = 174528, XrefRangeStart = 174524, XrefRangeEnd = 174528, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_totalMapCount_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe int totalActionCount
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_totalActionCount_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe int totalBindingCount
	{
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 148973, RefRangeEnd = 148983, XrefRangeStart = 148973, XrefRangeEnd = 148983, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_totalBindingCount_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe int totalInteractionCount
	{
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 180373, RefRangeEnd = 180378, XrefRangeStart = 180373, XrefRangeEnd = 180378, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_totalInteractionCount_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe int totalControlCount
	{
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 41565, RefRangeEnd = 41568, XrefRangeStart = 41565, XrefRangeEnd = 41568, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_totalControlCount_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe ActionMapIndices* mapIndices
	{
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 329742, RefRangeEnd = 329745, XrefRangeStart = 329742, XrefRangeEnd = 329745, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr result = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_mapIndices_Public_get_ptr_ActionMapIndices_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (ActionMapIndices*)result;
		}
	}

	public unsafe TriggerState* actionStates
	{
		[CallerCount(45)]
		[CachedScanResults(RefRangeStart = 162634, RefRangeEnd = 162679, XrefRangeStart = 162634, XrefRangeEnd = 162679, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr result = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_actionStates_Public_get_ptr_TriggerState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (TriggerState*)result;
		}
	}

	public unsafe BindingState* bindingStates
	{
		[CallerCount(17)]
		[CachedScanResults(RefRangeStart = 140862, RefRangeEnd = 140879, XrefRangeStart = 140862, XrefRangeEnd = 140879, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr result = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_bindingStates_Public_get_ptr_BindingState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (BindingState*)result;
		}
	}

	public unsafe InteractionState* interactionStates
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 140861, RefRangeEnd = 140862, XrefRangeStart = 140861, XrefRangeEnd = 140862, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr result = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_interactionStates_Public_get_ptr_InteractionState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (InteractionState*)result;
		}
	}

	public unsafe int* controlIndexToBindingIndex
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 202046, RefRangeEnd = 202047, XrefRangeStart = 202046, XrefRangeEnd = 202047, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr result = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_controlIndexToBindingIndex_Public_get_ptr_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (int*)result;
		}
	}

	public unsafe ushort* controlGroupingAndComplexity
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr result = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_controlGroupingAndComplexity_Public_get_ptr_UInt16_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (ushort*)result;
		}
	}

	public unsafe float* controlMagnitudes
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr result = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_controlMagnitudes_Public_get_ptr_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (float*)result;
		}
	}

	public unsafe uint* enabledControls
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr result = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_enabledControls_Public_get_ptr_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (uint*)result;
		}
	}

	public unsafe bool isProcessingControlStateChange
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_isProcessingControlStateChange_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	static InputActionState()
	{
		Il2CppClassPointerStore<InputActionState>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.InputSystem.dll", "UnityEngine.InputSystem", "InputActionState");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InputActionState>.NativeClassPtr);
		NativeFieldInfoPtr_kInvalidIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputActionState>.NativeClassPtr, "kInvalidIndex");
		NativeFieldInfoPtr_maps = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputActionState>.NativeClassPtr, "maps");
		NativeFieldInfoPtr_controls = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputActionState>.NativeClassPtr, "controls");
		NativeFieldInfoPtr_interactions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputActionState>.NativeClassPtr, "interactions");
		NativeFieldInfoPtr_processors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputActionState>.NativeClassPtr, "processors");
		NativeFieldInfoPtr_composites = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputActionState>.NativeClassPtr, "composites");
		NativeFieldInfoPtr_totalProcessorCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputActionState>.NativeClassPtr, "totalProcessorCount");
		NativeFieldInfoPtr_memory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputActionState>.NativeClassPtr, "memory");
		NativeFieldInfoPtr_m_OnBeforeUpdateHooked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputActionState>.NativeClassPtr, "m_OnBeforeUpdateHooked");
		NativeFieldInfoPtr_m_OnAfterUpdateHooked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputActionState>.NativeClassPtr, "m_OnAfterUpdateHooked");
		NativeFieldInfoPtr_m_InProcessControlStateChange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputActionState>.NativeClassPtr, "m_InProcessControlStateChange");
		NativeFieldInfoPtr_m_CurrentlyProcessingThisEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputActionState>.NativeClassPtr, "m_CurrentlyProcessingThisEvent");
		NativeFieldInfoPtr_m_OnBeforeUpdateDelegate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputActionState>.NativeClassPtr, "m_OnBeforeUpdateDelegate");
		NativeFieldInfoPtr_m_OnAfterUpdateDelegate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputActionState>.NativeClassPtr, "m_OnAfterUpdateDelegate");
		NativeFieldInfoPtr_k_InputInitialActionStateCheckMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputActionState>.NativeClassPtr, "k_InputInitialActionStateCheckMarker");
		NativeFieldInfoPtr_k_InputActionResolveConflictMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputActionState>.NativeClassPtr, "k_InputActionResolveConflictMarker");
		NativeFieldInfoPtr_k_InputActionCallbackMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputActionState>.NativeClassPtr, "k_InputActionCallbackMarker");
		NativeFieldInfoPtr_k_InputOnActionChangeMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputActionState>.NativeClassPtr, "k_InputOnActionChangeMarker");
		NativeFieldInfoPtr_k_InputOnDeviceChangeMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputActionState>.NativeClassPtr, "k_InputOnDeviceChangeMarker");
		NativeFieldInfoPtr_s_GlobalState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputActionState>.NativeClassPtr, "s_GlobalState");
		NativeMethodInfoPtr_get_totalCompositeCount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputActionState>.NativeClassPtr, 100664054);
		NativeMethodInfoPtr_get_totalMapCount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputActionState>.NativeClassPtr, 100664055);
		NativeMethodInfoPtr_get_totalActionCount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputActionState>.NativeClassPtr, 100664056);
		NativeMethodInfoPtr_get_totalBindingCount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputActionState>.NativeClassPtr, 100664057);
		NativeMethodInfoPtr_get_totalInteractionCount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputActionState>.NativeClassPtr, 100664058);
		NativeMethodInfoPtr_get_totalControlCount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputActionState>.NativeClassPtr, 100664059);
		NativeMethodInfoPtr_get_mapIndices_Public_get_ptr_ActionMapIndices_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputActionState>.NativeClassPtr, 100664060);
		NativeMethodInfoPtr_get_actionStates_Public_get_ptr_TriggerState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputActionState>.NativeClassPtr, 100664061);
		NativeMethodInfoPtr_get_bindingStates_Public_get_ptr_BindingState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputActionState>.NativeClassPtr, 100664062);
		NativeMethodInfoPtr_get_interactionStates_Public_get_ptr_InteractionState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputActionState>.NativeClassPtr, 100664063);
		NativeMethodInfoPtr_get_controlIndexToBindingIndex_Public_get_ptr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputActionState>.NativeClassPtr, 100664064);
		NativeMethodInfoPtr_get_controlGroupingAndComplexity_Public_get_ptr_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputActionState>.NativeClassPtr, 100664065);
		NativeMethodInfoPtr_get_controlMagnitudes_Public_get_ptr_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputActionState>.NativeClassPtr, 100664066);
		NativeMethodInfoPtr_get_enabledControls_Public_get_ptr_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputActionState>.NativeClassPtr, 100664067);
		NativeMethodInfoPtr_get_isProcessingControlStateChange_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputActionState>.NativeClassPtr, 100664068);
		NativeMethodInfoPtr_Initialize_Public_Void_InputBindingResolver_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputActionState>.NativeClassPtr, 100664069);
		NativeMethodInfoPtr_ComputeControlGroupingIfNecessary_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputActionState>.NativeClassPtr, 100664070);
		NativeMethodInfoPtr_ClaimDataFrom_Public_Void_InputBindingResolver_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputActionState>.NativeClassPtr, 100664071);
		NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputActionState>.NativeClassPtr, 100664072);
		NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputActionState>.NativeClassPtr, 100664073);
		NativeMethodInfoPtr_Destroy_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputActionState>.NativeClassPtr, 100664074);
		NativeMethodInfoPtr_Clone_Public_InputActionState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputActionState>.NativeClassPtr, 100664075);
		NativeMethodInfoPtr_System_ICloneable_Clone_Private_Virtual_Final_New_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputActionState>.NativeClassPtr, 100664076);
		NativeMethodInfoPtr_IsUsingDevice_Private_Boolean_InputDevice_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputActionState>.NativeClassPtr, 100664077);
		NativeMethodInfoPtr_CanUseDevice_Private_Boolean_InputDevice_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputActionState>.NativeClassPtr, 100664078);
		NativeMethodInfoPtr_HasEnabledActions_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputActionState>.NativeClassPtr, 100664079);
		NativeMethodInfoPtr_FinishBindingCompositeSetups_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputActionState>.NativeClassPtr, 100664080);
		NativeMethodInfoPtr_PrepareForBindingReResolution_Internal_Void_Boolean_byref_InputControlList_1_InputControl_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputActionState>.NativeClassPtr, 100664081);
		NativeMethodInfoPtr_FinishBindingResolution_Public_Void_Boolean_UnmanagedMemory_InputControlList_1_InputControl_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputActionState>.NativeClassPtr, 100664082);
		NativeMethodInfoPtr_RestoreActionStatesAfterReResolvingBindings_Private_Void_UnmanagedMemory_InputControlList_1_InputControl_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputActionState>.NativeClassPtr, 100664083);
		NativeMethodInfoPtr_IsActiveControl_Private_Boolean_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputActionState>.NativeClassPtr, 100664084);
		NativeMethodInfoPtr_FindControlIndexOnBinding_Private_Int32_Int32_InputControl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputActionState>.NativeClassPtr, 100664085);
		NativeMethodInfoPtr_ResetActionStatesDrivenBy_Private_Void_InputDevice_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputActionState>.NativeClassPtr, 100664086);
		NativeMethodInfoPtr_IsActionBoundToControlFromDevice_Private_Boolean_InputDevice_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputActionState>.NativeClassPtr, 100664087);
		NativeMethodInfoPtr_ResetActionState_Public_Void_Int32_InputActionPhase_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputActionState>.NativeClassPtr, 100664088);
		NativeMethodInfoPtr_FetchActionState_Public_byref_TriggerState_InputAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputActionState>.NativeClassPtr, 100664089);
		NativeMethodInfoPtr_FetchMapIndices_Public_ActionMapIndices_InputActionMap_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputActionState>.NativeClassPtr, 100664090);
		NativeMethodInfoPtr_EnableAllActions_Public_Void_InputActionMap_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputActionState>.NativeClassPtr, 100664091);
		NativeMethodInfoPtr_EnableControls_Private_Void_InputActionMap_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputActionState>.NativeClassPtr, 100664092);
		NativeMethodInfoPtr_EnableSingleAction_Public_Void_InputAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputActionState>.NativeClassPtr, 100664093);
		NativeMethodInfoPtr_EnableControls_Private_Void_InputAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputActionState>.NativeClassPtr, 100664094);
		NativeMethodInfoPtr_DisableAllActions_Public_Void_InputActionMap_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputActionState>.NativeClassPtr, 100664095);
		NativeMethodInfoPtr_DisableControls_Public_Void_InputActionMap_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputActionState>.NativeClassPtr, 100664096);
		NativeMethodInfoPtr_DisableSingleAction_Public_Void_InputAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputActionState>.NativeClassPtr, 100664097);
		NativeMethodInfoPtr_DisableControls_Private_Void_InputAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputActionState>.NativeClassPtr, 100664098);
		NativeMethodInfoPtr_EnableControls_Private_Void_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputActionState>.NativeClassPtr, 100664099);
		NativeMethodInfoPtr_DisableControls_Private_Void_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputActionState>.NativeClassPtr, 100664100);
		NativeMethodInfoPtr_SetInitialStateCheckPending_Public_Void_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputActionState>.NativeClassPtr, 100664101);
		NativeMethodInfoPtr_SetInitialStateCheckPending_Private_Void_ptr_BindingState_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputActionState>.NativeClassPtr, 100664102);
		NativeMethodInfoPtr_IsControlEnabled_Private_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputActionState>.NativeClassPtr, 100664103);
		NativeMethodInfoPtr_SetControlEnabled_Private_Void_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputActionState>.NativeClassPtr, 100664104);
		NativeMethodInfoPtr_HookOnBeforeUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputActionState>.NativeClassPtr, 100664105);
		NativeMethodInfoPtr_UnhookOnBeforeUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputActionState>.NativeClassPtr, 100664106);
		NativeMethodInfoPtr_OnBeforeInitialUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputActionState>.NativeClassPtr, 100664107);
		NativeMethodInfoPtr_UnityEngine_InputSystem_LowLevel_IInputStateChangeMonitor_NotifyControlStateChanged_Private_Virtual_Final_New_Void_InputControl_Double_InputEventPtr_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputActionState>.NativeClassPtr, 100664108);
		NativeMethodInfoPtr_UnityEngine_InputSystem_LowLevel_IInputStateChangeMonitor_NotifyTimerExpired_Private_Virtual_Final_New_Void_InputControl_Double_Int64_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputActionState>.NativeClassPtr, 100664109);
		NativeMethodInfoPtr_ToCombinedMapAndControlAndBindingIndex_Private_Int64_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputActionState>.NativeClassPtr, 100664110);
		NativeMethodInfoPtr_SplitUpMapAndControlAndBindingIndex_Private_Void_Int64_byref_Int32_byref_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputActionState>.NativeClassPtr, 100664111);
		NativeMethodInfoPtr_GetComplexityFromMonitorIndex_Internal_Static_Int32_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputActionState>.NativeClassPtr, 100664112);
		NativeMethodInfoPtr_ProcessControlStateChange_Private_Void_Int32_Int32_Int32_Double_InputEventPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputActionState>.NativeClassPtr, 100664113);
		NativeMethodInfoPtr_ProcessButtonState_Private_Void_byref_TriggerState_Int32_ptr_BindingState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputActionState>.NativeClassPtr, 100664114);
		NativeMethodInfoPtr_ShouldIgnoreInputOnCompositeBinding_Private_Static_Boolean_ptr_BindingState_ptr_InputEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputActionState>.NativeClassPtr, 100664115);
		NativeMethodInfoPtr_IsConflictingInput_Private_Boolean_byref_TriggerState_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputActionState>.NativeClassPtr, 100664116);
		NativeMethodInfoPtr_GetActionBindingStartIndexAndCount_Private_UInt16_Int32_byref_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputActionState>.NativeClassPtr, 100664117);
		NativeMethodInfoPtr_ProcessDefaultInteraction_Private_Void_byref_TriggerState_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputActionState>.NativeClassPtr, 100664118);
		NativeMethodInfoPtr_ProcessInteractions_Private_Void_byref_TriggerState_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputActionState>.NativeClassPtr, 100664119);
		NativeMethodInfoPtr_ProcessTimeout_Private_Void_Double_Int32_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputActionState>.NativeClassPtr, 100664120);
		NativeMethodInfoPtr_SetTotalTimeoutCompletionTime_Internal_Void_Single_byref_TriggerState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputActionState>.NativeClassPtr, 100664121);
		NativeMethodInfoPtr_StartTimeout_Internal_Void_Single_byref_TriggerState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputActionState>.NativeClassPtr, 100664122);
		NativeMethodInfoPtr_StopTimeout_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputActionState>.NativeClassPtr, 100664123);
		NativeMethodInfoPtr_ChangePhaseOfInteraction_Internal_Void_InputActionPhase_byref_TriggerState_InputActionPhase_InputActionPhase_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputActionState>.NativeClassPtr, 100664124);
		NativeMethodInfoPtr_ChangePhaseOfAction_Private_Boolean_InputActionPhase_byref_TriggerState_InputActionPhase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputActionState>.NativeClassPtr, 100664125);
		NativeMethodInfoPtr_ChangePhaseOfActionInternal_Private_Void_Int32_ptr_TriggerState_InputActionPhase_byref_TriggerState_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputActionState>.NativeClassPtr, 100664126);
		NativeMethodInfoPtr_CallActionListeners_Private_Void_Int32_InputActionMap_InputActionPhase_byref_CallbackArray_1_Action_1_CallbackContext_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputActionState>.NativeClassPtr, 100664127);
		NativeMethodInfoPtr_GetActionOrNoneString_Private_Object_byref_TriggerState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputActionState>.NativeClassPtr, 100664128);
		NativeMethodInfoPtr_GetActionOrNull_Internal_InputAction_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputActionState>.NativeClassPtr, 100664129);
		NativeMethodInfoPtr_GetActionOrNull_Internal_InputAction_byref_TriggerState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputActionState>.NativeClassPtr, 100664130);
		NativeMethodInfoPtr_GetControl_Internal_InputControl_byref_TriggerState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputActionState>.NativeClassPtr, 100664131);
		NativeMethodInfoPtr_GetInteractionOrNull_Private_IInputInteraction_byref_TriggerState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputActionState>.NativeClassPtr, 100664132);
		NativeMethodInfoPtr_GetBindingIndexInMap_Internal_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputActionState>.NativeClassPtr, 100664133);
		NativeMethodInfoPtr_GetBindingIndexInState_Internal_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputActionState>.NativeClassPtr, 100664134);
		NativeMethodInfoPtr_GetBindingState_Internal_byref_BindingState_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputActionState>.NativeClassPtr, 100664135);
		NativeMethodInfoPtr_GetBinding_Internal_byref_InputBinding_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputActionState>.NativeClassPtr, 100664136);
		NativeMethodInfoPtr_GetActionMap_Internal_InputActionMap_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputActionState>.NativeClassPtr, 100664137);
		NativeMethodInfoPtr_ResetInteractionStateAndCancelIfNecessary_Private_Void_Int32_Int32_Int32_InputActionPhase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputActionState>.NativeClassPtr, 100664138);
		NativeMethodInfoPtr_ResetInteractionState_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputActionState>.NativeClassPtr, 100664139);
		NativeMethodInfoPtr_GetValueSizeInBytes_Internal_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputActionState>.NativeClassPtr, 100664140);
		NativeMethodInfoPtr_GetValueType_Internal_Type_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputActionState>.NativeClassPtr, 100664141);
		NativeMethodInfoPtr_IsActuated_Internal_Static_Boolean_byref_TriggerState_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputActionState>.NativeClassPtr, 100664142);
		NativeMethodInfoPtr_ReadValue_Internal_Void_Int32_Int32_ptr_Void_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputActionState>.NativeClassPtr, 100664143);
		NativeMethodInfoPtr_ReadValue_Internal_TValue_Int32_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputActionState>.NativeClassPtr, 100664144);
		NativeMethodInfoPtr_ApplyProcessors_Internal_TValue_Int32_TValue_InputControl_1_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputActionState>.NativeClassPtr, 100664145);
		NativeMethodInfoPtr_EvaluateCompositePartMagnitude_Public_Single_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputActionState>.NativeClassPtr, 100664146);
		NativeMethodInfoPtr_GetCompositePartPressTime_Internal_Double_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputActionState>.NativeClassPtr, 100664147);
		NativeMethodInfoPtr_ReadCompositePartValue_Internal_TValue_Int32_Int32_ptr_Boolean_byref_Int32_TComparer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputActionState>.NativeClassPtr, 100664148);
		NativeMethodInfoPtr_ReadCompositePartValue_Internal_Boolean_Int32_Int32_ptr_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputActionState>.NativeClassPtr, 100664149);
		NativeMethodInfoPtr_ReadCompositePartValueAsObject_Internal_Object_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputActionState>.NativeClassPtr, 100664150);
		NativeMethodInfoPtr_ReadValueAsObject_Internal_Object_Int32_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputActionState>.NativeClassPtr, 100664151);
		NativeMethodInfoPtr_ReadValueAsButton_Internal_Boolean_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputActionState>.NativeClassPtr, 100664152);
		NativeMethodInfoPtr_SaveAndResetState_Internal_Static_ISavedState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputActionState>.NativeClassPtr, 100664153);
		NativeMethodInfoPtr_AddToGlobalList_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputActionState>.NativeClassPtr, 100664154);
		NativeMethodInfoPtr_RemoveMapFromGlobalList_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputActionState>.NativeClassPtr, 100664155);
		NativeMethodInfoPtr_CompactGlobalList_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputActionState>.NativeClassPtr, 100664156);
		NativeMethodInfoPtr_NotifyListenersOfActionChange_Internal_Void_InputActionChange_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputActionState>.NativeClassPtr, 100664157);
		NativeMethodInfoPtr_NotifyListenersOfActionChange_Internal_Static_Void_InputActionChange_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputActionState>.NativeClassPtr, 100664158);
		NativeMethodInfoPtr_ResetGlobals_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputActionState>.NativeClassPtr, 100664159);
		NativeMethodInfoPtr_FindAllEnabledActions_Internal_Static_Int32_List_1_InputAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputActionState>.NativeClassPtr, 100664160);
		NativeMethodInfoPtr_OnDeviceChange_Internal_Static_Void_InputDevice_InputDeviceChange_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputActionState>.NativeClassPtr, 100664161);
		NativeMethodInfoPtr_DeferredResolutionOfBindings_Internal_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputActionState>.NativeClassPtr, 100664162);
		NativeMethodInfoPtr_DisableAllActions_Internal_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputActionState>.NativeClassPtr, 100664163);
		NativeMethodInfoPtr_DestroyAllActionMapStates_Internal_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputActionState>.NativeClassPtr, 100664164);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputActionState>.NativeClassPtr, 100664165);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 968705, RefRangeEnd = 968706, XrefRangeStart = 968698, XrefRangeEnd = 968705, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Initialize(InputBindingResolver resolver)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)resolver));
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Initialize_Public_Void_InputBindingResolver_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 968712, RefRangeEnd = 968714, XrefRangeStart = 968706, XrefRangeEnd = 968712, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ComputeControlGroupingIfNecessary()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ComputeControlGroupingIfNecessary_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 968720, RefRangeEnd = 968721, XrefRangeStart = 968714, XrefRangeEnd = 968720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ClaimDataFrom(InputBindingResolver resolver)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)resolver));
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ClaimDataFrom_Public_Void_InputBindingResolver_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 968721, XrefRangeEnd = 968726, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public new unsafe void Finalize()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 968727, RefRangeEnd = 968731, XrefRangeStart = 968726, XrefRangeEnd = 968727, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void Dispose()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 968765, RefRangeEnd = 968768, XrefRangeStart = 968731, XrefRangeEnd = 968765, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Destroy(bool isFinalizing = false)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&isFinalizing);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Destroy_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 968793, RefRangeEnd = 968794, XrefRangeStart = 968768, XrefRangeEnd = 968793, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe InputActionState Clone()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Clone_Public_InputActionState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<InputActionState>(intPtr2) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 968793, RefRangeEnd = 968794, XrefRangeStart = 968793, XrefRangeEnd = 968794, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual Il2CppSystem.Object System_ICloneable_Clone()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_System_ICloneable_Clone_Private_Virtual_Final_New_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 968806, RefRangeEnd = 968809, XrefRangeStart = 968794, XrefRangeEnd = 968806, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool IsUsingDevice(InputDevice device)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)device);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsUsingDevice_Private_Boolean_InputDevice_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 968822, RefRangeEnd = 968824, XrefRangeStart = 968809, XrefRangeEnd = 968822, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool CanUseDevice(InputDevice device)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)device);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CanUseDevice_Private_Boolean_InputDevice_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 968824, XrefRangeEnd = 968825, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool HasEnabledActions()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_HasEnabledActions_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 968825, XrefRangeEnd = 968826, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void FinishBindingCompositeSetups()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FinishBindingCompositeSetups_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 968873, RefRangeEnd = 968874, XrefRangeStart = 968826, XrefRangeEnd = 968873, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void PrepareForBindingReResolution(bool needFullResolve, ref InputControlList<InputControl> activeControls, ref bool hasEnabledActions)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&needFullResolve);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)activeControls);
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref hasEnabledActions);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PrepareForBindingReResolution_Internal_Void_Boolean_byref_InputControlList_1_InputControl_byref_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 968878, RefRangeEnd = 968879, XrefRangeStart = 968874, XrefRangeEnd = 968878, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void FinishBindingResolution(bool hasEnabledActions, UnmanagedMemory oldMemory, InputControlList<InputControl> activeControls, bool isFullResolve)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&hasEnabledActions);
		*(UnmanagedMemory**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &oldMemory;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)activeControls));
		*(bool**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &isFullResolve;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FinishBindingResolution_Public_Void_Boolean_UnmanagedMemory_InputControlList_1_InputControl_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 968943, RefRangeEnd = 968944, XrefRangeStart = 968879, XrefRangeEnd = 968943, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RestoreActionStatesAfterReResolvingBindings(UnmanagedMemory oldState, InputControlList<InputControl> activeControls, bool isFullResolve)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&oldState);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)activeControls));
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &isFullResolve;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RestoreActionStatesAfterReResolvingBindings_Private_Void_UnmanagedMemory_InputControlList_1_InputControl_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 968945, RefRangeEnd = 968946, XrefRangeStart = 968944, XrefRangeEnd = 968945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool IsActiveControl(int bindingIndex, int controlIndex)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&bindingIndex);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &controlIndex;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsActiveControl_Private_Boolean_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 968946, RefRangeEnd = 968948, XrefRangeStart = 968946, XrefRangeEnd = 968946, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int FindControlIndexOnBinding(int bindingIndex, InputControl control)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&bindingIndex);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)control);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FindControlIndexOnBinding_Private_Int32_Int32_InputControl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 968959, RefRangeEnd = 968960, XrefRangeStart = 968948, XrefRangeEnd = 968959, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ResetActionStatesDrivenBy(InputDevice device)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)device);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ResetActionStatesDrivenBy_Private_Void_InputDevice_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 968961, RefRangeEnd = 968962, XrefRangeStart = 968960, XrefRangeEnd = 968961, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool IsActionBoundToControlFromDevice(InputDevice device, int actionIndex)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)device);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &actionIndex;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsActionBoundToControlFromDevice_Private_Boolean_InputDevice_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 968971, RefRangeEnd = 968976, XrefRangeStart = 968962, XrefRangeEnd = 968971, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ResetActionState(int actionIndex, InputActionPhase toPhase = InputActionPhase.Waiting, bool hardReset = false)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&actionIndex);
		*(InputActionPhase**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &toPhase;
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &hardReset;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ResetActionState_Public_Void_Int32_InputActionPhase_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(9)]
	[CachedScanResults(RefRangeStart = 968976, RefRangeEnd = 968985, XrefRangeStart = 968976, XrefRangeEnd = 968976, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ref TriggerState FetchActionState(InputAction action)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)action);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FetchActionState_Public_byref_TriggerState_InputAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return ref *(TriggerState*)intPtr2;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 968985, RefRangeEnd = 968986, XrefRangeStart = 968985, XrefRangeEnd = 968985, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ActionMapIndices FetchMapIndices(InputActionMap map)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)map);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FetchMapIndices_Public_ActionMapIndices_InputActionMap_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(ActionMapIndices*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 969003, RefRangeEnd = 969005, XrefRangeStart = 968986, XrefRangeEnd = 969003, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void EnableAllActions(InputActionMap map)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)map);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_EnableAllActions_Public_Void_InputActionMap_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 969005, XrefRangeEnd = 969006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void EnableControls(InputActionMap map)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)map);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_EnableControls_Private_Void_InputActionMap_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 969014, RefRangeEnd = 969015, XrefRangeStart = 969006, XrefRangeEnd = 969014, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void EnableSingleAction(InputAction action)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)action);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_EnableSingleAction_Public_Void_InputAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 969015, XrefRangeEnd = 969017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void EnableControls(InputAction action)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)action);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_EnableControls_Private_Void_InputAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 969037, RefRangeEnd = 969040, XrefRangeStart = 969017, XrefRangeEnd = 969037, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void DisableAllActions(InputActionMap map)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)map);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DisableAllActions_Public_Void_InputActionMap_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 969041, RefRangeEnd = 969042, XrefRangeStart = 969040, XrefRangeEnd = 969041, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void DisableControls(InputActionMap map)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)map);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DisableControls_Public_Void_InputActionMap_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 969050, RefRangeEnd = 969051, XrefRangeStart = 969042, XrefRangeEnd = 969050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void DisableSingleAction(InputAction action)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)action);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DisableSingleAction_Public_Void_InputAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 969051, XrefRangeEnd = 969053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void DisableControls(InputAction action)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)action);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DisableControls_Private_Void_InputAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 969060, RefRangeEnd = 969065, XrefRangeStart = 969053, XrefRangeEnd = 969060, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void EnableControls(int mapIndex, int controlStartIndex, int numControls)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&mapIndex);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &controlStartIndex;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &numControls;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_EnableControls_Private_Void_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 969072, RefRangeEnd = 969077, XrefRangeStart = 969065, XrefRangeEnd = 969072, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void DisableControls(int mapIndex, int controlStartIndex, int numControls)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&mapIndex);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &controlStartIndex;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &numControls;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DisableControls_Private_Void_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 969079, RefRangeEnd = 969081, XrefRangeStart = 969077, XrefRangeEnd = 969079, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetInitialStateCheckPending(int actionIndex, bool value = true)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&actionIndex);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &value;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetInitialStateCheckPending_Public_Void_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 969081, XrefRangeEnd = 969082, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetInitialStateCheckPending(BindingState* bindingStatePtr, bool value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)bindingStatePtr;
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &value;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetInitialStateCheckPending_Private_Void_ptr_BindingState_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	public unsafe bool IsControlEnabled(int controlIndex)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&controlIndex);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsControlEnabled_Private_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe void SetControlEnabled(int controlIndex, bool state)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&controlIndex);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &state;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetControlEnabled_Private_Void_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 969094, RefRangeEnd = 969097, XrefRangeStart = 969082, XrefRangeEnd = 969094, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void HookOnBeforeUpdate()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_HookOnBeforeUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 969097, XrefRangeEnd = 969102, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UnhookOnBeforeUpdate()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UnhookOnBeforeUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 969102, XrefRangeEnd = 969120, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnBeforeInitialUpdate()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnBeforeInitialUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 969120, XrefRangeEnd = 969121, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void UnityEngine_InputSystem_LowLevel_IInputStateChangeMonitor_NotifyControlStateChanged(InputControl control, double time, InputEventPtr eventPtr, long mapControlAndBindingIndex)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)control);
		*(double**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &time;
		*(InputEventPtr**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &eventPtr;
		*(long**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &mapControlAndBindingIndex;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UnityEngine_InputSystem_LowLevel_IInputStateChangeMonitor_NotifyControlStateChanged_Private_Virtual_Final_New_Void_InputControl_Double_InputEventPtr_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 969121, XrefRangeEnd = 969122, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void UnityEngine_InputSystem_LowLevel_IInputStateChangeMonitor_NotifyTimerExpired(InputControl control, double time, long mapControlAndBindingIndex, int interactionIndex)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)control);
		*(double**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &time;
		*(long**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &mapControlAndBindingIndex;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &interactionIndex;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UnityEngine_InputSystem_LowLevel_IInputStateChangeMonitor_NotifyTimerExpired_Private_Virtual_Final_New_Void_InputControl_Double_Int64_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	public unsafe long ToCombinedMapAndControlAndBindingIndex(int mapIndex, int controlIndex, int bindingIndex)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&mapIndex);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &controlIndex;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &bindingIndex;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToCombinedMapAndControlAndBindingIndex_Private_Int64_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(long*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe void SplitUpMapAndControlAndBindingIndex(long mapControlAndBindingIndex, out int mapIndex, out int controlIndex, out int bindingIndex)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&mapControlAndBindingIndex);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref mapIndex);
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref controlIndex);
		*(void**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref bindingIndex);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SplitUpMapAndControlAndBindingIndex_Private_Void_Int64_byref_Int32_byref_Int32_byref_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 969122, RefRangeEnd = 969124, XrefRangeStart = 969122, XrefRangeEnd = 969122, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int GetComplexityFromMonitorIndex(long mapControlAndBindingIndex)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&mapControlAndBindingIndex);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetComplexityFromMonitorIndex_Internal_Static_Int32_Int64_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 969160, RefRangeEnd = 969161, XrefRangeStart = 969124, XrefRangeEnd = 969160, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ProcessControlStateChange(int mapIndex, int controlIndex, int bindingIndex, double time, InputEventPtr eventPtr)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = (nint)(&mapIndex);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &controlIndex;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &bindingIndex;
		*(double**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &time;
		*(InputEventPtr**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &eventPtr;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ProcessControlStateChange_Private_Void_Int32_Int32_Int32_Double_InputEventPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 969172, RefRangeEnd = 969173, XrefRangeStart = 969161, XrefRangeEnd = 969172, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ProcessButtonState(ref TriggerState trigger, int actionIndex, BindingState* bindingStatePtr)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)Unsafe.AsPointer(ref trigger);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &actionIndex;
		*(BindingState**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = bindingStatePtr;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ProcessButtonState_Private_Void_byref_TriggerState_Int32_ptr_BindingState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 969173, XrefRangeEnd = 969174, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool ShouldIgnoreInputOnCompositeBinding(BindingState* binding, InputEvent* eventPtr)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)binding;
		*(InputEvent**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = eventPtr;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ShouldIgnoreInputOnCompositeBinding_Private_Static_Boolean_ptr_BindingState_ptr_InputEvent_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 969199, RefRangeEnd = 969200, XrefRangeStart = 969174, XrefRangeEnd = 969199, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool IsConflictingInput(ref TriggerState trigger, int actionIndex)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)Unsafe.AsPointer(ref trigger);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &actionIndex;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsConflictingInput_Private_Boolean_byref_TriggerState_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe ushort GetActionBindingStartIndexAndCount(int actionIndex, out ushort bindingCount)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&actionIndex);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref bindingCount);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetActionBindingStartIndexAndCount_Private_UInt16_Int32_byref_UInt16_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(ushort*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 969232, RefRangeEnd = 969233, XrefRangeStart = 969200, XrefRangeEnd = 969232, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ProcessDefaultInteraction(ref TriggerState trigger, int actionIndex)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)Unsafe.AsPointer(ref trigger);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &actionIndex;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ProcessDefaultInteraction_Private_Void_byref_TriggerState_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 969238, RefRangeEnd = 969240, XrefRangeStart = 969233, XrefRangeEnd = 969238, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ProcessInteractions(ref TriggerState trigger, int interactionStartIndex, int interactionCount)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)Unsafe.AsPointer(ref trigger);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &interactionStartIndex;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &interactionCount;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ProcessInteractions_Private_Void_byref_TriggerState_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 969247, RefRangeEnd = 969248, XrefRangeStart = 969240, XrefRangeEnd = 969247, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ProcessTimeout(double time, int mapIndex, int controlIndex, int bindingIndex, int interactionIndex)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = (nint)(&time);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &mapIndex;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &controlIndex;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &bindingIndex;
		*(int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &interactionIndex;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ProcessTimeout_Private_Void_Double_Int32_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 969249, RefRangeEnd = 969250, XrefRangeStart = 969248, XrefRangeEnd = 969249, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetTotalTimeoutCompletionTime(float seconds, ref TriggerState trigger)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&seconds);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref trigger);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetTotalTimeoutCompletionTime_Internal_Void_Single_byref_TriggerState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 969258, RefRangeEnd = 969260, XrefRangeStart = 969250, XrefRangeEnd = 969258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void StartTimeout(float seconds, ref TriggerState trigger)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&seconds);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref trigger);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_StartTimeout_Internal_Void_Single_byref_TriggerState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 969265, RefRangeEnd = 969268, XrefRangeStart = 969260, XrefRangeEnd = 969265, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void StopTimeout(int interactionIndex)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&interactionIndex);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_StopTimeout_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(8)]
	[CachedScanResults(RefRangeStart = 969301, RefRangeEnd = 969309, XrefRangeStart = 969268, XrefRangeEnd = 969301, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ChangePhaseOfInteraction(InputActionPhase newPhase, ref TriggerState trigger, InputActionPhase phaseAfterPerformed = InputActionPhase.Waiting, InputActionPhase phaseAfterCanceled = InputActionPhase.Waiting, bool processNextInteractionOnCancel = true)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = (nint)(&newPhase);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref trigger);
		*(InputActionPhase**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &phaseAfterPerformed;
		*(InputActionPhase**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &phaseAfterCanceled;
		*(bool**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &processNextInteractionOnCancel;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ChangePhaseOfInteraction_Internal_Void_InputActionPhase_byref_TriggerState_InputActionPhase_InputActionPhase_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(9)]
	[CachedScanResults(RefRangeStart = 969323, RefRangeEnd = 969332, XrefRangeStart = 969309, XrefRangeEnd = 969323, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool ChangePhaseOfAction(InputActionPhase newPhase, ref TriggerState trigger, InputActionPhase phaseAfterPerformedOrCanceled = InputActionPhase.Waiting)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&newPhase);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref trigger);
		*(InputActionPhase**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &phaseAfterPerformedOrCanceled;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ChangePhaseOfAction_Private_Boolean_InputActionPhase_byref_TriggerState_InputActionPhase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 969353, RefRangeEnd = 969358, XrefRangeStart = 969332, XrefRangeEnd = 969353, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ChangePhaseOfActionInternal(int actionIndex, TriggerState* actionState, InputActionPhase newPhase, ref TriggerState trigger, bool isDisablingAction = false)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = (nint)(&actionIndex);
		*(TriggerState**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = actionState;
		*(InputActionPhase**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &newPhase;
		*(void**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref trigger);
		*(bool**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &isDisablingAction;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ChangePhaseOfActionInternal_Private_Void_Int32_ptr_TriggerState_InputActionPhase_byref_TriggerState_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 969392, RefRangeEnd = 969393, XrefRangeStart = 969358, XrefRangeEnd = 969392, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CallActionListeners(int actionIndex, InputActionMap actionMap, InputActionPhase phase, ref CallbackArray<Il2CppSystem.Action<InputAction.CallbackContext>> listeners, string callbackName)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = (nint)(&actionIndex);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)actionMap);
		*(InputActionPhase**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &phase;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)listeners);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(callbackName);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CallActionListeners_Private_Void_Int32_InputActionMap_InputActionPhase_byref_CallbackArray_1_Action_1_CallbackContext_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 969393, XrefRangeEnd = 969394, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Il2CppSystem.Object GetActionOrNoneString(ref TriggerState trigger)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)Unsafe.AsPointer(ref trigger);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetActionOrNoneString_Private_Object_byref_TriggerState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
	}

	[CallerCount(7)]
	[CachedScanResults(RefRangeStart = 969394, RefRangeEnd = 969401, XrefRangeStart = 969394, XrefRangeEnd = 969394, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe InputAction GetActionOrNull(int bindingIndex)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&bindingIndex);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetActionOrNull_Internal_InputAction_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<InputAction>(intPtr2) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 969401, RefRangeEnd = 969402, XrefRangeStart = 969401, XrefRangeEnd = 969401, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe InputAction GetActionOrNull(ref TriggerState trigger)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)Unsafe.AsPointer(ref trigger);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetActionOrNull_Internal_InputAction_byref_TriggerState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<InputAction>(intPtr2) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 969403, RefRangeEnd = 969404, XrefRangeStart = 969402, XrefRangeEnd = 969403, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe InputControl GetControl(ref TriggerState trigger)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)Unsafe.AsPointer(ref trigger);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetControl_Internal_InputControl_byref_TriggerState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<InputControl>(intPtr2) : null;
	}

	[CallerCount(0)]
	public unsafe IInputInteraction GetInteractionOrNull(ref TriggerState trigger)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)Unsafe.AsPointer(ref trigger);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetInteractionOrNull_Private_IInputInteraction_byref_TriggerState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<IInputInteraction>(intPtr2) : null;
	}

	[CallerCount(0)]
	public unsafe int GetBindingIndexInMap(int bindingIndex)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&bindingIndex);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetBindingIndexInMap_Internal_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 969404, RefRangeEnd = 969405, XrefRangeStart = 969404, XrefRangeEnd = 969404, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int GetBindingIndexInState(int mapIndex, int bindingIndexInMap)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&mapIndex);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &bindingIndexInMap;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetBindingIndexInState_Internal_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 969405, RefRangeEnd = 969407, XrefRangeStart = 969405, XrefRangeEnd = 969405, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ref BindingState GetBindingState(int bindingIndex)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&bindingIndex);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetBindingState_Internal_byref_BindingState_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return ref *(BindingState*)intPtr2;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 969407, RefRangeEnd = 969409, XrefRangeStart = 969407, XrefRangeEnd = 969407, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ref InputBinding GetBinding(int bindingIndex)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&bindingIndex);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetBinding_Internal_byref_InputBinding_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return ref *(InputBinding*)intPtr2;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 969409, RefRangeEnd = 969410, XrefRangeStart = 969409, XrefRangeEnd = 969409, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe InputActionMap GetActionMap(int bindingIndex)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&bindingIndex);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetActionMap_Internal_InputActionMap_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<InputActionMap>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 969410, XrefRangeEnd = 969413, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ResetInteractionStateAndCancelIfNecessary(int mapIndex, int bindingIndex, int interactionIndex, InputActionPhase phaseAfterCanceled)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&mapIndex);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &bindingIndex;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &interactionIndex;
		*(InputActionPhase**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &phaseAfterCanceled;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ResetInteractionStateAndCancelIfNecessary_Private_Void_Int32_Int32_Int32_InputActionPhase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(7)]
	[CachedScanResults(RefRangeStart = 969417, RefRangeEnd = 969424, XrefRangeStart = 969413, XrefRangeEnd = 969417, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ResetInteractionState(int interactionIndex)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&interactionIndex);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ResetInteractionState_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 969428, RefRangeEnd = 969429, XrefRangeStart = 969424, XrefRangeEnd = 969428, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int GetValueSizeInBytes(int bindingIndex, int controlIndex)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&bindingIndex);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &controlIndex;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetValueSizeInBytes_Internal_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 969433, RefRangeEnd = 969435, XrefRangeStart = 969429, XrefRangeEnd = 969433, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Il2CppSystem.Type GetValueType(int bindingIndex, int controlIndex)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&bindingIndex);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &controlIndex;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetValueType_Internal_Type_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Type>(intPtr2) : null;
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 969438, RefRangeEnd = 969441, XrefRangeStart = 969435, XrefRangeEnd = 969438, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool IsActuated(ref TriggerState trigger, float threshold = 0f)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)Unsafe.AsPointer(ref trigger);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &threshold;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsActuated_Internal_Static_Boolean_byref_TriggerState_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 969446, RefRangeEnd = 969448, XrefRangeStart = 969441, XrefRangeEnd = 969446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ReadValue(int bindingIndex, int controlIndex, void* buffer, int bufferSize, bool ignoreComposites = false)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = (nint)(&bindingIndex);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &controlIndex;
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = buffer;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &bufferSize;
		*(bool**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &ignoreComposites;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ReadValue_Internal_Void_Int32_Int32_ptr_Void_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 969462, RefRangeEnd = 969464, XrefRangeStart = 969448, XrefRangeEnd = 969462, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe TValue ReadValue<TValue>(int bindingIndex, int controlIndex, bool ignoreComposites = false) where TValue : new()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&bindingIndex);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &controlIndex;
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &ignoreComposites;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_ReadValue_Internal_TValue_Int32_Int32_Boolean_0<TValue>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.PointerToValueGeneric<TValue>(intPtr2, false, true);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 969464, XrefRangeEnd = 969470, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe TValue ApplyProcessors<TValue>(int bindingIndex, TValue value, InputControl<TValue> controlOfType = null) where TValue : new()
	{
		//IL_005a->IL005d: Incompatible stack types: I vs Ref
		//IL_004d->IL005d: Incompatible stack types: I vs Ref
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&bindingIndex);
		byte* num = (byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)));
		ref TValue reference;
		if (!typeof(TValue).IsValueType)
		{
			object obj = value;
			reference = ref *(_003F*)((!(obj is string)) ? IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)((obj is Il2CppObjectBase) ? obj : null)) : IL2CPP.ManagedStringToIl2Cpp(obj as string));
		}
		else
		{
			reference = ref value;
		}
		*(void**)num = Unsafe.AsPointer(ref reference);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)controlOfType);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_ApplyProcessors_Internal_TValue_Int32_TValue_InputControl_1_TValue_0<TValue>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.PointerToValueGeneric<TValue>(intPtr2, false, true);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 969471, RefRangeEnd = 969472, XrefRangeStart = 969470, XrefRangeEnd = 969471, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float EvaluateCompositePartMagnitude(int bindingIndex, int partNumber)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&bindingIndex);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &partNumber;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_EvaluateCompositePartMagnitude_Public_Single_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 969472, RefRangeEnd = 969473, XrefRangeStart = 969472, XrefRangeEnd = 969472, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe double GetCompositePartPressTime(int bindingIndex, int partNumber)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&bindingIndex);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &partNumber;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetCompositePartPressTime_Internal_Double_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(double*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 969490, RefRangeEnd = 969492, XrefRangeStart = 969473, XrefRangeEnd = 969490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe TValue ReadCompositePartValue<TValue, TComparer>(int bindingIndex, int partNumber, bool* buttonValuePtr, out int controlIndex, TComparer comparer = default(TComparer)) where TValue : new()
	{
		//IL_0085->IL0088: Incompatible stack types: I vs Ref
		//IL_0078->IL0088: Incompatible stack types: I vs Ref
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = (nint)(&bindingIndex);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &partNumber;
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = buttonValuePtr;
		*(void**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref controlIndex);
		byte* num = (byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)));
		ref TComparer reference;
		if (!typeof(TComparer).IsValueType)
		{
			object obj = comparer;
			reference = ref *(_003F*)((!(obj is string)) ? IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)((obj is Il2CppObjectBase) ? obj : null)) : IL2CPP.ManagedStringToIl2Cpp(obj as string));
		}
		else
		{
			reference = ref comparer;
		}
		*(void**)num = Unsafe.AsPointer(ref reference);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_ReadCompositePartValue_Internal_TValue_Int32_Int32_ptr_Boolean_byref_Int32_TComparer_0<TValue, TComparer>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.PointerToValueGeneric<TValue>(intPtr2, false, true);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 969494, RefRangeEnd = 969495, XrefRangeStart = 969492, XrefRangeEnd = 969494, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool ReadCompositePartValue(int bindingIndex, int partNumber, void* buffer, int bufferSize)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&bindingIndex);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &partNumber;
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = buffer;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &bufferSize;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ReadCompositePartValue_Internal_Boolean_Int32_Int32_ptr_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 969497, RefRangeEnd = 969498, XrefRangeStart = 969495, XrefRangeEnd = 969497, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Il2CppSystem.Object ReadCompositePartValueAsObject(int bindingIndex, int partNumber)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&bindingIndex);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &partNumber;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ReadCompositePartValueAsObject_Internal_Object_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 969503, RefRangeEnd = 969506, XrefRangeStart = 969498, XrefRangeEnd = 969503, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Il2CppSystem.Object ReadValueAsObject(int bindingIndex, int controlIndex, bool ignoreComposites = false)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&bindingIndex);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &controlIndex;
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &ignoreComposites;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ReadValueAsObject_Internal_Object_Int32_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 969514, RefRangeEnd = 969515, XrefRangeStart = 969506, XrefRangeEnd = 969514, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool ReadValueAsButton(int bindingIndex, int controlIndex)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&bindingIndex);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &controlIndex;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ReadValueAsButton_Internal_Boolean_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 969515, XrefRangeEnd = 969559, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static ISavedState SaveAndResetState()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SaveAndResetState_Internal_Static_ISavedState_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<ISavedState>(intPtr2) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 969599, RefRangeEnd = 969600, XrefRangeStart = 969559, XrefRangeEnd = 969599, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AddToGlobalList()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddToGlobalList_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 969600, XrefRangeEnd = 969624, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RemoveMapFromGlobalList()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RemoveMapFromGlobalList_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 969624, XrefRangeEnd = 969655, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void CompactGlobalList()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CompactGlobalList_Private_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 969663, RefRangeEnd = 969666, XrefRangeStart = 969655, XrefRangeEnd = 969663, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void NotifyListenersOfActionChange(InputActionChange change)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&change);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_NotifyListenersOfActionChange_Internal_Void_InputActionChange_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 969683, RefRangeEnd = 969689, XrefRangeStart = 969666, XrefRangeEnd = 969683, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void NotifyListenersOfActionChange(InputActionChange change, Il2CppSystem.Object actionOrMapOrAsset)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&change);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)actionOrMapOrAsset);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_NotifyListenersOfActionChange_Internal_Static_Void_InputActionChange_Object_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 969747, RefRangeEnd = 969748, XrefRangeStart = 969689, XrefRangeEnd = 969747, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ResetGlobals()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ResetGlobals_Private_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 969770, RefRangeEnd = 969772, XrefRangeStart = 969748, XrefRangeEnd = 969770, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int FindAllEnabledActions(List<InputAction> result)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)result);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FindAllEnabledActions_Internal_Static_Int32_List_1_InputAction_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 969811, RefRangeEnd = 969816, XrefRangeStart = 969772, XrefRangeEnd = 969811, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void OnDeviceChange(InputDevice device, InputDeviceChange change)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)device);
		*(InputDeviceChange**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &change;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnDeviceChange_Internal_Static_Void_InputDevice_InputDeviceChange_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 969857, RefRangeEnd = 969858, XrefRangeStart = 969816, XrefRangeEnd = 969857, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void DeferredResolutionOfBindings()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DeferredResolutionOfBindings_Internal_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 969875, RefRangeEnd = 969876, XrefRangeStart = 969858, XrefRangeEnd = 969875, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void DisableAllActions()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DisableAllActions_Internal_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 969876, XrefRangeEnd = 969903, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void DestroyAllActionMapStates()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DestroyAllActionMapStates_Internal_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1950)]
	[CachedScanResults(RefRangeStart = 20036, RefRangeEnd = 21986, XrefRangeStart = 20036, XrefRangeEnd = 21986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe InputActionState()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InputActionState>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public InputActionState(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
