using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;

namespace UnityEngine.Windows.WebCam;

public class PhotoCapture : Il2CppSystem.Object
{
	[OriginalName("UnityEngine.CoreModule.dll", "", "CaptureResultType")]
	public enum CaptureResultType
	{
		Success,
		UnknownError
	}

	[StructLayout(LayoutKind.Explicit)]
	public struct PhotoCaptureResult
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_resultType;

		private static readonly System.IntPtr NativeFieldInfoPtr_hResult;

		[FieldOffset(0)]
		public CaptureResultType resultType;

		[FieldOffset(8)]
		public long hResult;

		static PhotoCaptureResult()
		{
			Il2CppClassPointerStore<PhotoCaptureResult>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PhotoCapture>.NativeClassPtr, "PhotoCaptureResult");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PhotoCaptureResult>.NativeClassPtr);
			NativeFieldInfoPtr_resultType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PhotoCaptureResult>.NativeClassPtr, "resultType");
			NativeFieldInfoPtr_hResult = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PhotoCaptureResult>.NativeClassPtr, "hResult");
		}

		public unsafe Il2CppSystem.Object BoxIl2CppObject()
		{
			return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PhotoCaptureResult>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
		}
	}

	public sealed class OnCaptureResourceCreatedCallback : Il2CppSystem.MulticastDelegate
	{
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_PhotoCapture_0;

		static OnCaptureResourceCreatedCallback()
		{
			Il2CppClassPointerStore<OnCaptureResourceCreatedCallback>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PhotoCapture>.NativeClassPtr, "OnCaptureResourceCreatedCallback");
			NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnCaptureResourceCreatedCallback>.NativeClassPtr, 100667053);
			NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_PhotoCapture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnCaptureResourceCreatedCallback>.NativeClassPtr, 100667054);
		}

		[CallerCount(542)]
		[CachedScanResults(RefRangeStart = 80261, RefRangeEnd = 80803, XrefRangeStart = 80261, XrefRangeEnd = 80803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe OnCaptureResourceCreatedCallback(Il2CppSystem.Object @object, System.IntPtr method)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OnCaptureResourceCreatedCallback>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)@object);
			*(System.IntPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &method;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(0)]
		public unsafe virtual void Invoke(PhotoCapture captureObject)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)captureObject);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_PhotoCapture_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		public OnCaptureResourceCreatedCallback(System.IntPtr pointer)
			: base(pointer)
		{
		}

		public static implicit operator OnCaptureResourceCreatedCallback(System.Action<PhotoCapture> P_0)
		{
			return DelegateSupport.ConvertDelegate<OnCaptureResourceCreatedCallback>((System.Delegate)P_0);
		}

		public static OnCaptureResourceCreatedCallback operator +(OnCaptureResourceCreatedCallback P_0, OnCaptureResourceCreatedCallback P_1)
		{
			return ((Il2CppObjectBase)Il2CppSystem.Delegate.Combine(P_0, P_1)).Cast<OnCaptureResourceCreatedCallback>();
		}

		public static OnCaptureResourceCreatedCallback operator -(OnCaptureResourceCreatedCallback P_0, OnCaptureResourceCreatedCallback P_1)
		{
			object obj = Il2CppSystem.Delegate.Remove(P_0, P_1);
			if (obj != null)
			{
				obj = ((Il2CppObjectBase)obj).Cast<OnCaptureResourceCreatedCallback>();
			}
			return (OnCaptureResourceCreatedCallback)obj;
		}
	}

	public sealed class OnPhotoModeStartedCallback : Il2CppSystem.MulticastDelegate
	{
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_PhotoCaptureResult_0;

		static OnPhotoModeStartedCallback()
		{
			Il2CppClassPointerStore<OnPhotoModeStartedCallback>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PhotoCapture>.NativeClassPtr, "OnPhotoModeStartedCallback");
			NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnPhotoModeStartedCallback>.NativeClassPtr, 100667055);
			NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_PhotoCaptureResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnPhotoModeStartedCallback>.NativeClassPtr, 100667056);
		}

		[CallerCount(146)]
		[CachedScanResults(RefRangeStart = 797393, RefRangeEnd = 797539, XrefRangeStart = 797393, XrefRangeEnd = 797539, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe OnPhotoModeStartedCallback(Il2CppSystem.Object @object, System.IntPtr method)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OnPhotoModeStartedCallback>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)@object);
			*(System.IntPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &method;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(0)]
		public unsafe virtual void Invoke(PhotoCaptureResult result)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&result);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_PhotoCaptureResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		public OnPhotoModeStartedCallback(System.IntPtr pointer)
			: base(pointer)
		{
		}

		public static implicit operator OnPhotoModeStartedCallback(System.Action<PhotoCaptureResult> P_0)
		{
			return DelegateSupport.ConvertDelegate<OnPhotoModeStartedCallback>((System.Delegate)P_0);
		}

		public static OnPhotoModeStartedCallback operator +(OnPhotoModeStartedCallback P_0, OnPhotoModeStartedCallback P_1)
		{
			return ((Il2CppObjectBase)Il2CppSystem.Delegate.Combine(P_0, P_1)).Cast<OnPhotoModeStartedCallback>();
		}

		public static OnPhotoModeStartedCallback operator -(OnPhotoModeStartedCallback P_0, OnPhotoModeStartedCallback P_1)
		{
			object obj = Il2CppSystem.Delegate.Remove(P_0, P_1);
			if (obj != null)
			{
				obj = ((Il2CppObjectBase)obj).Cast<OnPhotoModeStartedCallback>();
			}
			return (OnPhotoModeStartedCallback)obj;
		}
	}

	public sealed class OnPhotoModeStoppedCallback : Il2CppSystem.MulticastDelegate
	{
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_PhotoCaptureResult_0;

		static OnPhotoModeStoppedCallback()
		{
			Il2CppClassPointerStore<OnPhotoModeStoppedCallback>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PhotoCapture>.NativeClassPtr, "OnPhotoModeStoppedCallback");
			NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnPhotoModeStoppedCallback>.NativeClassPtr, 100667057);
			NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_PhotoCaptureResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnPhotoModeStoppedCallback>.NativeClassPtr, 100667058);
		}

		[CallerCount(146)]
		[CachedScanResults(RefRangeStart = 797393, RefRangeEnd = 797539, XrefRangeStart = 797393, XrefRangeEnd = 797539, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe OnPhotoModeStoppedCallback(Il2CppSystem.Object @object, System.IntPtr method)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OnPhotoModeStoppedCallback>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)@object);
			*(System.IntPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &method;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(0)]
		public unsafe virtual void Invoke(PhotoCaptureResult result)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&result);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_PhotoCaptureResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		public OnPhotoModeStoppedCallback(System.IntPtr pointer)
			: base(pointer)
		{
		}

		public static implicit operator OnPhotoModeStoppedCallback(System.Action<PhotoCaptureResult> P_0)
		{
			return DelegateSupport.ConvertDelegate<OnPhotoModeStoppedCallback>((System.Delegate)P_0);
		}

		public static OnPhotoModeStoppedCallback operator +(OnPhotoModeStoppedCallback P_0, OnPhotoModeStoppedCallback P_1)
		{
			return ((Il2CppObjectBase)Il2CppSystem.Delegate.Combine(P_0, P_1)).Cast<OnPhotoModeStoppedCallback>();
		}

		public static OnPhotoModeStoppedCallback operator -(OnPhotoModeStoppedCallback P_0, OnPhotoModeStoppedCallback P_1)
		{
			object obj = Il2CppSystem.Delegate.Remove(P_0, P_1);
			if (obj != null)
			{
				obj = ((Il2CppObjectBase)obj).Cast<OnPhotoModeStoppedCallback>();
			}
			return (OnPhotoModeStoppedCallback)obj;
		}
	}

	public sealed class OnCapturedToDiskCallback : Il2CppSystem.MulticastDelegate
	{
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_PhotoCaptureResult_0;

		static OnCapturedToDiskCallback()
		{
			Il2CppClassPointerStore<OnCapturedToDiskCallback>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PhotoCapture>.NativeClassPtr, "OnCapturedToDiskCallback");
			NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnCapturedToDiskCallback>.NativeClassPtr, 100667059);
			NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_PhotoCaptureResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnCapturedToDiskCallback>.NativeClassPtr, 100667060);
		}

		[CallerCount(146)]
		[CachedScanResults(RefRangeStart = 797393, RefRangeEnd = 797539, XrefRangeStart = 797393, XrefRangeEnd = 797539, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe OnCapturedToDiskCallback(Il2CppSystem.Object @object, System.IntPtr method)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OnCapturedToDiskCallback>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)@object);
			*(System.IntPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &method;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(0)]
		public unsafe virtual void Invoke(PhotoCaptureResult result)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&result);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_PhotoCaptureResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		public OnCapturedToDiskCallback(System.IntPtr pointer)
			: base(pointer)
		{
		}

		public static implicit operator OnCapturedToDiskCallback(System.Action<PhotoCaptureResult> P_0)
		{
			return DelegateSupport.ConvertDelegate<OnCapturedToDiskCallback>((System.Delegate)P_0);
		}

		public static OnCapturedToDiskCallback operator +(OnCapturedToDiskCallback P_0, OnCapturedToDiskCallback P_1)
		{
			return ((Il2CppObjectBase)Il2CppSystem.Delegate.Combine(P_0, P_1)).Cast<OnCapturedToDiskCallback>();
		}

		public static OnCapturedToDiskCallback operator -(OnCapturedToDiskCallback P_0, OnCapturedToDiskCallback P_1)
		{
			object obj = Il2CppSystem.Delegate.Remove(P_0, P_1);
			if (obj != null)
			{
				obj = ((Il2CppObjectBase)obj).Cast<OnCapturedToDiskCallback>();
			}
			return (OnCapturedToDiskCallback)obj;
		}
	}

	public sealed class OnCapturedToMemoryCallback : Il2CppSystem.MulticastDelegate
	{
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_PhotoCaptureResult_PhotoCaptureFrame_0;

		static OnCapturedToMemoryCallback()
		{
			Il2CppClassPointerStore<OnCapturedToMemoryCallback>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PhotoCapture>.NativeClassPtr, "OnCapturedToMemoryCallback");
			NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnCapturedToMemoryCallback>.NativeClassPtr, 100667061);
			NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_PhotoCaptureResult_PhotoCaptureFrame_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnCapturedToMemoryCallback>.NativeClassPtr, 100667062);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1222268, XrefRangeEnd = 1222271, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe OnCapturedToMemoryCallback(Il2CppSystem.Object @object, System.IntPtr method)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OnCapturedToMemoryCallback>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)@object);
			*(System.IntPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &method;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(0)]
		public unsafe virtual void Invoke(PhotoCaptureResult result, PhotoCaptureFrame photoCaptureFrame)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = (nint)(&result);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)photoCaptureFrame);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_PhotoCaptureResult_PhotoCaptureFrame_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		public OnCapturedToMemoryCallback(System.IntPtr pointer)
			: base(pointer)
		{
		}

		public static implicit operator OnCapturedToMemoryCallback(System.Action<PhotoCaptureResult, PhotoCaptureFrame> P_0)
		{
			return DelegateSupport.ConvertDelegate<OnCapturedToMemoryCallback>((System.Delegate)P_0);
		}

		public static OnCapturedToMemoryCallback operator +(OnCapturedToMemoryCallback P_0, OnCapturedToMemoryCallback P_1)
		{
			return ((Il2CppObjectBase)Il2CppSystem.Delegate.Combine(P_0, P_1)).Cast<OnCapturedToMemoryCallback>();
		}

		public static OnCapturedToMemoryCallback operator -(OnCapturedToMemoryCallback P_0, OnCapturedToMemoryCallback P_1)
		{
			object obj = Il2CppSystem.Delegate.Remove(P_0, P_1);
			if (obj != null)
			{
				obj = ((Il2CppObjectBase)obj).Cast<OnCapturedToMemoryCallback>();
			}
			return (OnCapturedToMemoryCallback)obj;
		}
	}

	public static class BindingsMarshaller : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeMethodInfoPtr_ConvertToNative_Public_Static_IntPtr_PhotoCapture_0;

		static BindingsMarshaller()
		{
			Il2CppClassPointerStore<BindingsMarshaller>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PhotoCapture>.NativeClassPtr, "BindingsMarshaller");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BindingsMarshaller>.NativeClassPtr);
			NativeMethodInfoPtr_ConvertToNative_Public_Static_IntPtr_PhotoCapture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BindingsMarshaller>.NativeClassPtr, 100667063);
		}

		[CallerCount(0)]
		public unsafe static System.IntPtr ConvertToNative(PhotoCapture photoCapture)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)photoCapture);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ConvertToNative_Public_Static_IntPtr_PhotoCapture_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(System.IntPtr*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		public BindingsMarshaller(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_m_NativePtr;

	private static readonly System.IntPtr NativeFieldInfoPtr_HR_SUCCESS;

	private static readonly System.IntPtr NativeMethodInfoPtr_MakeCaptureResult_Private_Static_PhotoCaptureResult_Int64_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InvokeOnCreatedResourceDelegate_Private_Static_Void_OnCaptureResourceCreatedCallback_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InvokeOnPhotoModeStartedDelegate_Private_Static_Void_OnPhotoModeStartedCallback_Int64_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InvokeOnPhotoModeStoppedDelegate_Private_Static_Void_OnPhotoModeStoppedCallback_Int64_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InvokeOnCapturedPhotoToDiskDelegate_Private_Static_Void_OnCapturedToDiskCallback_Int64_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InvokeOnCapturedPhotoToMemoryDelegate_Private_Static_Void_OnCapturedToMemoryCallback_Int64_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Internal_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DisposeThreaded_Internal_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Internal_Injected_Private_Static_Void_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DisposeThreaded_Internal_Injected_Private_Static_Void_IntPtr_0;

	public unsafe System.IntPtr m_NativePtr
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_NativePtr);
			return *(System.IntPtr*)num;
		}
		set
		{
			*(System.IntPtr*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_NativePtr)) = value;
		}
	}

	public unsafe static long HR_SUCCESS
	{
		get
		{
			Unsafe.SkipInit(out long result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_HR_SUCCESS, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_HR_SUCCESS, (void*)(&value));
		}
	}

	static PhotoCapture()
	{
		Il2CppClassPointerStore<PhotoCapture>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Windows.WebCam", "PhotoCapture");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PhotoCapture>.NativeClassPtr);
		NativeFieldInfoPtr_m_NativePtr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PhotoCapture>.NativeClassPtr, "m_NativePtr");
		NativeFieldInfoPtr_HR_SUCCESS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PhotoCapture>.NativeClassPtr, "HR_SUCCESS");
		NativeMethodInfoPtr_MakeCaptureResult_Private_Static_PhotoCaptureResult_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhotoCapture>.NativeClassPtr, 100667040);
		NativeMethodInfoPtr_InvokeOnCreatedResourceDelegate_Private_Static_Void_OnCaptureResourceCreatedCallback_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhotoCapture>.NativeClassPtr, 100667041);
		NativeMethodInfoPtr_InvokeOnPhotoModeStartedDelegate_Private_Static_Void_OnPhotoModeStartedCallback_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhotoCapture>.NativeClassPtr, 100667043);
		NativeMethodInfoPtr_InvokeOnPhotoModeStoppedDelegate_Private_Static_Void_OnPhotoModeStoppedCallback_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhotoCapture>.NativeClassPtr, 100667044);
		NativeMethodInfoPtr_InvokeOnCapturedPhotoToDiskDelegate_Private_Static_Void_OnCapturedToDiskCallback_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhotoCapture>.NativeClassPtr, 100667045);
		NativeMethodInfoPtr_InvokeOnCapturedPhotoToMemoryDelegate_Private_Static_Void_OnCapturedToMemoryCallback_Int64_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhotoCapture>.NativeClassPtr, 100667046);
		NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhotoCapture>.NativeClassPtr, 100667047);
		NativeMethodInfoPtr_Dispose_Internal_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhotoCapture>.NativeClassPtr, 100667048);
		NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhotoCapture>.NativeClassPtr, 100667049);
		NativeMethodInfoPtr_DisposeThreaded_Internal_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhotoCapture>.NativeClassPtr, 100667050);
		NativeMethodInfoPtr_Dispose_Internal_Injected_Private_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhotoCapture>.NativeClassPtr, 100667051);
		NativeMethodInfoPtr_DisposeThreaded_Internal_Injected_Private_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhotoCapture>.NativeClassPtr, 100667052);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1222271, XrefRangeEnd = 1222273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static PhotoCaptureResult MakeCaptureResult(long hResult)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&hResult);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MakeCaptureResult_Private_Static_PhotoCaptureResult_Int64_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(PhotoCaptureResult*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1222273, XrefRangeEnd = 1222277, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void InvokeOnCreatedResourceDelegate(OnCaptureResourceCreatedCallback callback, System.IntPtr nativePtr)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)callback);
		*(System.IntPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &nativePtr;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InvokeOnCreatedResourceDelegate_Private_Static_Void_OnCaptureResourceCreatedCallback_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1222277, XrefRangeEnd = 1222279, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void InvokeOnPhotoModeStartedDelegate(OnPhotoModeStartedCallback callback, long hResult)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)callback);
		*(long**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &hResult;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InvokeOnPhotoModeStartedDelegate_Private_Static_Void_OnPhotoModeStartedCallback_Int64_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void InvokeOnPhotoModeStoppedDelegate(OnPhotoModeStoppedCallback callback, long hResult)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)callback);
		*(long**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &hResult;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InvokeOnPhotoModeStoppedDelegate_Private_Static_Void_OnPhotoModeStoppedCallback_Int64_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void InvokeOnCapturedPhotoToDiskDelegate(OnCapturedToDiskCallback callback, long hResult)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)callback);
		*(long**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &hResult;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InvokeOnCapturedPhotoToDiskDelegate_Private_Static_Void_OnCapturedToDiskCallback_Int64_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1222279, XrefRangeEnd = 1222295, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void InvokeOnCapturedPhotoToMemoryDelegate(OnCapturedToMemoryCallback callback, long hResult, System.IntPtr photoCaptureFramePtr)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)callback);
		*(long**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &hResult;
		*(System.IntPtr**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &photoCaptureFramePtr;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InvokeOnCapturedPhotoToMemoryDelegate_Private_Static_Void_OnCapturedToMemoryCallback_Int64_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1222295, XrefRangeEnd = 1222301, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void Dispose()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1222301, XrefRangeEnd = 1222305, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Dispose_Internal()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Dispose_Internal_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1222305, XrefRangeEnd = 1222310, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public new unsafe void Finalize()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1222310, XrefRangeEnd = 1222314, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void DisposeThreaded_Internal()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DisposeThreaded_Internal_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1222314, XrefRangeEnd = 1222316, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Dispose_Internal_Injected(System.IntPtr _unity_self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&_unity_self);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Dispose_Internal_Injected_Private_Static_Void_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1222316, XrefRangeEnd = 1222318, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void DisposeThreaded_Internal_Injected(System.IntPtr _unity_self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&_unity_self);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DisposeThreaded_Internal_Injected_Private_Static_Void_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public PhotoCapture(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
