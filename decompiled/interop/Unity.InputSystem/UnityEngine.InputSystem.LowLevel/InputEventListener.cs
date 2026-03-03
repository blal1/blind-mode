using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine.InputSystem.Utilities;

namespace UnityEngine.InputSystem.LowLevel;

[StructLayout(LayoutKind.Explicit)]
public struct InputEventListener
{
	public class ObserverState : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_observers;

		private static readonly System.IntPtr NativeFieldInfoPtr_onEventDelegate;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr___ctor_b__2_0_Private_Void_InputEventPtr_InputDevice_0;

		public unsafe InlinedArray<Il2CppSystem.IObserver<InputEventPtr>> observers
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_observers);
				return new InlinedArray<Il2CppSystem.IObserver<InputEventPtr>>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<InlinedArray<Il2CppSystem.IObserver<InputEventPtr>>>.NativeClassPtr, (System.IntPtr)num));
			}
			set
			{
				// IL cpblk instruction
				Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_observers), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<InlinedArray<Il2CppSystem.IObserver<InputEventPtr>>>.NativeClassPtr, ref *(uint*)null));
			}
		}

		public unsafe Il2CppSystem.Action<InputEventPtr, InputDevice> onEventDelegate
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_onEventDelegate);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Action<InputEventPtr, InputDevice>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_onEventDelegate)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		static ObserverState()
		{
			Il2CppClassPointerStore<ObserverState>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<InputEventListener>.NativeClassPtr, "ObserverState");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ObserverState>.NativeClassPtr);
			NativeFieldInfoPtr_observers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObserverState>.NativeClassPtr, "observers");
			NativeFieldInfoPtr_onEventDelegate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObserverState>.NativeClassPtr, "onEventDelegate");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObserverState>.NativeClassPtr, 100667535);
			NativeMethodInfoPtr___ctor_b__2_0_Private_Void_InputEventPtr_InputDevice_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObserverState>.NativeClassPtr, 100667536);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1008360, XrefRangeEnd = 1008368, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ObserverState()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ObserverState>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1008368, XrefRangeEnd = 1008374, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void __ctor_b__2_0(InputEventPtr eventPtr, InputDevice device)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = (nint)(&eventPtr);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)device);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr___ctor_b__2_0_Private_Void_InputEventPtr_InputDevice_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		public ObserverState(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	public class DisposableObserver : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_observer;

		private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		public unsafe Il2CppSystem.IObserver<InputEventPtr> observer
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_observer);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.IObserver<InputEventPtr>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_observer)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		static DisposableObserver()
		{
			Il2CppClassPointerStore<DisposableObserver>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<InputEventListener>.NativeClassPtr, "DisposableObserver");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DisposableObserver>.NativeClassPtr);
			NativeFieldInfoPtr_observer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DisposableObserver>.NativeClassPtr, "observer");
			NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DisposableObserver>.NativeClassPtr, 100667537);
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DisposableObserver>.NativeClassPtr, 100667538);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1008374, XrefRangeEnd = 1008390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(1950)]
		[CachedScanResults(RefRangeStart = 20036, RefRangeEnd = 21986, XrefRangeStart = 20036, XrefRangeEnd = 21986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DisposableObserver()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DisposableObserver>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		public DisposableObserver(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_s_ObserverState;

	private static readonly System.IntPtr NativeMethodInfoPtr_op_Addition_Public_Static_InputEventListener_InputEventListener_Action_2_InputEventPtr_InputDevice_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_op_Subtraction_Public_Static_InputEventListener_InputEventListener_Action_2_InputEventPtr_InputDevice_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Subscribe_Public_Virtual_Final_New_IDisposable_IObserver_1_InputEventPtr_0;

	public unsafe static ObserverState s_ObserverState
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_ObserverState, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<ObserverState>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_ObserverState, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	static InputEventListener()
	{
		Il2CppClassPointerStore<InputEventListener>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.InputSystem.dll", "UnityEngine.InputSystem.LowLevel", "InputEventListener");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InputEventListener>.NativeClassPtr);
		NativeFieldInfoPtr_s_ObserverState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputEventListener>.NativeClassPtr, "s_ObserverState");
		NativeMethodInfoPtr_op_Addition_Public_Static_InputEventListener_InputEventListener_Action_2_InputEventPtr_InputDevice_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputEventListener>.NativeClassPtr, 100667532);
		NativeMethodInfoPtr_op_Subtraction_Public_Static_InputEventListener_InputEventListener_Action_2_InputEventPtr_InputDevice_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputEventListener>.NativeClassPtr, 100667533);
		NativeMethodInfoPtr_Subscribe_Public_Virtual_Final_New_IDisposable_IObserver_1_InputEventPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputEventListener>.NativeClassPtr, 100667534);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 1008402, RefRangeEnd = 1008407, XrefRangeStart = 1008390, XrefRangeEnd = 1008402, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static InputEventListener operator +(InputEventListener _, Il2CppSystem.Action<InputEventPtr, InputDevice> callback)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&_);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)callback);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_op_Addition_Public_Static_InputEventListener_InputEventListener_Action_2_InputEventPtr_InputDevice_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(InputEventListener*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 1008419, RefRangeEnd = 1008423, XrefRangeStart = 1008407, XrefRangeEnd = 1008419, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static InputEventListener operator -(InputEventListener _, Il2CppSystem.Action<InputEventPtr, InputDevice> callback)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&_);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)callback);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_op_Subtraction_Public_Static_InputEventListener_InputEventListener_Action_2_InputEventPtr_InputDevice_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(InputEventListener*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1008423, XrefRangeEnd = 1008455, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual Il2CppSystem.IDisposable Subscribe(Il2CppSystem.IObserver<InputEventPtr> observer)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)observer);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Subscribe_Public_Virtual_Final_New_IDisposable_IObserver_1_InputEventPtr_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.IDisposable>(intPtr2) : null;
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<InputEventListener>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}
}
