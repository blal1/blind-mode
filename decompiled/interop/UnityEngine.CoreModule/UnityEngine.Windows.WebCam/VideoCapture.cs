using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;

namespace UnityEngine.Windows.WebCam;

public class VideoCapture : Il2CppSystem.Object
{
	[OriginalName("UnityEngine.CoreModule.dll", "", "CaptureResultType")]
	public enum CaptureResultType
	{
		Success,
		UnknownError
	}

	[StructLayout(LayoutKind.Explicit)]
	public struct VideoCaptureResult
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_resultType;

		private static readonly System.IntPtr NativeFieldInfoPtr_hResult;

		[FieldOffset(0)]
		public CaptureResultType resultType;

		[FieldOffset(8)]
		public long hResult;

		static VideoCaptureResult()
		{
			Il2CppClassPointerStore<VideoCaptureResult>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VideoCapture>.NativeClassPtr, "VideoCaptureResult");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VideoCaptureResult>.NativeClassPtr);
			NativeFieldInfoPtr_resultType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VideoCaptureResult>.NativeClassPtr, "resultType");
			NativeFieldInfoPtr_hResult = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VideoCaptureResult>.NativeClassPtr, "hResult");
		}

		public unsafe Il2CppSystem.Object BoxIl2CppObject()
		{
			return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<VideoCaptureResult>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
		}
	}

	public sealed class OnVideoCaptureResourceCreatedCallback : Il2CppSystem.MulticastDelegate
	{
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_VideoCapture_0;

		static OnVideoCaptureResourceCreatedCallback()
		{
			Il2CppClassPointerStore<OnVideoCaptureResourceCreatedCallback>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VideoCapture>.NativeClassPtr, "OnVideoCaptureResourceCreatedCallback");
			NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnVideoCaptureResourceCreatedCallback>.NativeClassPtr, 100667094);
			NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_VideoCapture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnVideoCaptureResourceCreatedCallback>.NativeClassPtr, 100667095);
		}

		[CallerCount(542)]
		[CachedScanResults(RefRangeStart = 80261, RefRangeEnd = 80803, XrefRangeStart = 80261, XrefRangeEnd = 80803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe OnVideoCaptureResourceCreatedCallback(Il2CppSystem.Object @object, System.IntPtr method)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OnVideoCaptureResourceCreatedCallback>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)@object);
			*(System.IntPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &method;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(0)]
		public unsafe virtual void Invoke(VideoCapture captureObject)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)captureObject);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_VideoCapture_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		public OnVideoCaptureResourceCreatedCallback(System.IntPtr pointer)
			: base(pointer)
		{
		}

		public static implicit operator OnVideoCaptureResourceCreatedCallback(System.Action<VideoCapture> P_0)
		{
			return DelegateSupport.ConvertDelegate<OnVideoCaptureResourceCreatedCallback>((System.Delegate)P_0);
		}

		public static OnVideoCaptureResourceCreatedCallback operator +(OnVideoCaptureResourceCreatedCallback P_0, OnVideoCaptureResourceCreatedCallback P_1)
		{
			return ((Il2CppObjectBase)Il2CppSystem.Delegate.Combine(P_0, P_1)).Cast<OnVideoCaptureResourceCreatedCallback>();
		}

		public static OnVideoCaptureResourceCreatedCallback operator -(OnVideoCaptureResourceCreatedCallback P_0, OnVideoCaptureResourceCreatedCallback P_1)
		{
			object obj = Il2CppSystem.Delegate.Remove(P_0, P_1);
			if (obj != null)
			{
				obj = ((Il2CppObjectBase)obj).Cast<OnVideoCaptureResourceCreatedCallback>();
			}
			return (OnVideoCaptureResourceCreatedCallback)obj;
		}
	}

	public sealed class OnVideoModeStartedCallback : Il2CppSystem.MulticastDelegate
	{
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_VideoCaptureResult_0;

		static OnVideoModeStartedCallback()
		{
			Il2CppClassPointerStore<OnVideoModeStartedCallback>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VideoCapture>.NativeClassPtr, "OnVideoModeStartedCallback");
			NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnVideoModeStartedCallback>.NativeClassPtr, 100667096);
			NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_VideoCaptureResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnVideoModeStartedCallback>.NativeClassPtr, 100667097);
		}

		[CallerCount(146)]
		[CachedScanResults(RefRangeStart = 797393, RefRangeEnd = 797539, XrefRangeStart = 797393, XrefRangeEnd = 797539, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe OnVideoModeStartedCallback(Il2CppSystem.Object @object, System.IntPtr method)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OnVideoModeStartedCallback>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)@object);
			*(System.IntPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &method;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(0)]
		public unsafe virtual void Invoke(VideoCaptureResult result)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&result);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_VideoCaptureResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		public OnVideoModeStartedCallback(System.IntPtr pointer)
			: base(pointer)
		{
		}

		public static implicit operator OnVideoModeStartedCallback(System.Action<VideoCaptureResult> P_0)
		{
			return DelegateSupport.ConvertDelegate<OnVideoModeStartedCallback>((System.Delegate)P_0);
		}

		public static OnVideoModeStartedCallback operator +(OnVideoModeStartedCallback P_0, OnVideoModeStartedCallback P_1)
		{
			return ((Il2CppObjectBase)Il2CppSystem.Delegate.Combine(P_0, P_1)).Cast<OnVideoModeStartedCallback>();
		}

		public static OnVideoModeStartedCallback operator -(OnVideoModeStartedCallback P_0, OnVideoModeStartedCallback P_1)
		{
			object obj = Il2CppSystem.Delegate.Remove(P_0, P_1);
			if (obj != null)
			{
				obj = ((Il2CppObjectBase)obj).Cast<OnVideoModeStartedCallback>();
			}
			return (OnVideoModeStartedCallback)obj;
		}
	}

	public sealed class OnVideoModeStoppedCallback : Il2CppSystem.MulticastDelegate
	{
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_VideoCaptureResult_0;

		static OnVideoModeStoppedCallback()
		{
			Il2CppClassPointerStore<OnVideoModeStoppedCallback>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VideoCapture>.NativeClassPtr, "OnVideoModeStoppedCallback");
			NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnVideoModeStoppedCallback>.NativeClassPtr, 100667098);
			NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_VideoCaptureResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnVideoModeStoppedCallback>.NativeClassPtr, 100667099);
		}

		[CallerCount(146)]
		[CachedScanResults(RefRangeStart = 797393, RefRangeEnd = 797539, XrefRangeStart = 797393, XrefRangeEnd = 797539, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe OnVideoModeStoppedCallback(Il2CppSystem.Object @object, System.IntPtr method)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OnVideoModeStoppedCallback>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)@object);
			*(System.IntPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &method;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(0)]
		public unsafe virtual void Invoke(VideoCaptureResult result)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&result);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_VideoCaptureResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		public OnVideoModeStoppedCallback(System.IntPtr pointer)
			: base(pointer)
		{
		}

		public static implicit operator OnVideoModeStoppedCallback(System.Action<VideoCaptureResult> P_0)
		{
			return DelegateSupport.ConvertDelegate<OnVideoModeStoppedCallback>((System.Delegate)P_0);
		}

		public static OnVideoModeStoppedCallback operator +(OnVideoModeStoppedCallback P_0, OnVideoModeStoppedCallback P_1)
		{
			return ((Il2CppObjectBase)Il2CppSystem.Delegate.Combine(P_0, P_1)).Cast<OnVideoModeStoppedCallback>();
		}

		public static OnVideoModeStoppedCallback operator -(OnVideoModeStoppedCallback P_0, OnVideoModeStoppedCallback P_1)
		{
			object obj = Il2CppSystem.Delegate.Remove(P_0, P_1);
			if (obj != null)
			{
				obj = ((Il2CppObjectBase)obj).Cast<OnVideoModeStoppedCallback>();
			}
			return (OnVideoModeStoppedCallback)obj;
		}
	}

	public sealed class OnStartedRecordingVideoCallback : Il2CppSystem.MulticastDelegate
	{
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_VideoCaptureResult_0;

		static OnStartedRecordingVideoCallback()
		{
			Il2CppClassPointerStore<OnStartedRecordingVideoCallback>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VideoCapture>.NativeClassPtr, "OnStartedRecordingVideoCallback");
			NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnStartedRecordingVideoCallback>.NativeClassPtr, 100667100);
			NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_VideoCaptureResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnStartedRecordingVideoCallback>.NativeClassPtr, 100667101);
		}

		[CallerCount(146)]
		[CachedScanResults(RefRangeStart = 797393, RefRangeEnd = 797539, XrefRangeStart = 797393, XrefRangeEnd = 797539, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe OnStartedRecordingVideoCallback(Il2CppSystem.Object @object, System.IntPtr method)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OnStartedRecordingVideoCallback>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)@object);
			*(System.IntPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &method;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(0)]
		public unsafe virtual void Invoke(VideoCaptureResult result)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&result);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_VideoCaptureResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		public OnStartedRecordingVideoCallback(System.IntPtr pointer)
			: base(pointer)
		{
		}

		public static implicit operator OnStartedRecordingVideoCallback(System.Action<VideoCaptureResult> P_0)
		{
			return DelegateSupport.ConvertDelegate<OnStartedRecordingVideoCallback>((System.Delegate)P_0);
		}

		public static OnStartedRecordingVideoCallback operator +(OnStartedRecordingVideoCallback P_0, OnStartedRecordingVideoCallback P_1)
		{
			return ((Il2CppObjectBase)Il2CppSystem.Delegate.Combine(P_0, P_1)).Cast<OnStartedRecordingVideoCallback>();
		}

		public static OnStartedRecordingVideoCallback operator -(OnStartedRecordingVideoCallback P_0, OnStartedRecordingVideoCallback P_1)
		{
			object obj = Il2CppSystem.Delegate.Remove(P_0, P_1);
			if (obj != null)
			{
				obj = ((Il2CppObjectBase)obj).Cast<OnStartedRecordingVideoCallback>();
			}
			return (OnStartedRecordingVideoCallback)obj;
		}
	}

	public sealed class OnStoppedRecordingVideoCallback : Il2CppSystem.MulticastDelegate
	{
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_VideoCaptureResult_0;

		static OnStoppedRecordingVideoCallback()
		{
			Il2CppClassPointerStore<OnStoppedRecordingVideoCallback>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VideoCapture>.NativeClassPtr, "OnStoppedRecordingVideoCallback");
			NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnStoppedRecordingVideoCallback>.NativeClassPtr, 100667102);
			NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_VideoCaptureResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnStoppedRecordingVideoCallback>.NativeClassPtr, 100667103);
		}

		[CallerCount(146)]
		[CachedScanResults(RefRangeStart = 797393, RefRangeEnd = 797539, XrefRangeStart = 797393, XrefRangeEnd = 797539, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe OnStoppedRecordingVideoCallback(Il2CppSystem.Object @object, System.IntPtr method)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OnStoppedRecordingVideoCallback>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)@object);
			*(System.IntPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &method;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(0)]
		public unsafe virtual void Invoke(VideoCaptureResult result)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&result);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_VideoCaptureResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		public OnStoppedRecordingVideoCallback(System.IntPtr pointer)
			: base(pointer)
		{
		}

		public static implicit operator OnStoppedRecordingVideoCallback(System.Action<VideoCaptureResult> P_0)
		{
			return DelegateSupport.ConvertDelegate<OnStoppedRecordingVideoCallback>((System.Delegate)P_0);
		}

		public static OnStoppedRecordingVideoCallback operator +(OnStoppedRecordingVideoCallback P_0, OnStoppedRecordingVideoCallback P_1)
		{
			return ((Il2CppObjectBase)Il2CppSystem.Delegate.Combine(P_0, P_1)).Cast<OnStoppedRecordingVideoCallback>();
		}

		public static OnStoppedRecordingVideoCallback operator -(OnStoppedRecordingVideoCallback P_0, OnStoppedRecordingVideoCallback P_1)
		{
			object obj = Il2CppSystem.Delegate.Remove(P_0, P_1);
			if (obj != null)
			{
				obj = ((Il2CppObjectBase)obj).Cast<OnStoppedRecordingVideoCallback>();
			}
			return (OnStoppedRecordingVideoCallback)obj;
		}
	}

	public static class BindingsMarshaller : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeMethodInfoPtr_ConvertToNative_Public_Static_IntPtr_VideoCapture_0;

		static BindingsMarshaller()
		{
			Il2CppClassPointerStore<BindingsMarshaller>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VideoCapture>.NativeClassPtr, "BindingsMarshaller");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BindingsMarshaller>.NativeClassPtr);
			NativeMethodInfoPtr_ConvertToNative_Public_Static_IntPtr_VideoCapture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BindingsMarshaller>.NativeClassPtr, 100667104);
		}

		[CallerCount(0)]
		public unsafe static System.IntPtr ConvertToNative(VideoCapture videoCapture)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)videoCapture);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ConvertToNative_Public_Static_IntPtr_VideoCapture_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
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

	private static readonly System.IntPtr NativeMethodInfoPtr_MakeCaptureResult_Private_Static_VideoCaptureResult_Int64_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InvokeOnCreatedVideoCaptureResourceDelegate_Private_Static_Void_OnVideoCaptureResourceCreatedCallback_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InvokeOnVideoModeStartedDelegate_Private_Static_Void_OnVideoModeStartedCallback_Int64_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InvokeOnVideoModeStoppedDelegate_Private_Static_Void_OnVideoModeStoppedCallback_Int64_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InvokeOnStartedRecordingVideoToDiskDelegate_Private_Static_Void_OnStartedRecordingVideoCallback_Int64_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InvokeOnStoppedRecordingVideoToDiskDelegate_Private_Static_Void_OnStoppedRecordingVideoCallback_Int64_0;

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

	static VideoCapture()
	{
		Il2CppClassPointerStore<VideoCapture>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Windows.WebCam", "VideoCapture");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VideoCapture>.NativeClassPtr);
		NativeFieldInfoPtr_m_NativePtr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VideoCapture>.NativeClassPtr, "m_NativePtr");
		NativeFieldInfoPtr_HR_SUCCESS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VideoCapture>.NativeClassPtr, "HR_SUCCESS");
		NativeMethodInfoPtr_MakeCaptureResult_Private_Static_VideoCaptureResult_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VideoCapture>.NativeClassPtr, 100667081);
		NativeMethodInfoPtr_InvokeOnCreatedVideoCaptureResourceDelegate_Private_Static_Void_OnVideoCaptureResourceCreatedCallback_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VideoCapture>.NativeClassPtr, 100667082);
		NativeMethodInfoPtr_InvokeOnVideoModeStartedDelegate_Private_Static_Void_OnVideoModeStartedCallback_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VideoCapture>.NativeClassPtr, 100667084);
		NativeMethodInfoPtr_InvokeOnVideoModeStoppedDelegate_Private_Static_Void_OnVideoModeStoppedCallback_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VideoCapture>.NativeClassPtr, 100667085);
		NativeMethodInfoPtr_InvokeOnStartedRecordingVideoToDiskDelegate_Private_Static_Void_OnStartedRecordingVideoCallback_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VideoCapture>.NativeClassPtr, 100667086);
		NativeMethodInfoPtr_InvokeOnStoppedRecordingVideoToDiskDelegate_Private_Static_Void_OnStoppedRecordingVideoCallback_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VideoCapture>.NativeClassPtr, 100667087);
		NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VideoCapture>.NativeClassPtr, 100667088);
		NativeMethodInfoPtr_Dispose_Internal_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VideoCapture>.NativeClassPtr, 100667089);
		NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VideoCapture>.NativeClassPtr, 100667090);
		NativeMethodInfoPtr_DisposeThreaded_Internal_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VideoCapture>.NativeClassPtr, 100667091);
		NativeMethodInfoPtr_Dispose_Internal_Injected_Private_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VideoCapture>.NativeClassPtr, 100667092);
		NativeMethodInfoPtr_DisposeThreaded_Internal_Injected_Private_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VideoCapture>.NativeClassPtr, 100667093);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1222371, XrefRangeEnd = 1222373, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static VideoCaptureResult MakeCaptureResult(long hResult)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&hResult);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MakeCaptureResult_Private_Static_VideoCaptureResult_Int64_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(VideoCaptureResult*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1222373, XrefRangeEnd = 1222377, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void InvokeOnCreatedVideoCaptureResourceDelegate(OnVideoCaptureResourceCreatedCallback callback, System.IntPtr nativePtr)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)callback);
		*(System.IntPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &nativePtr;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InvokeOnCreatedVideoCaptureResourceDelegate_Private_Static_Void_OnVideoCaptureResourceCreatedCallback_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1222377, XrefRangeEnd = 1222379, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void InvokeOnVideoModeStartedDelegate(OnVideoModeStartedCallback callback, long hResult)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)callback);
		*(long**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &hResult;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InvokeOnVideoModeStartedDelegate_Private_Static_Void_OnVideoModeStartedCallback_Int64_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void InvokeOnVideoModeStoppedDelegate(OnVideoModeStoppedCallback callback, long hResult)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)callback);
		*(long**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &hResult;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InvokeOnVideoModeStoppedDelegate_Private_Static_Void_OnVideoModeStoppedCallback_Int64_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void InvokeOnStartedRecordingVideoToDiskDelegate(OnStartedRecordingVideoCallback callback, long hResult)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)callback);
		*(long**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &hResult;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InvokeOnStartedRecordingVideoToDiskDelegate_Private_Static_Void_OnStartedRecordingVideoCallback_Int64_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void InvokeOnStoppedRecordingVideoToDiskDelegate(OnStoppedRecordingVideoCallback callback, long hResult)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)callback);
		*(long**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &hResult;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InvokeOnStoppedRecordingVideoToDiskDelegate_Private_Static_Void_OnStoppedRecordingVideoCallback_Int64_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1222379, XrefRangeEnd = 1222385, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void Dispose()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1222385, XrefRangeEnd = 1222389, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Dispose_Internal()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Dispose_Internal_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1222389, XrefRangeEnd = 1222394, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public new unsafe void Finalize()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1222394, XrefRangeEnd = 1222398, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void DisposeThreaded_Internal()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DisposeThreaded_Internal_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1222398, XrefRangeEnd = 1222400, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Dispose_Internal_Injected(System.IntPtr _unity_self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&_unity_self);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Dispose_Internal_Injected_Private_Static_Void_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1222400, XrefRangeEnd = 1222402, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void DisposeThreaded_Internal_Injected(System.IntPtr _unity_self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&_unity_self);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DisposeThreaded_Internal_Injected_Private_Static_Void_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public VideoCapture(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
