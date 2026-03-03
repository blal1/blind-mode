using System;
using Il2CppSystem;

namespace UnityEngine;

public class AwaitableCompletionSource
{
	public Awaitable Awaitable
	{
		get
		{
			throw new System.NotSupportedException("Method unstripping failed");
		}
		set
		{
			throw new System.NotSupportedException("Method unstripping failed");
		}
	}

	public void SetResult()
	{
		if (!TrySetResult())
		{
			throw new Il2CppSystem.InvalidOperationException("Can't raise completion of the same Awaitable twice");
		}
	}

	public void SetCanceled()
	{
		if (!TrySetCanceled())
		{
			throw new Il2CppSystem.InvalidOperationException("Can't raise completion of the same Awaitable twice");
		}
	}

	public void SetException(Il2CppSystem.Exception exception)
	{
		if (!TrySetException(exception))
		{
			throw new Il2CppSystem.InvalidOperationException("Can't raise completion of the same Awaitable twice");
		}
	}

	public bool CheckAndAcquireCompletionState()
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	public bool TrySetResult()
	{
		if (!CheckAndAcquireCompletionState())
		{
			return false;
		}
		Awaitable.RaiseManagedCompletion();
		return true;
	}

	public bool TrySetCanceled()
	{
		if (!CheckAndAcquireCompletionState())
		{
			return false;
		}
		Awaitable.Cancel();
		return true;
	}

	public bool TrySetException(Il2CppSystem.Exception exception)
	{
		if (!CheckAndAcquireCompletionState())
		{
			return false;
		}
		Awaitable.RaiseManagedCompletion(exception);
		return true;
	}

	public void Reset()
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}
}
