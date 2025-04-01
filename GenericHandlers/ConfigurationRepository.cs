
namespace GenericHandlers;

public sealed class ConfigurationRepository : IConfigurationRepository
{
    public Task<bool> CreateInstallationAsync(long installationId, long ownerId, CancellationToken cancellationToken)
        => Task.FromResult(true);

    public Task<bool> CreateRepositoryAsync(long repositoryId, CancellationToken cancellationToken)
        => Task.FromResult(true);

    public Task DeleteInstallationAsync(long installationId, CancellationToken cancellationToken)
        => Task.FromResult(true);

    public Task EnsureRepositoryAsync(long repositoryId, CancellationToken cancellationToken)
        => Task.FromResult(true);

    public Task<string?> GetAppAccessTokenAsync(long userId, CancellationToken cancellationToken)
        => Task.FromResult<string?>(null);

    public Task<InstallationConfiguration?> GetInstallationAsync(long installationId, CancellationToken cancellationToken)
        => Task.FromResult<InstallationConfiguration?>(null);

    public Task<RepositoryConfiguration?> GetRepositoryAsync(long repositoryId, CancellationToken cancellationToken)
        => Task.FromResult<RepositoryConfiguration?>(null);

    public Task<bool> StoreAppAccessTokenAsync(long userId, string accessToken, CancellationToken cancellationToken)
        => Task.FromResult(true);

    public Task<bool> UpdateApproveAsync(InstallationId id, bool value, CancellationToken cancellationToken)
        => Task.FromResult(true);

    public Task<bool> UpdateApproveAsync(RepositoryId id, bool? value, CancellationToken cancellationToken)
        => Task.FromResult(true);

    public Task<bool> UpdateApproveCommentAsync(InstallationId id, string value, CancellationToken cancellationToken)
        => Task.FromResult(true);

    public Task<bool> UpdateApproveCommentAsync(RepositoryId id, string? value, CancellationToken cancellationToken)
        => Task.FromResult(true);

    public Task<bool> UpdateAutomergeAsync(InstallationId id, bool value, CancellationToken cancellationToken)
        => Task.FromResult(true);

    public Task<bool> UpdateAutomergeAsync(RepositoryId id, bool? value, CancellationToken cancellationToken)
        => Task.FromResult(true);

    public Task<bool> UpdateDeploymentAsync(InstallationId id, bool value, CancellationToken cancellationToken)
        => Task.FromResult(true);

    public Task<bool> UpdateDeploymentAsync(RepositoryId id, bool? value, CancellationToken cancellationToken)
        => Task.FromResult(true);

    public Task<bool> UpdateDeploymentCommentAsync(InstallationId id, string value, CancellationToken cancellationToken)
        => Task.FromResult(true);

    public Task<bool> UpdateDeploymentCommentAsync(RepositoryId id, string? value, CancellationToken cancellationToken)
        => Task.FromResult(true);

    public Task<bool> UpdateDeploymentEnvironmentsAsync(InstallationId id, IList<string> values, CancellationToken cancellationToken)
        => Task.FromResult(true);

    public Task<bool> UpdateDeploymentEnvironmentsAsync(RepositoryId id, IList<string>? values, CancellationToken cancellationToken)
        => Task.FromResult(true);

    public Task<bool> UpdateIsDisabledAsync(InstallationId id, bool value, CancellationToken cancellationToken)
        => Task.FromResult(true);

    public Task<bool> UpdateIsDisabledAsync(RepositoryId id, bool? value, CancellationToken cancellationToken)
        => Task.FromResult(true);

    public Task<bool> UpdatePullRequestMergeMethodAsync(InstallationId id, string value, CancellationToken cancellationToken)
        => Task.FromResult(true);

    public Task<bool> UpdatePullRequestMergeMethodAsync(RepositoryId id, string? value, CancellationToken cancellationToken)
        => Task.FromResult(true);

    public Task<bool> UpdateReleaseFreezesAsync(InstallationId id, IList<ReleaseFreeze> values, CancellationToken cancellationToken)
        => Task.FromResult(true);

    public Task<bool> UpdateReleaseFreezesAsync(RepositoryId id, IList<ReleaseFreeze>? values, CancellationToken cancellationToken)
        => Task.FromResult(true);

    public Task<bool> UpdateStatusCheckAttemptsAsync(InstallationId id, int value, CancellationToken cancellationToken)
        => Task.FromResult(true);

    public Task<bool> UpdateStatusCheckAttemptsAsync(RepositoryId id, int? value, CancellationToken cancellationToken)
        => Task.FromResult(true);

    public Task<bool> UpdateStatusChecksAsync(InstallationId id, IList<string> values, CancellationToken cancellationToken)
        => Task.FromResult(true);

    public Task<bool> UpdateStatusChecksAsync(RepositoryId id, IList<string>? values, CancellationToken cancellationToken)
        => Task.FromResult(true);
}
