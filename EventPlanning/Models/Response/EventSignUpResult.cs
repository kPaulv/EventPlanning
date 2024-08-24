namespace EventPlanning.Models.Response
{
	public enum EventSignUpResult
	{
		Success = 0,
		LimitExceeded = 1,
		EventNotFound = 2,
		UserNotFound = 3,
		SignUpFailed = 4
	}
}
