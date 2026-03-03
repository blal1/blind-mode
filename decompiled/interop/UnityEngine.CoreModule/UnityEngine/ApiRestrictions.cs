using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;

namespace UnityEngine;

public class ApiRestrictions
{
	public enum GlobalRestrictions
	{
		OBJECT_DESTROYIMMEDIATE,
		OBJECT_SENDMESSAGE,
		OBJECT_RENDERING,
		GLOBALCOUNT
	}

	public enum ContextRestrictions
	{
		RENDERERSCENE_ADDREMOVE,
		OBJECT_ADDCOMPONENTTRANSFORM,
		CONTEXTCOUNT
	}

	private delegate void PushDisableApiInternal_InjectedDelegate(ContextRestrictions contextApi, IntPtr context, GlobalRestrictions globalApi);

	private delegate void PopDisableApiInternal_InjectedDelegate(ContextRestrictions contextApi, IntPtr context, GlobalRestrictions globalApi);

	private delegate bool TryApiInternal_InjectedDelegate(ContextRestrictions contextApi, IntPtr context, GlobalRestrictions globalApi, bool allowErrorLogging);

	private static readonly PushDisableApiInternal_InjectedDelegate PushDisableApiInternal_InjectedDelegateField = IL2CPP.ResolveICall<PushDisableApiInternal_InjectedDelegate>("UnityEngine.ApiRestrictions::PushDisableApiInternal_Injected");

	private static readonly PopDisableApiInternal_InjectedDelegate PopDisableApiInternal_InjectedDelegateField = IL2CPP.ResolveICall<PopDisableApiInternal_InjectedDelegate>("UnityEngine.ApiRestrictions::PopDisableApiInternal_Injected");

	private static readonly TryApiInternal_InjectedDelegate TryApiInternal_InjectedDelegateField = IL2CPP.ResolveICall<TryApiInternal_InjectedDelegate>("UnityEngine.ApiRestrictions::TryApiInternal_Injected");

	public static void PushDisableApiInternal(ContextRestrictions contextApi, Object context, GlobalRestrictions globalApi)
	{
		PushDisableApiInternal_Injected(contextApi, Object.MarshalledUnityObject.Marshal(context), globalApi);
	}

	public static void PopDisableApiInternal(ContextRestrictions contextApi, Object context, GlobalRestrictions globalApi)
	{
		PopDisableApiInternal_Injected(contextApi, Object.MarshalledUnityObject.Marshal(context), globalApi);
	}

	public static bool TryApiInternal(ContextRestrictions contextApi, Object context, GlobalRestrictions globalApi, bool allowErrorLogging)
	{
		return TryApiInternal_Injected(contextApi, Object.MarshalledUnityObject.Marshal(context), globalApi, allowErrorLogging);
	}

	public static void PushDisableApi(ContextRestrictions api, Object owner)
	{
		PushDisableApiInternal(api, owner, GlobalRestrictions.GLOBALCOUNT);
	}

	public static void PushDisableApi(GlobalRestrictions api)
	{
		PushDisableApiInternal(ContextRestrictions.CONTEXTCOUNT, null, api);
	}

	public static void PopDisableApi(ContextRestrictions api, Object context)
	{
		PopDisableApiInternal(api, context, GlobalRestrictions.GLOBALCOUNT);
	}

	public static void PopDisableApi(GlobalRestrictions api)
	{
		PopDisableApiInternal(ContextRestrictions.CONTEXTCOUNT, null, api);
	}

	public static bool TryApi(ContextRestrictions api, Object context, [Optional] bool allowErrorLogging)
	{
		return TryApiInternal(api, context, GlobalRestrictions.GLOBALCOUNT, allowErrorLogging);
	}

	public static bool TryApi(GlobalRestrictions api, [Optional] bool allowErrorLogging)
	{
		return TryApiInternal(ContextRestrictions.CONTEXTCOUNT, null, api, allowErrorLogging);
	}

	public static void PushDisableApiInternal_Injected(ContextRestrictions contextApi, IntPtr context, GlobalRestrictions globalApi)
	{
		PushDisableApiInternal_InjectedDelegateField(contextApi, context, globalApi);
	}

	public static void PopDisableApiInternal_Injected(ContextRestrictions contextApi, IntPtr context, GlobalRestrictions globalApi)
	{
		PopDisableApiInternal_InjectedDelegateField(contextApi, context, globalApi);
	}

	public static bool TryApiInternal_Injected(ContextRestrictions contextApi, IntPtr context, GlobalRestrictions globalApi, bool allowErrorLogging)
	{
		return TryApiInternal_InjectedDelegateField(contextApi, context, globalApi, allowErrorLogging);
	}
}
