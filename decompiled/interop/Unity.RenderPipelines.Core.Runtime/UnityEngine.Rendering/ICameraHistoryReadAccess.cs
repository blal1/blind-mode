using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Reflection;

namespace UnityEngine.Rendering;

public class ICameraHistoryReadAccess : Il2CppObjectBase
{
	public sealed class HistoryRequestDelegate : Il2CppSystem.MulticastDelegate
	{
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IPerFrameHistoryAccessTracker_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IPerFrameHistoryAccessTracker_AsyncCallback_Object_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;

		static HistoryRequestDelegate()
		{
			Il2CppClassPointerStore<HistoryRequestDelegate>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ICameraHistoryReadAccess>.NativeClassPtr, "HistoryRequestDelegate");
			NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HistoryRequestDelegate>.NativeClassPtr, 100663462);
			NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IPerFrameHistoryAccessTracker_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HistoryRequestDelegate>.NativeClassPtr, 100663463);
			NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IPerFrameHistoryAccessTracker_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HistoryRequestDelegate>.NativeClassPtr, 100663464);
			NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HistoryRequestDelegate>.NativeClassPtr, 100663465);
		}

		[CallerCount(588)]
		[CachedScanResults(RefRangeStart = 148277, RefRangeEnd = 148865, XrefRangeStart = 148277, XrefRangeEnd = 148865, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HistoryRequestDelegate(Il2CppSystem.Object @object, System.IntPtr method)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HistoryRequestDelegate>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)@object);
			*(System.IntPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &method;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(0)]
		public unsafe virtual void Invoke(IPerFrameHistoryAccessTracker historyAccess)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)historyAccess);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IPerFrameHistoryAccessTracker_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 50589, RefRangeEnd = 50590, XrefRangeStart = 50589, XrefRangeEnd = 50590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Il2CppSystem.IAsyncResult BeginInvoke(IPerFrameHistoryAccessTracker historyAccess, Il2CppSystem.AsyncCallback callback, Il2CppSystem.Object @object)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[3];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)historyAccess);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)callback);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)@object);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IPerFrameHistoryAccessTracker_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.IAsyncResult>(intPtr2) : null;
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void EndInvoke(Il2CppSystem.IAsyncResult result)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)result);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		public HistoryRequestDelegate(System.IntPtr pointer)
			: base(pointer)
		{
		}

		public static implicit operator HistoryRequestDelegate(System.Action<IPerFrameHistoryAccessTracker> P_0)
		{
			return DelegateSupport.ConvertDelegate<HistoryRequestDelegate>((System.Delegate)P_0);
		}

		public static HistoryRequestDelegate operator +(HistoryRequestDelegate P_0, HistoryRequestDelegate P_1)
		{
			return ((Il2CppObjectBase)Il2CppSystem.Delegate.Combine(P_0, P_1)).Cast<HistoryRequestDelegate>();
		}

		public static HistoryRequestDelegate operator -(HistoryRequestDelegate P_0, HistoryRequestDelegate P_1)
		{
			object obj = Il2CppSystem.Delegate.Remove(P_0, P_1);
			if (obj != null)
			{
				obj = ((Il2CppObjectBase)obj).Cast<HistoryRequestDelegate>();
			}
			return (HistoryRequestDelegate)obj;
		}
	}

	private sealed class MethodInfoStoreGeneric_GetHistoryForRead_Public_Abstract_Virtual_New_Type_0<Type>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_GetHistoryForRead_Public_Abstract_Virtual_New_Type_0, Il2CppClassPointerStore<ICameraHistoryReadAccess>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<Type>.NativeClassPtr)) }))));
	}

	private static readonly System.IntPtr NativeMethodInfoPtr_GetHistoryForRead_Public_Abstract_Virtual_New_Type_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_add_OnGatherHistoryRequests_Public_Abstract_Virtual_New_add_Void_HistoryRequestDelegate_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_remove_OnGatherHistoryRequests_Public_Abstract_Virtual_New_rem_Void_HistoryRequestDelegate_0;

	static ICameraHistoryReadAccess()
	{
		Il2CppClassPointerStore<ICameraHistoryReadAccess>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Core.Runtime.dll", "UnityEngine.Rendering", "ICameraHistoryReadAccess");
		NativeMethodInfoPtr_GetHistoryForRead_Public_Abstract_Virtual_New_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ICameraHistoryReadAccess>.NativeClassPtr, 100663459);
		NativeMethodInfoPtr_add_OnGatherHistoryRequests_Public_Abstract_Virtual_New_add_Void_HistoryRequestDelegate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ICameraHistoryReadAccess>.NativeClassPtr, 100663460);
		NativeMethodInfoPtr_remove_OnGatherHistoryRequests_Public_Abstract_Virtual_New_rem_Void_HistoryRequestDelegate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ICameraHistoryReadAccess>.NativeClassPtr, 100663461);
	}

	[CallerCount(0)]
	public unsafe virtual Type GetHistoryForRead<Type>() where Type : ContextItem
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), MethodInfoStoreGeneric_GetHistoryForRead_Public_Abstract_Virtual_New_Type_0<Type>.Pointer), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.PointerToValueGeneric<Type>(intPtr2, false, true);
	}

	[SpecialName]
	[CallerCount(0)]
	public unsafe virtual void add_OnGatherHistoryRequests(HistoryRequestDelegate value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_add_OnGatherHistoryRequests_Public_Abstract_Virtual_New_add_Void_HistoryRequestDelegate_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[SpecialName]
	[CallerCount(0)]
	public unsafe virtual void remove_OnGatherHistoryRequests(HistoryRequestDelegate value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_remove_OnGatherHistoryRequests_Public_Abstract_Virtual_New_rem_Void_HistoryRequestDelegate_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public ICameraHistoryReadAccess(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
