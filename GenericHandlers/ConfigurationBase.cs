namespace GenericHandlers;

public abstract class ConfigurationBase
{
    public bool? Approve { get; set; }

    public string? ApproveComment { get; set; }

    public bool? Automerge { get; set; }

    public DateTimeOffset CreatedAt { get; set; }

    public bool? Deploy { get; set; }

    public string? DeployComment { get; set; }

    public IList<string>? DeployEnvironments { get; set; }

    public bool? IsDisabled { get; set; }

    public string? PullRequestMergeMethod { get; set; }

    public IList<ReleaseFreeze>? ReleaseFreezes { get; set; }

    public IList<string>? RerunFailedChecks { get; set; }

    public int? RerunFailedChecksAttempts { get; set; }

    public DateTimeOffset UpdatedAt { get; set; }
}
