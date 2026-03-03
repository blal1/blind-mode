namespace Unity.Curl;

public enum CurlEasyHandleFlags : uint
{
	kSendBody = 1u,
	kReceiveHeaders = 2u,
	kReceiveBody = 4u,
	kFollowRedirects = 8u
}
